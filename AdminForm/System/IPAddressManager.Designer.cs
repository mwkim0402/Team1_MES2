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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage4.Size = new System.Drawing.Size(99, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbMonitor);
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtAddr);
            this.panel1.Controls.Add(this.btnSave);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(99, 0);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1184, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 60);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rbNoUse_Use
            // 
            this.rbNoUse_Use.AutoSize = true;
            this.rbNoUse_Use.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNoUse_Use.Location = new System.Drawing.Point(127, 35);
            this.rbNoUse_Use.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNoUse_Use.Name = "rbNoUse_Use";
            this.rbNoUse_Use.Size = new System.Drawing.Size(50, 24);
            this.rbNoUse_Use.TabIndex = 79;
            this.rbNoUse_Use.TabStop = true;
            this.rbNoUse_Use.Text = "무";
            this.rbNoUse_Use.UseVisualStyleBackColor = false;
            // 
            // rbUse_Use
            // 
            this.rbUse_Use.AutoSize = true;
            this.rbUse_Use.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbUse_Use.Location = new System.Drawing.Point(49, 35);
            this.rbUse_Use.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUse_Use.Name = "rbUse_Use";
            this.rbUse_Use.Size = new System.Drawing.Size(50, 24);
            this.rbUse_Use.TabIndex = 77;
            this.rbUse_Use.TabStop = true;
            this.rbUse_Use.Text = "유";
            this.rbUse_Use.UseVisualStyleBackColor = false;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(136, 20);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(173, 25);
            this.txtAddr.TabIndex = 74;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(23, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 20);
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
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 84);
            this.panel2.TabIndex = 10;
            // 
            // cmbAllow
            // 
            this.cmbAllow.FormattingEnabled = true;
            this.cmbAllow.Location = new System.Drawing.Point(110, 31);
            this.cmbAllow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAllow.Name = "cmbAllow";
            this.cmbAllow.Size = new System.Drawing.Size(138, 23);
            this.cmbAllow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "허용여부";
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbUse_Use);
            this.gbUsable.Controls.Add(this.rbNoUse_Use);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(418, 15);
            this.gbUsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Size = new System.Drawing.Size(229, 80);
            this.gbUsable.TabIndex = 85;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // gbMonitor
            // 
            this.gbMonitor.Controls.Add(this.rbUse_Mon);
            this.gbMonitor.Controls.Add(this.rbNoUse_Mon);
            this.gbMonitor.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbMonitor.Location = new System.Drawing.Point(695, 15);
            this.gbMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMonitor.Name = "gbMonitor";
            this.gbMonitor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMonitor.Size = new System.Drawing.Size(229, 80);
            this.gbMonitor.TabIndex = 86;
            this.gbMonitor.TabStop = false;
            this.gbMonitor.Text = "모니터링 화면여부";
            // 
            // rbUse_Mon
            // 
            this.rbUse_Mon.AutoSize = true;
            this.rbUse_Mon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbUse_Mon.Location = new System.Drawing.Point(49, 35);
            this.rbUse_Mon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUse_Mon.Name = "rbUse_Mon";
            this.rbUse_Mon.Size = new System.Drawing.Size(50, 24);
            this.rbUse_Mon.TabIndex = 77;
            this.rbUse_Mon.TabStop = true;
            this.rbUse_Mon.Text = "유";
            this.rbUse_Mon.UseVisualStyleBackColor = false;
            // 
            // rbNoUse_Mon
            // 
            this.rbNoUse_Mon.AutoSize = true;
            this.rbNoUse_Mon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNoUse_Mon.Location = new System.Drawing.Point(127, 35);
            this.rbNoUse_Mon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNoUse_Mon.Name = "rbNoUse_Mon";
            this.rbNoUse_Mon.Size = new System.Drawing.Size(50, 24);
            this.rbNoUse_Mon.TabIndex = 79;
            this.rbNoUse_Mon.TabStop = true;
            this.rbNoUse_Mon.Text = "무";
            this.rbNoUse_Mon.UseVisualStyleBackColor = false;
            // 
            // IPAddressManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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