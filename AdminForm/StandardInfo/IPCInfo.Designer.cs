namespace AdminForm
{
    partial class IPCInfo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbUsable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtIPCcode = new System.Windows.Forms.TextBox();
            this.txtIPCInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSPEC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtProcess);
            this.panel1.Controls.Add(this.txtSPEC);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.txtIPCInput);
            this.panel1.Controls.Add(this.txtIPCcode);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.cmbUsable);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIPC);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 67);
            this.panel2.TabIndex = 18;
            // 
            // cmbUsable
            // 
            this.cmbUsable.FormattingEnabled = true;
            this.cmbUsable.Location = new System.Drawing.Point(378, 28);
            this.cmbUsable.Name = "cmbUsable";
            this.cmbUsable.Size = new System.Drawing.Size(121, 20);
            this.cmbUsable.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(267, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "사용유무";
            // 
            // txtIPC
            // 
            this.txtIPC.Location = new System.Drawing.Point(78, 26);
            this.txtIPC.Name = "txtIPC";
            this.txtIPC.Size = new System.Drawing.Size(159, 21);
            this.txtIPC.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "IPC";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(16, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 16);
            this.label25.TabIndex = 103;
            this.label25.Text = "IPC 코드";
            // 
            // txtIPCcode
            // 
            this.txtIPCcode.Location = new System.Drawing.Point(124, 17);
            this.txtIPCcode.Name = "txtIPCcode";
            this.txtIPCcode.Size = new System.Drawing.Size(103, 21);
            this.txtIPCcode.TabIndex = 104;
            // 
            // txtIPCInput
            // 
            this.txtIPCInput.Location = new System.Drawing.Point(124, 49);
            this.txtIPCInput.Name = "txtIPCInput";
            this.txtIPCInput.Size = new System.Drawing.Size(103, 21);
            this.txtIPCInput.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "IPC 코드명";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(338, 17);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(103, 21);
            this.txtIP.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(258, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "IP";
            // 
            // txtSPEC
            // 
            this.txtSPEC.Location = new System.Drawing.Point(338, 49);
            this.txtSPEC.Name = "txtSPEC";
            this.txtSPEC.Size = new System.Drawing.Size(103, 21);
            this.txtSPEC.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(258, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "SPEC";
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(565, 17);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(103, 21);
            this.txtProcess.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(485, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 103;
            this.label6.Text = "공정";
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbY);
            this.gbUsable.Controls.Add(this.rbN);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(781, 11);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Size = new System.Drawing.Size(200, 64);
            this.gbUsable.TabIndex = 106;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbY.Location = new System.Drawing.Point(43, 28);
            this.rbY.Name = "rbY";
            this.rbY.Size = new System.Drawing.Size(42, 20);
            this.rbY.TabIndex = 77;
            this.rbY.TabStop = true;
            this.rbY.Text = "유";
            this.rbY.UseVisualStyleBackColor = false;
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbN.Location = new System.Drawing.Point(111, 28);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(42, 20);
            this.rbN.TabIndex = 79;
            this.rbN.TabStop = true;
            this.rbN.Text = "무";
            this.rbN.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1036, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // IPCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPCInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IPCInfo_Load);
            this.Controls.SetChildIndex(this.tabControl4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbUsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.TextBox txtSPEC;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtIPCInput;
        private System.Windows.Forms.TextBox txtIPCcode;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbY;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.Button btnSave;
    }
}
