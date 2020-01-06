namespace AdminForm
{
    partial class MoldingJobOrderCreation : dgvTwo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProjectNum = new System.Windows.Forms.TextBox();
            this.txtOrderCreationNum = new System.Windows.Forms.TextBox();
            this.btnOrderCreationDeadline = new System.Windows.Forms.Button();
            this.btnOrderCreationDown = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtProjectNum);
            this.panel1.Controls.Add(this.txtOrderCreationNum);
            this.panel1.Controls.Add(this.btnOrderCreationDeadline);
            this.panel1.Controls.Add(this.btnOrderCreationDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 67);
            this.panel1.TabIndex = 4;
            // 
            // txtProjectNum
            // 
            this.txtProjectNum.Location = new System.Drawing.Point(718, 25);
            this.txtProjectNum.Name = "txtProjectNum";
            this.txtProjectNum.Size = new System.Drawing.Size(100, 21);
            this.txtProjectNum.TabIndex = 12;
            // 
            // txtOrderCreationNum
            // 
            this.txtOrderCreationNum.Location = new System.Drawing.Point(472, 25);
            this.txtOrderCreationNum.Name = "txtOrderCreationNum";
            this.txtOrderCreationNum.Size = new System.Drawing.Size(100, 21);
            this.txtOrderCreationNum.TabIndex = 11;
            // 
            // btnOrderCreationDeadline
            // 
            this.btnOrderCreationDeadline.Location = new System.Drawing.Point(989, 20);
            this.btnOrderCreationDeadline.Name = "btnOrderCreationDeadline";
            this.btnOrderCreationDeadline.Size = new System.Drawing.Size(122, 33);
            this.btnOrderCreationDeadline.TabIndex = 10;
            this.btnOrderCreationDeadline.Text = "생산의뢰 마감";
            this.btnOrderCreationDeadline.UseVisualStyleBackColor = true;
            // 
            // btnOrderCreationDown
            // 
            this.btnOrderCreationDown.Location = new System.Drawing.Point(861, 20);
            this.btnOrderCreationDown.Name = "btnOrderCreationDown";
            this.btnOrderCreationDown.Size = new System.Drawing.Size(122, 33);
            this.btnOrderCreationDown.TabIndex = 8;
            this.btnOrderCreationDown.Text = "생산의뢰 다운로드";
            this.btnOrderCreationDown.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(603, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "프로젝트 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(357, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "생산의뢰 번호";
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
            this.label1.Text = "생산의뢰날짜";
            // 
            // MoldingJobOrderCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoldingJobOrderCreation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MoldingJobOrderCreation";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrderCreationDeadline;
        private System.Windows.Forms.Button btnOrderCreationDown;
        private System.Windows.Forms.TextBox txtProjectNum;
        private System.Windows.Forms.TextBox txtOrderCreationNum;
    }
}