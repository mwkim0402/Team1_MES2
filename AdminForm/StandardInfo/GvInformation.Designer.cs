namespace AdminForm
{
    partial class GvInformation
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
            this.txtTruckCode = new System.Windows.Forms.TextBox();
            this.txtTruckName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTruckCodeInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTruckCodeInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtTruckCode);
            this.panel2.Controls.Add(this.txtTruckName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 67);
            this.panel2.TabIndex = 10;
            // 
            // txtTruckCode
            // 
            this.txtTruckCode.Location = new System.Drawing.Point(108, 26);
            this.txtTruckCode.Name = "txtTruckCode";
            this.txtTruckCode.Size = new System.Drawing.Size(141, 21);
            this.txtTruckCode.TabIndex = 18;
            // 
            // txtTruckName
            // 
            this.txtTruckName.Location = new System.Drawing.Point(349, 27);
            this.txtTruckName.Name = "txtTruckName";
            this.txtTruckName.Size = new System.Drawing.Size(141, 21);
            this.txtTruckName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(274, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "대차명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "대차 코드";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1031, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 101;
            this.label2.Text = "대차코드 :";
            // 
            // txtTruckCodeInput
            // 
            this.txtTruckCodeInput.Location = new System.Drawing.Point(99, 15);
            this.txtTruckCodeInput.Name = "txtTruckCodeInput";
            this.txtTruckCodeInput.Size = new System.Drawing.Size(100, 21);
            this.txtTruckCodeInput.TabIndex = 102;
            // 
            // GvInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GvInformation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GvInformation";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
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
        private System.Windows.Forms.TextBox txtTruckCode;
        private System.Windows.Forms.TextBox txtTruckName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTruckCodeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}