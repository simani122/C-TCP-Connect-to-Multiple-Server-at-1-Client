using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace TCP_Connect_to_MultipleServer
{
    public class TCP_Client_ObjecClass
    {
        private Socket ServerSocket = null;
        private int serverID = 0;
        private TCP_Client client = null;
        private byte[] buff = new byte[4096];

        public TCP_Client_ObjecClass(Socket soc, int ID, TCP_Client _tcp_Client)
        {
            ServerSocket = soc;
            client = _tcp_Client;
            serverID = ID;
            Receive();
        }

        private void Receive()
        {
            ServerSocket.BeginReceive(buff, 0, 4096, SocketFlags.None, new AsyncCallback(ReceiveCallBack), buff);
        }


        private void ReceiveCallBack(IAsyncResult ar)
        {
            try
            {
                byte[] Ibuff = (byte[])ar.AsyncState;
                int recv = ServerSocket.EndReceive(ar);
                string ip = ((IPEndPoint)ServerSocket.RemoteEndPoint).Address.ToString();
                if (recv == 0)
                {
                    Disconnet();
                    return;
                }
                else
                {
                    //리시브
                    byte[] dataBuff = new byte[recv];
                    Array.Copy(Ibuff, dataBuff, recv);
                    string data = Encoding.UTF8.GetString(dataBuff);
                    if (ip == Common.Server1_IP)
                    {
                        Common.ServeIP_1_Data = data;
                    }
                    if (ip == Common.Server2_IP)
                    {
                        Common.ServerIP_2_Data = data;
                    }

                    Receive();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Disconnet();
            }
        }

        public void ServerSend(byte[] Ibuff)
        {
            try
            {
                ServerSocket.BeginSend(Ibuff, 0, Ibuff.Length, SocketFlags.None, new AsyncCallback(SendCallBack), Ibuff);
            }
            catch
            {
                Disconnet();
            }
        }

        private void SendCallBack(IAsyncResult ar)
        {
            try
            {
                int send = ServerSocket.EndSend(ar);
                if (send == 0)
                {
                    Disconnet();
                }
                else
                {
                    Receive();
                }
            }
            catch
            {
                Disconnet();
            }
        }

        public void Disconnet()
        {
            try
            {
                if (ServerSocket != null)
                {
                    ServerSocket.Close();
                    int id = serverID;
                    serverID = 0;
                    client.DeleteHash(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
        }
    }
}
