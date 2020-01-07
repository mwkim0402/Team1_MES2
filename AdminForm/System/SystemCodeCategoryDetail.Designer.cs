namespace AdminForm
{
    partial class SystemCodeCategoryDetail : dgvTwoWithInput
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.fcCategory = new AdminForm.FIndCategory();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatNameInput = new System.Windows.Forms.TextBox();
            this.txtCatCodeInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPS = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtCatCodeInput);
            this.panel1.Controls.Add(this.txtCatNameInput);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.fcCategory);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCatName);
            this.panel3.Controls.Add(this.txtCatCode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 67);
            this.panel3.TabIndex = 4;
            // 
            // fcCategory
            // 
            this.fcCategory.Location = new System.Drawing.Point(165, 22);
            this.fcCategory.Name = "fcCategory";
            this.fcCategory.Size = new System.Drawing.Size(190, 27);
            this.fcCategory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(54, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "시스템 대분류";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(932, 25);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(152, 21);
            this.txtCatName.TabIndex = 6;
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(589, 25);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(152, 21);
            this.txtCatCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(780, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "시스템 상세분류 명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(421, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "시스템 상세분류 코드";
            // 
            // txtCatNameInput
            // 
            this.txtCatNameInput.Location = new System.Drawing.Point(477, 18);
            this.txtCatNameInput.Name = "txtCatNameInput";
            this.txtCatNameInput.Size = new System.Drawing.Size(126, 21);
            this.txtCatNameInput.TabIndex = 53;
            // 
            // txtCatCodeInput
            // 
            this.txtCatCodeInput.Location = new System.Drawing.Point(182, 18);
            this.txtCatCodeInput.Name = "txtCatCodeInput";
            this.txtCatCodeInput.Size = new System.Drawing.Size(126, 21);
            this.txtCatCodeInput.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(325, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 16);
            this.label21.TabIndex = 50;
            this.label21.Text = "시스템 상세분류 명";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(15, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(162, 16);
            this.label23.TabIndex = 49;
            this.label23.Text = "시스템 상세분류 코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(104, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "정렬순번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(431, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "비고";
            // 
            // txtPS
            // 
            this.txtPS.Location = new System.Drawing.Point(477, 51);
            this.txtPS.Name = "txtPS";
            this.txtPS.Size = new System.Drawing.Size(126, 21);
            this.txtPS.TabIndex = 57;
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(181, 51);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(127, 20);
            this.cmbSort.TabIndex = 12;
            // 
            // SystemCodeCategoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemCodeCategoryDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SystemCodeCategoryDetail";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtCatNameInput;
        private System.Windows.Forms.TextBox txtCatCodeInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSort;
        private FIndCategory fcCategory;
        private System.Windows.Forms.Label label5;
    }
}