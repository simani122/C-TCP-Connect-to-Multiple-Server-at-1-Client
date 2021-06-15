using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Threading;

namespace TCP_Connect_to_MultipleServer
{
    public class TCP_Client
    {
        #region 멤버변수 Member
        private Socket ClientSocket = null;
        public Hashtable ServerHashTable = new Hashtable();

        private int port = 41200;

        public bool isConnected = false;
        #endregion

        #region 생성자 Init

        public TCP_Client()
        {

        }

        #endregion

        #region Connect 연결
        public void DoConnect()
        {
            Connect(Common.Server1_IP, Common.Server1_Port);
            Connect(Common.Server2_IP, Common.Server2_Port);
        }

        private void Connect(string _ServerIP, int _ServerPort)
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPAddress serverIP = IPAddress.Parse(_ServerIP);
            int intServerID = 0;
            try
            {
                if (_ServerIP == Common.Server1_IP) { intServerID = 1; }
                if (_ServerIP == Common.Server2_IP) { intServerID = 2; }
                if (intServerID == 0) { return; }
                if (ServerHashTable.ContainsKey(intServerID)) { return; }

                ClientSocket.Connect(new IPEndPoint(serverIP, _ServerPort));

                TCP_Client_ObjecClass hotasServer = new TCP_Client_ObjecClass(ClientSocket, intServerID, this);

                ServerHashTable.Add(intServerID, hotasServer);
                isConnected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
        }
        #endregion

        #region Send 전송
        public void Send(int id, string msg)
        {
            if (ServerHashTable.ContainsKey(id))
            {
                byte[] ibuff = Encoding.UTF8.GetBytes(msg);
                ((TCP_Client_ObjecClass)ServerHashTable[id]).ServerSend(ibuff);
            }
        }

        public void Send(int id, byte[] msg)
        {
            if (ServerHashTable.ContainsKey(id))
            {
                ((TCP_Client_ObjecClass)ServerHashTable[id]).ServerSend(msg);
            }
        }

        #endregion

        #region 종료 Exit

        public void Disconnect()
        {
            int id1 = 1;
            int id2 = 2;
            if (ServerHashTable.ContainsKey(id1))
            {
                ((TCP_Client_ObjecClass)ServerHashTable[id1]).Disconnet();
            }
            if (ServerHashTable.ContainsKey(id2))
            {
                ((TCP_Client_ObjecClass)ServerHashTable[id2]).Disconnet();
            }
        }
        public void DeleteHash(int key)
        {
            if (ServerHashTable.ContainsKey(key))
            {
                ServerHashTable.Remove(key);
            }
        }
        #endregion

        #region 유틸 UTIL
        public byte[] TransByte(string str)
        {
            byte[] trans = Encoding.UTF8.GetBytes(str);
            return trans;
        }
        #endregion
    }
}
