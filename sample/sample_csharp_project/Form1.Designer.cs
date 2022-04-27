namespace sampleUI
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.txtMsgCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIsConnected = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerSec = new System.Windows.Forms.TextBox();
            this.btnIsInitialize = new System.Windows.Forms.Button();
            this.btnHotSend = new System.Windows.Forms.Button();
            this.txtHotSendMessageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSentCount = new System.Windows.Forms.TextBox();
            this.txtReceivedCount = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(7, 144);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(829, 496);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // txtMsgCount
            // 
            this.txtMsgCount.Location = new System.Drawing.Point(224, 58);
            this.txtMsgCount.Name = "txtMsgCount";
            this.txtMsgCount.Size = new System.Drawing.Size(94, 21);
            this.txtMsgCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "전송할개수:";
            // 
            // btnIsConnected
            // 
            this.btnIsConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsConnected.Location = new System.Drawing.Point(7, 12);
            this.btnIsConnected.Name = "btnIsConnected";
            this.btnIsConnected.Size = new System.Drawing.Size(528, 30);
            this.btnIsConnected.TabIndex = 6;
            this.btnIsConnected.Text = "Ready";
            this.btnIsConnected.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(324, 45);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 34);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sent Count   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "초당개수:";
            // 
            // txtPerSec
            // 
            this.txtPerSec.Location = new System.Drawing.Point(75, 58);
            this.txtPerSec.Name = "txtPerSec";
            this.txtPerSec.Size = new System.Drawing.Size(62, 21);
            this.txtPerSec.TabIndex = 12;
            // 
            // btnIsInitialize
            // 
            this.btnIsInitialize.Location = new System.Drawing.Point(541, 12);
            this.btnIsInitialize.Name = "btnIsInitialize";
            this.btnIsInitialize.Size = new System.Drawing.Size(295, 30);
            this.btnIsInitialize.TabIndex = 13;
            this.btnIsInitialize.Text = "Initialize";
            this.btnIsInitialize.UseVisualStyleBackColor = true;
            this.btnIsInitialize.Click += new System.EventHandler(this.btnIsInitialize_Click);
            // 
            // btnHotSend
            // 
            this.btnHotSend.Location = new System.Drawing.Point(757, 56);
            this.btnHotSend.Name = "btnHotSend";
            this.btnHotSend.Size = new System.Drawing.Size(79, 34);
            this.btnHotSend.TabIndex = 14;
            this.btnHotSend.Text = "HotSend";
            this.btnHotSend.UseVisualStyleBackColor = true;
            this.btnHotSend.Click += new System.EventHandler(this.btnHotSend_Click);
            // 
            // txtHotSendMessageName
            // 
            this.txtHotSendMessageName.Location = new System.Drawing.Point(655, 67);
            this.txtHotSendMessageName.Name = "txtHotSendMessageName";
            this.txtHotSendMessageName.Size = new System.Drawing.Size(96, 21);
            this.txtHotSendMessageName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Received Count";
            // 
            // txtSentCount
            // 
            this.txtSentCount.Enabled = false;
            this.txtSentCount.Location = new System.Drawing.Point(101, 94);
            this.txtSentCount.Name = "txtSentCount";
            this.txtSentCount.Size = new System.Drawing.Size(88, 21);
            this.txtSentCount.TabIndex = 16;
            // 
            // txtReceivedCount
            // 
            this.txtReceivedCount.Enabled = false;
            this.txtReceivedCount.Location = new System.Drawing.Point(295, 94);
            this.txtReceivedCount.Name = "txtReceivedCount";
            this.txtReceivedCount.Size = new System.Drawing.Size(88, 21);
            this.txtReceivedCount.TabIndex = 17;
            // 
            // txtStream
            // 
            this.txtStream.Location = new System.Drawing.Point(541, 67);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(51, 21);
            this.txtStream.TabIndex = 18;
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(598, 67);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(51, 21);
            this.txtFunction.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Stream";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "Function";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "MessageName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 652);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtReceivedCount);
            this.Controls.Add(this.txtSentCount);
            this.Controls.Add(this.txtHotSendMessageName);
            this.Controls.Add(this.btnHotSend);
            this.Controls.Add(this.btnIsInitialize);
            this.Controls.Add(this.txtPerSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnIsConnected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsgCount);
            this.Controls.Add(this.rtbLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox txtMsgCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIsConnected;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerSec;
        private System.Windows.Forms.Button btnIsInitialize;
        private System.Windows.Forms.Button btnHotSend;
        private System.Windows.Forms.TextBox txtHotSendMessageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSentCount;
        private System.Windows.Forms.TextBox txtReceivedCount;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}

