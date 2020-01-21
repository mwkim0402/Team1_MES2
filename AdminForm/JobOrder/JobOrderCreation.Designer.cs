namespace AdminForm
{
    partial class JobOrderCreation : dgvOneWithInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeadline = new System.Windows.Forms.Button();
            this.btnDeadlineCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.fcWorkPlace = new AdminForm.FIndCategory();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPlanAmount = new AdminForm.FIndCategory();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpPlanDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlanAmount = new System.Windows.Forms.TextBox();
            this.txtJobOrderCodeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cmbWorkPlace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nuPlanAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPlanAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbWorkPlace);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.nuPlanAmount);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.dtpPlanDate);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtPlanAmount);
            this.panel1.Controls.Add(this.txtJobOrderCodeInput);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnDeadline);
            this.panel2.Controls.Add(this.btnDeadlineCancel);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.fcWorkPlace);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbPlanAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpEnd);
            this.panel2.Controls.Add(this.dtpStart);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 67);
            this.panel2.TabIndex = 4;
            // 
            // btnDeadline
            // 
            this.btnDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeadline.Location = new System.Drawing.Point(954, 20);
            this.btnDeadline.Name = "btnDeadline";
            this.btnDeadline.Size = new System.Drawing.Size(73, 33);
            this.btnDeadline.TabIndex = 11;
            this.btnDeadline.Text = "작업지시 마감";
            this.btnDeadline.UseVisualStyleBackColor = true;
            this.btnDeadline.Click += new System.EventHandler(this.BtnDeadline_Click);
            // 
            // btnDeadlineCancel
            // 
            this.btnDeadlineCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeadlineCancel.Location = new System.Drawing.Point(1033, 20);
            this.btnDeadlineCancel.Name = "btnDeadlineCancel";
            this.btnDeadlineCancel.Size = new System.Drawing.Size(73, 33);
            this.btnDeadlineCancel.TabIndex = 10;
            this.btnDeadlineCancel.Text = "작업지시 마감취소";
            this.btnDeadlineCancel.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(875, 20);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(73, 33);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "품목변경";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // fcWorkPlace
            // 
            this.fcWorkPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fcWorkPlace.Category = AdminForm.CategoryMode.WorkCenter;
            this.fcWorkPlace.Location = new System.Drawing.Point(665, 22);
            this.fcWorkPlace.Name = "fcWorkPlace";
            this.fcWorkPlace.Size = new System.Drawing.Size(190, 27);
            this.fcWorkPlace.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(603, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "작업장";
            // 
            // cbPlanAmount
            // 
            this.cbPlanAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPlanAmount.Category = AdminForm.CategoryMode.Process;
            this.cbPlanAmount.Location = new System.Drawing.Point(403, 22);
            this.cbPlanAmount.Name = "cbPlanAmount";
            this.cbPlanAmount.Size = new System.Drawing.Size(190, 27);
            this.cbPlanAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(357, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "공정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(222, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(245, 25);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(98, 21);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(118, 24);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(98, 21);
            this.dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업지시일자";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(23, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 16);
            this.label23.TabIndex = 45;
            this.label23.Text = "작업지시번호";
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(369, 46);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(98, 21);
            this.dtpPlanDate.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label22.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(506, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 16);
            this.label22.TabIndex = 46;
            this.label22.Text = "품목코드";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(23, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "계획수량단위";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(586, 15);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 21);
            this.txtItemCode.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label19.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(286, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 48;
            this.label19.Text = "계획수량";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label18.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(286, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 49;
            this.label18.Text = "계획일자";
            // 
            // txtPlanAmount
            // 
            this.txtPlanAmount.Location = new System.Drawing.Point(146, 46);
            this.txtPlanAmount.Name = "txtPlanAmount";
            this.txtPlanAmount.Size = new System.Drawing.Size(100, 21);
            this.txtPlanAmount.TabIndex = 52;
            // 
            // txtJobOrderCodeInput
            // 
            this.txtJobOrderCodeInput.Enabled = false;
            this.txtJobOrderCodeInput.Location = new System.Drawing.Point(146, 15);
            this.txtJobOrderCodeInput.Name = "txtJobOrderCodeInput";
            this.txtJobOrderCodeInput.Size = new System.Drawing.Size(100, 21);
            this.txtJobOrderCodeInput.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(520, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "품목명";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(586, 46);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 21);
            this.txtItemName.TabIndex = 57;
            // 
            // cmbWorkPlace
            // 
            this.cmbWorkPlace.FormattingEnabled = true;
            this.cmbWorkPlace.Location = new System.Drawing.Point(791, 15);
            this.cmbWorkPlace.Name = "cmbWorkPlace";
            this.cmbWorkPlace.Size = new System.Drawing.Size(131, 20);
            this.cmbWorkPlace.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(715, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "작업장";
            // 
            // nuPlanAmount
            // 
            this.nuPlanAmount.Location = new System.Drawing.Point(369, 14);
            this.nuPlanAmount.Name = "nuPlanAmount";
            this.nuPlanAmount.Size = new System.Drawing.Size(98, 21);
            this.nuPlanAmount.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1018, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // JobOrderCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobOrderCreation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "JobOrderCreation";
            this.Activated += new System.EventHandler(this.JobOrderCreation_Activated);
            this.Deactivate += new System.EventHandler(this.JobOrderCreation_Deactivate);
            this.Load += new System.EventHandler(this.JobOrderCreation_Load);
            this.Leave += new System.EventHandler(this.JobOrderCreation_Leave);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tabControl4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPlanAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FIndCategory fcWorkPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeadlineCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDeadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpPlanDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlanAmount;
        private System.Windows.Forms.TextBox txtJobOrderCodeInput;
        private System.Windows.Forms.ComboBox cmbWorkPlace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuPlanAmount;
        private FIndCategory cbPlanAmount;
        private System.Windows.Forms.Button btnSave;
    }
}