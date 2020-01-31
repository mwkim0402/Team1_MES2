namespace AdminForm
{
    partial class WorkCenterSchedule
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvCenter = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(255, 390);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker7.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "-";
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker10.Location = new System.Drawing.Point(80, 390);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker10.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 396);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 28;
            this.label20.Text = "계획일자";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 28);
            this.panel2.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(26, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 21);
            this.label14.TabIndex = 10;
            this.label14.Text = "작업장작업 일지";
            // 
            // label15
            // 
            this.label15.Image = global::AdminForm.Properties.Resources.Reading_16x16;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(3, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 27);
            this.label15.TabIndex = 9;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCenter
            // 
            this.dgvCenter.BackgroundColor = System.Drawing.Color.White;
            this.dgvCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenter.Location = new System.Drawing.Point(306, 41);
            this.dgvCenter.Name = "dgvCenter";
            this.dgvCenter.RowTemplate.Height = 23;
            this.dgvCenter.Size = new System.Drawing.Size(401, 326);
            this.dgvCenter.TabIndex = 32;
            // 
            // WorkCenterSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCenter);
            this.Controls.Add(this.dateTimePicker7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Name = "WorkCenterSchedule";
            this.Text = "WorkCenterSchedule";
            this.Load += new System.EventHandler(this.WorkCenterSchedule_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvCenter;
    }
}