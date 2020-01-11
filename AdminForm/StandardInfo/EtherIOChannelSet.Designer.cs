namespace AdminForm
{
    partial class EtherIOChannelSet : dgvTwoWithInput
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
            this.txtIOIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIOCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSenser = new System.Windows.Forms.TextBox();
            this.txtchannelSet = new System.Windows.Forms.TextBox();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDataDESC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbYes);
            this.panel1.Controls.Add(this.rbNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtDataDESC);
            this.panel1.Controls.Add(this.txtFactory);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtSenser);
            this.panel1.Controls.Add(this.txtchannelSet);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Size = new System.Drawing.Size(850, 114);
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(1, 461);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // tabPage2
            // 
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtIOIP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIOCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 84);
            this.panel2.TabIndex = 16;
            // 
            // txtIOIP
            // 
            this.txtIOIP.Location = new System.Drawing.Point(490, 35);
            this.txtIOIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIOIP.Name = "txtIOIP";
            this.txtIOIP.Size = new System.Drawing.Size(181, 25);
            this.txtIOIP.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(375, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "EtherIO IP";
            // 
            // txtIOCode
            // 
            this.txtIOCode.Location = new System.Drawing.Point(158, 34);
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
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "EtherIO 코드";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(750, 24);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 75);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbY);
            this.gbUsable.Controls.Add(this.rbN);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(522, 11);
            this.gbUsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Size = new System.Drawing.Size(99, 92);
            this.gbUsable.TabIndex = 110;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbY.Location = new System.Drawing.Point(27, 28);
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
            this.rbN.Location = new System.Drawing.Point(27, 65);
            this.rbN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(50, 24);
            this.rbN.TabIndex = 79;
            this.rbN.TabStop = true;
            this.rbN.Text = "무";
            this.rbN.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 117;
            this.label5.Text = "센서위치";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(16, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 20);
            this.label25.TabIndex = 118;
            this.label25.Text = "채널설정";
            // 
            // txtSenser
            // 
            this.txtSenser.Location = new System.Drawing.Point(121, 78);
            this.txtSenser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenser.Name = "txtSenser";
            this.txtSenser.Size = new System.Drawing.Size(117, 25);
            this.txtSenser.TabIndex = 120;
            // 
            // txtchannelSet
            // 
            this.txtchannelSet.Location = new System.Drawing.Point(121, 9);
            this.txtchannelSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtchannelSet.Name = "txtchannelSet";
            this.txtchannelSet.Size = new System.Drawing.Size(117, 25);
            this.txtchannelSet.TabIndex = 121;
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(121, 42);
            this.txtFactory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(117, 25);
            this.txtFactory.TabIndex = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 117;
            this.label3.Text = "작업장";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(395, 78);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(117, 25);
            this.txtNote.TabIndex = 120;
            // 
            // txtDataDESC
            // 
            this.txtDataDESC.Location = new System.Drawing.Point(395, 42);
            this.txtDataDESC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataDESC.Name = "txtDataDESC";
            this.txtDataDESC.Size = new System.Drawing.Size(117, 25);
            this.txtDataDESC.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(256, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 118;
            this.label4.Text = "캐비티 적용유무";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(256, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "비고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(256, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 117;
            this.label7.Text = "Data DESC";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbYes.Location = new System.Drawing.Point(416, 14);
            this.rbYes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 19);
            this.rbYes.TabIndex = 122;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "유";
            this.rbYes.UseVisualStyleBackColor = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNo.Location = new System.Drawing.Point(473, 14);
            this.rbNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(43, 19);
            this.rbNo.TabIndex = 123;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "무";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // EtherIOChannelSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EtherIOChannelSet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.EtherIOChannelSet_Load);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbY;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSenser;
        private System.Windows.Forms.TextBox txtchannelSet;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataDESC;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.TextBox txtNote;
    }
}
