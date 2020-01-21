namespace AdminForm
{
    partial class EtherIOInfo
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
            this.txtIOIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIOCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtIOIPInput = new System.Windows.Forms.TextBox();
            this.txtIOName = new System.Windows.Forms.TextBox();
            this.txtIOCodeInput = new System.Windows.Forms.TextBox();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage4.Size = new System.Drawing.Size(99, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtIOIPInput);
            this.panel1.Controls.Add(this.txtIOName);
            this.panel1.Controls.Add(this.txtIOCodeInput);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.gbUsable);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(99, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.cmbUsable);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIOIP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIOCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 84);
            this.panel2.TabIndex = 17;
            // 
            // cmbUsable
            // 
            this.cmbUsable.FormattingEnabled = true;
            this.cmbUsable.Location = new System.Drawing.Point(856, 35);
            this.cmbUsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsable.Name = "cmbUsable";
            this.cmbUsable.Size = new System.Drawing.Size(138, 23);
            this.cmbUsable.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(729, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "사용유무";
            // 
            // txtIOIP
            // 
            this.txtIOIP.Location = new System.Drawing.Point(496, 34);
            this.txtIOIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIOIP.Name = "txtIOIP";
            this.txtIOIP.Size = new System.Drawing.Size(181, 25);
            this.txtIOIP.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(376, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "EtherIO IP";
            // 
            // txtIOCode
            // 
            this.txtIOCode.Location = new System.Drawing.Point(162, 34);
            this.txtIOCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIOCode.Name = "txtIOCode";
            this.txtIOCode.Size = new System.Drawing.Size(181, 25);
            this.txtIOCode.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "EtherIO 코드 ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1178, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 60);
            this.btnSave.TabIndex = 109;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbY);
            this.gbUsable.Controls.Add(this.rbN);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(887, 15);
            this.gbUsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Size = new System.Drawing.Size(229, 80);
            this.gbUsable.TabIndex = 108;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbY.Location = new System.Drawing.Point(49, 35);
            this.rbY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbY.Name = "rbY";
            this.rbY.Size = new System.Drawing.Size(50, 24);
            this.rbY.TabIndex = 77;
            this.rbY.TabStop = true;
            this.rbY.Text = "유";
            this.rbY.UseVisualStyleBackColor = false;
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbN.Location = new System.Drawing.Point(127, 35);
            this.rbN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(50, 24);
            this.rbN.TabIndex = 79;
            this.rbN.TabStop = true;
            this.rbN.Text = "무";
            this.rbN.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(344, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "EtherIO IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(39, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 111;
            this.label5.Text = "EtherIO 명";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(39, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(118, 20);
            this.label25.TabIndex = 112;
            this.label25.Text = "EtherIO 코드";
            // 
            // txtIOIPInput
            // 
            this.txtIOIPInput.Location = new System.Drawing.Point(450, 20);
            this.txtIOIPInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIOIPInput.Name = "txtIOIPInput";
            this.txtIOIPInput.Size = new System.Drawing.Size(117, 25);
            this.txtIOIPInput.TabIndex = 113;
            // 
            // txtIOName
            // 
            this.txtIOName.Location = new System.Drawing.Point(171, 60);
            this.txtIOName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIOName.Name = "txtIOName";
            this.txtIOName.Size = new System.Drawing.Size(117, 25);
            this.txtIOName.TabIndex = 114;
            // 
            // txtIOCodeInput
            // 
            this.txtIOCodeInput.Location = new System.Drawing.Point(171, 20);
            this.txtIOCodeInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIOCodeInput.Name = "txtIOCodeInput";
            this.txtIOCodeInput.Size = new System.Drawing.Size(117, 25);
            this.txtIOCodeInput.TabIndex = 115;
            // 
            // EtherIOInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EtherIOInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.EtherIOInfo_Load);
            this.Controls.SetChildIndex(this.tabControl4, 0);
            //this.Controls.SetChildIndex(this.panel1, 0);
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
        private System.Windows.Forms.TextBox txtIOIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIOCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbY;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtIOIPInput;
        private System.Windows.Forms.TextBox txtIOName;
        private System.Windows.Forms.TextBox txtIOCodeInput;
    }
}
