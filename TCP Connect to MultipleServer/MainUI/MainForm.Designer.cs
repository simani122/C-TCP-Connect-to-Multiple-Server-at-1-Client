
namespace TCP_Connect_to_MultipleServer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Server2_Protocol = new System.Windows.Forms.TextBox();
            this.txt_Server1_Protocol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IP_Server2 = new System.Windows.Forms.TextBox();
            this.txt_IP_Server1 = new System.Windows.Forms.TextBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_Port1 = new System.Windows.Forms.TextBox();
            this.txt_Port2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Server2_Protocol
            // 
            this.txt_Server2_Protocol.Location = new System.Drawing.Point(535, 67);
            this.txt_Server2_Protocol.Multiline = true;
            this.txt_Server2_Protocol.Name = "txt_Server2_Protocol";
            this.txt_Server2_Protocol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Server2_Protocol.Size = new System.Drawing.Size(283, 391);
            this.txt_Server2_Protocol.TabIndex = 12;
            // 
            // txt_Server1_Protocol
            // 
            this.txt_Server1_Protocol.Location = new System.Drawing.Point(233, 67);
            this.txt_Server1_Protocol.Multiline = true;
            this.txt_Server1_Protocol.Name = "txt_Server1_Protocol";
            this.txt_Server1_Protocol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Server1_Protocol.Size = new System.Drawing.Size(283, 391);
            this.txt_Server1_Protocol.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(625, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "SERVER2 Recv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "SERVER1 Recv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server 1";
            // 
            // txt_IP_Server2
            // 
            this.txt_IP_Server2.Location = new System.Drawing.Point(89, 196);
            this.txt_IP_Server2.Name = "txt_IP_Server2";
            this.txt_IP_Server2.Size = new System.Drawing.Size(109, 21);
            this.txt_IP_Server2.TabIndex = 6;
            this.txt_IP_Server2.Text = "192.168.0.173";
            // 
            // txt_IP_Server1
            // 
            this.txt_IP_Server1.Location = new System.Drawing.Point(89, 96);
            this.txt_IP_Server1.Name = "txt_IP_Server1";
            this.txt_IP_Server1.Size = new System.Drawing.Size(109, 21);
            this.txt_IP_Server1.TabIndex = 7;
            this.txt_IP_Server1.Text = "192.168.0.172";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Disconnect.Location = new System.Drawing.Point(122, 269);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(90, 27);
            this.btn_Disconnect.TabIndex = 4;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Connect.Location = new System.Drawing.Point(30, 269);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(90, 27);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // txt_Port1
            // 
            this.txt_Port1.Location = new System.Drawing.Point(89, 123);
            this.txt_Port1.Name = "txt_Port1";
            this.txt_Port1.Size = new System.Drawing.Size(109, 21);
            this.txt_Port1.TabIndex = 7;
            this.txt_Port1.Text = "192.168.0.172";
            // 
            // txt_Port2
            // 
            this.txt_Port2.Location = new System.Drawing.Point(89, 223);
            this.txt_Port2.Name = "txt_Port2";
            this.txt_Port2.Size = new System.Drawing.Size(109, 21);
            this.txt_Port2.TabIndex = 6;
            this.txt_Port2.Text = "192.168.0.173";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.txt_Server2_Protocol);
            this.Controls.Add(this.txt_Server1_Protocol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Port2);
            this.Controls.Add(this.txt_IP_Server2);
            this.Controls.Add(this.txt_Port1);
            this.Controls.Add(this.txt_IP_Server1);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Server2_Protocol;
        private System.Windows.Forms.TextBox txt_Server1_Protocol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IP_Server2;
        private System.Windows.Forms.TextBox txt_IP_Server1;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_Port1;
        private System.Windows.Forms.TextBox txt_Port2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

