using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Connect_to_MultipleServer
{
    public partial class MainForm : Form
    {
       

        #region 멤버 Member
        public TCP_Client _client = null;
        private Thread worker = null;
        #endregion

        #region 생성자 Init
        public MainForm()
        {
            InitializeComponent();
            _client = new TCP_Client();
            worker = new Thread(new ThreadStart(ProcessWorker));
            worker.IsBackground = true;
            worker.Start();
        }
        #endregion

        #region 쓰레드 Thread 

        private void ProcessWorker()
        {
            while (true)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new MethodInvoker(delegate
                    {
                        if (Common.ServeIP_1_Data != string.Empty)
                        {
                            txt_Server1_Protocol.AppendText(Common.ServeIP_1_Data + Environment.NewLine);
                            Common.ServeIP_1_Data = string.Empty;
                        }
                        if (Common.ServerIP_2_Data != string.Empty)
                        {
                            txt_Server2_Protocol.AppendText(Common.ServerIP_2_Data + Environment.NewLine);
                            Common.ServerIP_2_Data = string.Empty;
                        }
                    }));
                }
                Thread.Sleep(1);
            }
        }

        #endregion

        #region 연결 & 종료 버튼  Connect & Disconnect
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Common.Server1_IP = txt_IP_Server1.Text;
                Common.Server2_IP = txt_IP_Server1.Text;
                Common.Server1_Port = int.Parse(txt_Port1.Text);
                Common.Server2_Port = int.Parse(txt_Port2.Text);

                _client.DoConnect();
            }
            catch
            {
                MessageBox.Show("Input Correctly");
            }
            
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            _client.Disconnect();
        }

        #endregion

        #region 프로그램 종료 Exit

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Disconnect();
        }
        #endregion
    }
}
