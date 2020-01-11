namespace AdminForm
{
    partial class FaultyDetail : dgvTwoWithInput
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
            this.fcFault = new AdminForm.FIndCategory();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtFaultyDetailName = new System.Windows.Forms.TextBox();
            this.txtFaultyDetailCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFaultyDetailCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFaultyDetailName);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Size = new System.Drawing.Size(850, 114);
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(5, 460);
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
            this.panel2.Controls.Add(this.fcFault);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1294, 84);
            this.panel2.TabIndex = 15;
            // 
            // fcFault
            // 
            this.fcFault.Location = new System.Drawing.Point(193, 29);
            this.fcFault.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fcFault.Name = "fcFault";
            this.fcFault.Size = new System.Drawing.Size(217, 34);
            this.fcFault.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "불량현상 대분류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(432, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "비고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(24, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 125;
            this.label5.Text = "불량현상 상세분류 명";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(24, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(223, 20);
            this.label25.TabIndex = 126;
            this.label25.Text = "불량현상 상세분류 코드";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(547, 64);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(141, 25);
            this.txtNumber.TabIndex = 127;
            // 
            // txtFaultyDetailName
            // 
            this.txtFaultyDetailName.Location = new System.Drawing.Point(241, 65);
            this.txtFaultyDetailName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFaultyDetailName.Name = "txtFaultyDetailName";
            this.txtFaultyDetailName.Size = new System.Drawing.Size(162, 25);
            this.txtFaultyDetailName.TabIndex = 128;
            // 
            // txtFaultyDetailCode
            // 
            this.txtFaultyDetailCode.Location = new System.Drawing.Point(241, 25);
            this.txtFaultyDetailCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFaultyDetailCode.Name = "txtFaultyDetailCode";
            this.txtFaultyDetailCode.Size = new System.Drawing.Size(162, 25);
            this.txtFaultyDetailCode.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(432, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 124;
            this.label2.Text = "정렬순번";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(547, 25);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(141, 25);
            this.txtNote.TabIndex = 127;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(739, 28);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 60);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FaultyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaultyDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FaultyDetail";
            this.Load += new System.EventHandler(this.FaultyDetail_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FIndCategory fcFault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFaultyDetailCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaultyDetailName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnSave;
    }
}