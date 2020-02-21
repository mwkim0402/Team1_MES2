namespace AdminForm
{
    partial class NonOperationDetail : dgvTwoWithInput
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fcNonOpCat = new AdminForm.FIndCategory();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNonOperationDetailName = new System.Windows.Forms.TextBox();
            this.txtNonOperationDetailCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNonOpMa = new System.Windows.Forms.ComboBox();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl4
            // 
            this.tabControl4.Size = new System.Drawing.Size(297, 28);
            // 
            // tabPage4
            // 
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(289, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.fcNonOpCat);
            this.panel1.Controls.Add(this.cmbNonOpMa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtNonOperationDetailName);
            this.panel1.Controls.Add(this.txtNonOperationDetailCode);
            this.panel1.Location = new System.Drawing.Point(2, 331);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(837, 146);
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(2, 299);
            // 
            // tabPage2
            // 
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 67);
            this.panel2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(379, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.textBox1.Location = new System.Drawing.Point(147, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "비가동 대분류";
            // 
            // fcNonOpCat
            // 
            this.fcNonOpCat.Category = AdminForm.CategoryMode.NonOper;
            this.fcNonOpCat.Location = new System.Drawing.Point(-6, -776);
            this.fcNonOpCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fcNonOpCat.Name = "fcNonOpCat";
            this.fcNonOpCat.SendCode = null;
            this.fcNonOpCat.SendName = null;
            this.fcNonOpCat.Size = new System.Drawing.Size(190, 27);
            this.fcNonOpCat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label5.Location = new System.Drawing.Point(22, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 130;
            this.label5.Text = "비가동 상세분류 명";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label25.Location = new System.Drawing.Point(22, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(152, 19);
            this.label25.TabIndex = 131;
            this.label25.Text = "비가동 상세분류 코드";
            // 
            // txtNonOperationDetailName
            // 
            this.txtNonOperationDetailName.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtNonOperationDetailName.Location = new System.Drawing.Point(200, 104);
            this.txtNonOperationDetailName.Name = "txtNonOperationDetailName";
            this.txtNonOperationDetailName.Size = new System.Drawing.Size(227, 26);
            this.txtNonOperationDetailName.TabIndex = 132;
            // 
            // txtNonOperationDetailCode
            // 
            this.txtNonOperationDetailCode.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtNonOperationDetailCode.Location = new System.Drawing.Point(200, 63);
            this.txtNonOperationDetailCode.Name = "txtNonOperationDetailCode";
            this.txtNonOperationDetailCode.ReadOnly = true;
            this.txtNonOperationDetailCode.Size = new System.Drawing.Size(227, 26);
            this.txtNonOperationDetailCode.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 135;
            this.label4.Text = "비고";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtNote.Location = new System.Drawing.Point(3, 33);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(294, 104);
            this.txtNote.TabIndex = 136;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(758, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 146);
            this.panel3.TabIndex = 138;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtNote);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(452, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 140);
            this.panel4.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 140;
            this.label2.Text = "비가동 대분류 그룹";
            // 
            // cmbNonOpMa
            // 
            this.cmbNonOpMa.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.cmbNonOpMa.FormattingEnabled = true;
            this.cmbNonOpMa.Location = new System.Drawing.Point(200, 26);
            this.cmbNonOpMa.Name = "cmbNonOpMa";
            this.cmbNonOpMa.Size = new System.Drawing.Size(227, 27);
            this.cmbNonOpMa.TabIndex = 141;
            this.cmbNonOpMa.SelectedIndexChanged += new System.EventHandler(this.cmbNonOpMa_SelectedIndexChanged);
            // 
            // NonOperationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NonOperationDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NonOperationDetail";
            this.Activated += new System.EventHandler(this.NonOperationDetail_Activated);
            this.Deactivate += new System.EventHandler(this.NonOperationDetail_Deactivate);
            this.Load += new System.EventHandler(this.NonOperationDetail_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FIndCategory fcNonOpCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNonOperationDetailName;
        private System.Windows.Forms.TextBox txtNonOperationDetailCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbNonOpMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}