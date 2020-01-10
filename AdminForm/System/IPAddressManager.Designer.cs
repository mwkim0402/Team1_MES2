namespace AdminForm
{
    partial class IPAddressManager : dgvOneWithInput
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
            this.btnSave = new System.Windows.Forms.Button();
            this.rbNoUse_Use = new System.Windows.Forms.RadioButton();
            this.rbUse_Use = new System.Windows.Forms.RadioButton();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbAllow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.gbMonitor = new System.Windows.Forms.GroupBox();
            this.rbUse_Mon = new System.Windows.Forms.RadioButton();
            this.rbNoUse_Mon = new System.Windows.Forms.RadioButton();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.gbMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbMonitor);
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtAddr);
            this.panel1.Controls.Add(this.btnSave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1036, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rbNoUse_Use
            // 
            this.rbNoUse_Use.AutoSize = true;
            this.rbNoUse_Use.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNoUse_Use.Location = new System.Drawing.Point(111, 28);
            this.rbNoUse_Use.Name = "rbNoUse_Use";
            this.rbNoUse_Use.Size = new System.Drawing.Size(42, 20);
            this.rbNoUse_Use.TabIndex = 79;
            this.rbNoUse_Use.TabStop = true;
            this.rbNoUse_Use.Text = "무";
            this.rbNoUse_Use.UseVisualStyleBackColor = false;
            // 
            // rbUse_Use
            // 
            this.rbUse_Use.AutoSize = true;
            this.rbUse_Use.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbUse_Use.Location = new System.Drawing.Point(43, 28);
            this.rbUse_Use.Name = "rbUse_Use";
            this.rbUse_Use.Size = new System.Drawing.Size(42, 20);
            this.rbUse_Use.TabIndex = 77;
            this.rbUse_Use.TabStop = true;
            this.rbUse_Use.Text = "유";
            this.rbUse_Use.UseVisualStyleBackColor = false;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(119, 16);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(152, 21);
            this.txtAddr.TabIndex = 74;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(20, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 16);
            this.label23.TabIndex = 70;
            this.label23.Text = "IP Address";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.cmbAllow);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 67);
            this.panel2.TabIndex = 10;
            // 
            // cmbAllow
            // 
            this.cmbAllow.FormattingEnabled = true;
            this.cmbAllow.Location = new System.Drawing.Point(96, 25);
            this.cmbAllow.Name = "cmbAllow";
            this.cmbAllow.Size = new System.Drawing.Size(121, 20);
            this.cmbAllow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "허용여부";
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbUse_Use);
            this.gbUsable.Controls.Add(this.rbNoUse_Use);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(366, 12);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Size = new System.Drawing.Size(200, 64);
            this.gbUsable.TabIndex = 85;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // gbMonitor
            // 
            this.gbMonitor.Controls.Add(this.rbUse_Mon);
            this.gbMonitor.Controls.Add(this.rbNoUse_Mon);
            this.gbMonitor.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbMonitor.Location = new System.Drawing.Point(608, 12);
            this.gbMonitor.Name = "gbMonitor";
            this.gbMonitor.Size = new System.Drawing.Size(200, 64);
            this.gbMonitor.TabIndex = 86;
            this.gbMonitor.TabStop = false;
            this.gbMonitor.Text = "모니터링 화면여부";
            // 
            // rbUse_Mon
            // 
            this.rbUse_Mon.AutoSize = true;
            this.rbUse_Mon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbUse_Mon.Location = new System.Drawing.Point(43, 28);
            this.rbUse_Mon.Name = "rbUse_Mon";
            this.rbUse_Mon.Size = new System.Drawing.Size(42, 20);
            this.rbUse_Mon.TabIndex = 77;
            this.rbUse_Mon.TabStop = true;
            this.rbUse_Mon.Text = "유";
            this.rbUse_Mon.UseVisualStyleBackColor = false;
            // 
            // rbNoUse_Mon
            // 
            this.rbNoUse_Mon.AutoSize = true;
            this.rbNoUse_Mon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNoUse_Mon.Location = new System.Drawing.Point(111, 28);
            this.rbNoUse_Mon.Name = "rbNoUse_Mon";
            this.rbNoUse_Mon.Size = new System.Drawing.Size(42, 20);
            this.rbNoUse_Mon.TabIndex = 79;
            this.rbNoUse_Mon.TabStop = true;
            this.rbNoUse_Mon.Text = "무";
            this.rbNoUse_Mon.UseVisualStyleBackColor = false;
            // 
            // IPAddressManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPAddressManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "IPAddressManager";
            this.Load += new System.EventHandler(this.IPAddressManager_Load);
            this.Controls.SetChildIndex(this.tabControl4, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.gbMonitor.ResumeLayout(false);
            this.gbMonitor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbNoUse_Use;
        private System.Windows.Forms.RadioButton rbUse_Use;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAllow;
        private System.Windows.Forms.GroupBox gbMonitor;
        private System.Windows.Forms.RadioButton rbUse_Mon;
        private System.Windows.Forms.RadioButton rbNoUse_Mon;
        private System.Windows.Forms.GroupBox gbUsable;
    }
}