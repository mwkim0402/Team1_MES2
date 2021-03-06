﻿namespace AdminForm
{
    partial class UserAssortDetail : dgvTwoWithInput
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
            this.fcUserAssortCat = new AdminForm.FIndCategory();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNonOperationDetailName = new System.Windows.Forms.TextBox();
            this.txtNonOperationDetailCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtNonOperationDetailName);
            this.panel1.Controls.Add(this.txtNonOperationDetailCode);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(742, 84);
            // 
            // tabControl2
            // 
            this.tabControl2.Size = new System.Drawing.Size(213, 28);
            // 
            // tabPage2
            // 
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(205, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.fcUserAssortCat);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 59);
            this.panel2.TabIndex = 12;
            // 
            // fcUserAssortCat
            // 
           // this.fcUserAssortCat.CategoryTable = null;
            this.fcUserAssortCat.Location = new System.Drawing.Point(197, 22);
            this.fcUserAssortCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fcUserAssortCat.Name = "fcUserAssortCat";
            this.fcUserAssortCat.Size = new System.Drawing.Size(190, 27);
            this.fcUserAssortCat.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "사용자 정의 대분류 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(410, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 142;
            this.label2.Text = "정렬순번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(410, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 143;
            this.label4.Text = "비고";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(500, 15);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(103, 21);
            this.txtNote.TabIndex = 144;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(500, 46);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(103, 21);
            this.txtNumber.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 16);
            this.label5.TabIndex = 138;
            this.label5.Text = "사용자정의코드 상세분류 명";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label25.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(20, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(226, 16);
            this.label25.TabIndex = 139;
            this.label25.Text = "사용자정의코드 상세분류 코드";
            // 
            // txtNonOperationDetailName
            // 
            this.txtNonOperationDetailName.Location = new System.Drawing.Point(258, 48);
            this.txtNonOperationDetailName.Name = "txtNonOperationDetailName";
            this.txtNonOperationDetailName.Size = new System.Drawing.Size(138, 21);
            this.txtNonOperationDetailName.TabIndex = 140;
            // 
            // txtNonOperationDetailCode
            // 
            this.txtNonOperationDetailCode.Location = new System.Drawing.Point(258, 16);
            this.txtNonOperationDetailCode.Name = "txtNonOperationDetailCode";
            this.txtNonOperationDetailCode.Size = new System.Drawing.Size(138, 21);
            this.txtNonOperationDetailCode.TabIndex = 141;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(646, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 146;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // UserAssortDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAssortDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UserDetailAssort";
            this.Load += new System.EventHandler(this.UserAssortDetail_Load);
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
        private FIndCategory fcUserAssortCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNonOperationDetailName;
        private System.Windows.Forms.TextBox txtNonOperationDetailCode;
        private System.Windows.Forms.Button btnSave;
    }
}