namespace AdminForm
{
    partial class ProcessConditionSet : dgvTwoWithInput
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.fcEquip = new AdminForm.FIndCategory();
            this.fcProd = new AdminForm.FIndCategory();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDataDESC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCondCode = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLSL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbY = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUSL = new System.Windows.Forms.TextBox();
            this.txtCondName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbItemCd = new System.Windows.Forms.ComboBox();
            this.cbWorkCd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProGroup = new System.Windows.Forms.ComboBox();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(740, 157);
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(3, 291);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Size = new System.Drawing.Size(187, 28);
            // 
            // tabPage2
            // 
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(179, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // splitContainer1
            // 
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.fcEquip);
            this.panel2.Controls.Add(this.fcProd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 67);
            this.panel2.TabIndex = 16;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(929, 17);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(193, 27);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "공정조건 복사";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // fcEquip
            // 
            this.fcEquip.Category = AdminForm.CategoryMode.Process;
            this.fcEquip.Location = new System.Drawing.Point(382, 22);
            this.fcEquip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fcEquip.Name = "fcEquip";
            this.fcEquip.SendCode = null;
            this.fcEquip.SendName = null;
            this.fcEquip.Size = new System.Drawing.Size(190, 27);
            this.fcEquip.TabIndex = 9;
            // 
            // fcProd
            // 
            this.fcProd.Category = AdminForm.CategoryMode.Process;
            this.fcProd.Location = new System.Drawing.Point(88, 22);
            this.fcProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fcProd.Name = "fcProd";
            this.fcProd.SendCode = null;
            this.fcProd.SendName = null;
            this.fcProd.Size = new System.Drawing.Size(190, 27);
            this.fcProd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(317, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "설비";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "품목";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.cbProGroup);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.txtDataDESC);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtCondCode);
            this.panel5.Controls.Add(this.txtUnit);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtLSL);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.gbUsable);
            this.panel5.Controls.Add(this.txtSL);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtUSL);
            this.panel5.Controls.Add(this.txtCondName);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cbItemCd);
            this.panel5.Controls.Add(this.cbWorkCd);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 157);
            this.panel5.TabIndex = 155;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(7, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 16);
            this.label25.TabIndex = 131;
            this.label25.Text = "작업장코드";
            // 
            // txtDataDESC
            // 
            this.txtDataDESC.Location = new System.Drawing.Point(101, 123);
            this.txtDataDESC.Name = "txtDataDESC";
            this.txtDataDESC.Size = new System.Drawing.Size(103, 21);
            this.txtDataDESC.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(222, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 148;
            this.label5.Text = "단위";
            // 
            // txtCondCode
            // 
            this.txtCondCode.Location = new System.Drawing.Point(101, 66);
            this.txtCondCode.Name = "txtCondCode";
            this.txtCondCode.Size = new System.Drawing.Size(103, 21);
            this.txtCondCode.TabIndex = 133;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(316, 120);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(103, 21);
            this.txtUnit.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 127;
            this.label3.Text = "조건코드";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(222, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 146;
            this.label12.Text = "규격하한값";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "SPEC";
            // 
            // txtLSL
            // 
            this.txtLSL.Location = new System.Drawing.Point(316, 92);
            this.txtLSL.Name = "txtLSL";
            this.txtLSL.Size = new System.Drawing.Size(103, 21);
            this.txtLSL.TabIndex = 147;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(222, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 144;
            this.label11.Text = "규격기준값";
            // 
            // gbUsable
            // 
            this.gbUsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsable.Controls.Add(this.rbY);
            this.gbUsable.Controls.Add(this.rbN);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(421, 18);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Size = new System.Drawing.Size(90, 130);
            this.gbUsable.TabIndex = 124;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // rbY
            // 
            this.rbY.AutoSize = true;
            this.rbY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbY.Checked = true;
            this.rbY.Location = new System.Drawing.Point(25, 30);
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
            this.rbN.Location = new System.Drawing.Point(25, 83);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(42, 20);
            this.rbN.TabIndex = 79;
            this.rbN.TabStop = true;
            this.rbN.Text = "무";
            this.rbN.UseVisualStyleBackColor = false;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(316, 66);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(103, 21);
            this.txtSL.TabIndex = 145;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(7, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 142;
            this.label10.Text = "조건 명";
            // 
            // txtUSL
            // 
            this.txtUSL.Location = new System.Drawing.Point(316, 39);
            this.txtUSL.Name = "txtUSL";
            this.txtUSL.Size = new System.Drawing.Size(103, 21);
            this.txtUSL.TabIndex = 137;
            // 
            // txtCondName
            // 
            this.txtCondName.Location = new System.Drawing.Point(101, 93);
            this.txtCondName.Name = "txtCondName";
            this.txtCondName.Size = new System.Drawing.Size(103, 21);
            this.txtCondName.TabIndex = 143;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(222, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 135;
            this.label8.Text = "규격상한값";
            // 
            // cbItemCd
            // 
            this.cbItemCd.FormattingEnabled = true;
            this.cbItemCd.Location = new System.Drawing.Point(101, 40);
            this.cbItemCd.Name = "cbItemCd";
            this.cbItemCd.Size = new System.Drawing.Size(103, 20);
            this.cbItemCd.TabIndex = 141;
            // 
            // cbWorkCd
            // 
            this.cbWorkCd.FormattingEnabled = true;
            this.cbWorkCd.Location = new System.Drawing.Point(101, 14);
            this.cbWorkCd.Name = "cbWorkCd";
            this.cbWorkCd.Size = new System.Drawing.Size(103, 20);
            this.cbWorkCd.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 140;
            this.label4.Text = "품목코드";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtNote);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(524, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 149);
            this.panel4.TabIndex = 154;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(4, 27);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(154, 119);
            this.txtNote.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "비고";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(689, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 157);
            this.panel3.TabIndex = 153;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(3, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 141);
            this.btnSave.TabIndex = 125;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(222, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 150;
            this.label9.Text = "공정그룹";
            // 
            // cbProGroup
            // 
            this.cbProGroup.FormattingEnabled = true;
            this.cbProGroup.Items.AddRange(new object[] {
            "소성",
            "건조",
            "성형",
            "포장"});
            this.cbProGroup.Location = new System.Drawing.Point(316, 14);
            this.cbProGroup.Name = "cbProGroup";
            this.cbProGroup.Size = new System.Drawing.Size(103, 20);
            this.cbProGroup.TabIndex = 151;
            // 
            // ProcessConditionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessConditionSet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProcessConditionSet_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private FIndCategory fcEquip;
        private FIndCategory fcProd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtDataDESC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCondCode;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLSL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbY;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUSL;
        private System.Windows.Forms.TextBox txtCondName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbItemCd;
        private System.Windows.Forms.ComboBox cbWorkCd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProGroup;
    }
}
