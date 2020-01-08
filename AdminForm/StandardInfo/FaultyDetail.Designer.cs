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
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFaultyDetailCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFaultyDetailName);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Size = new System.Drawing.Size(744, 91);
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(519, 473);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.fcFault);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 67);
            this.panel2.TabIndex = 15;
            // 
            // fcFault
            // 
            this.fcFault.Location = new System.Drawing.Point(169, 23);
            this.fcFault.Name = "fcFault";
            this.fcFault.Size = new System.Drawing.Size(190, 27);
            this.fcFault.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "불량현상 대분류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(378, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 124;
            this.label4.Text = "비고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 125;
            this.label5.Text = "불량현상 상세분류 명";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(21, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(178, 16);
            this.label25.TabIndex = 126;
            this.label25.Text = "불량현상 상세분류 코드";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(479, 51);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(124, 21);
            this.txtNumber.TabIndex = 127;
            // 
            // txtFaultyDetailName
            // 
            this.txtFaultyDetailName.Location = new System.Drawing.Point(211, 52);
            this.txtFaultyDetailName.Name = "txtFaultyDetailName";
            this.txtFaultyDetailName.Size = new System.Drawing.Size(142, 21);
            this.txtFaultyDetailName.TabIndex = 128;
            // 
            // txtFaultyDetailCode
            // 
            this.txtFaultyDetailCode.Location = new System.Drawing.Point(211, 20);
            this.txtFaultyDetailCode.Name = "txtFaultyDetailCode";
            this.txtFaultyDetailCode.Size = new System.Drawing.Size(142, 21);
            this.txtFaultyDetailCode.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(378, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 124;
            this.label2.Text = "정렬순번";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(479, 20);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(124, 21);
            this.txtNote.TabIndex = 127;
            // 
            // FaultyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaultyDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FaultyDetail";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl1.ResumeLayout(false);
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
    }
}