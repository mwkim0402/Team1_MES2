namespace AdminForm
{
    partial class MonitorManager : dgvOneWithInput
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
            this.txtContentDll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLocate = new System.Windows.Forms.TextBox();
            this.txtMoniNameInput = new System.Windows.Forms.TextBox();
            this.txtMoniCodeInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMoniName = new System.Windows.Forms.TextBox();
            this.txtMoniCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMonitor = new System.Windows.Forms.GroupBox();
            this.rbUse_Mon = new System.Windows.Forms.RadioButton();
            this.rbNoUse_Mon = new System.Windows.Forms.RadioButton();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbUse_Use = new System.Windows.Forms.RadioButton();
            this.rbNoUse_Use = new System.Windows.Forms.RadioButton();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbMonitor.SuspendLayout();
            this.gbUsable.SuspendLayout();
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
            this.panel1.Controls.Add(this.txtContentDll);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtMoniCodeInput);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtMoniNameInput);
            this.panel1.Controls.Add(this.txtLocate);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(99, 0);
            // 
            // txtContentDll
            // 
            this.txtContentDll.Location = new System.Drawing.Point(478, 60);
            this.txtContentDll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContentDll.Name = "txtContentDll";
            this.txtContentDll.Size = new System.Drawing.Size(173, 25);
            this.txtContentDll.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(365, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "ContentDLL";
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
            // txtLocate
            // 
            this.txtLocate.Location = new System.Drawing.Point(478, 20);
            this.txtLocate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocate.Name = "txtLocate";
            this.txtLocate.Size = new System.Drawing.Size(173, 25);
            this.txtLocate.TabIndex = 76;
            // 
            // txtMoniNameInput
            // 
            this.txtMoniNameInput.Location = new System.Drawing.Point(136, 59);
            this.txtMoniNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoniNameInput.Name = "txtMoniNameInput";
            this.txtMoniNameInput.Size = new System.Drawing.Size(173, 25);
            this.txtMoniNameInput.TabIndex = 75;
            // 
            // txtMoniCodeInput
            // 
            this.txtMoniCodeInput.Location = new System.Drawing.Point(136, 20);
            this.txtMoniCodeInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoniCodeInput.Name = "txtMoniCodeInput";
            this.txtMoniCodeInput.Size = new System.Drawing.Size(173, 25);
            this.txtMoniCodeInput.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label19.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(23, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 20);
            this.label19.TabIndex = 72;
            this.label19.Text = "화면 명";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(365, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 71;
            this.label21.Text = "화면 경로";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(23, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 20);
            this.label23.TabIndex = 70;
            this.label23.Text = "화면 코드";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtMoniName);
            this.panel2.Controls.Add(this.txtMoniCode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(14, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 84);
            this.panel2.TabIndex = 10;
            // 
            // txtMoniName
            // 
            this.txtMoniName.Location = new System.Drawing.Point(417, 31);
            this.txtMoniName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoniName.Name = "txtMoniName";
            this.txtMoniName.Size = new System.Drawing.Size(147, 25);
            this.txtMoniName.TabIndex = 11;
            // 
            // txtMoniCode
            // 
            this.txtMoniCode.Location = new System.Drawing.Point(118, 31);
            this.txtMoniCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoniCode.Name = "txtMoniCode";
            this.txtMoniCode.Size = new System.Drawing.Size(147, 25);
            this.txtMoniCode.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(327, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "화면 명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "화면 코드";
            // 
            // gbMonitor
            // 
            this.gbMonitor.Controls.Add(this.rbUse_Mon);
            this.gbMonitor.Controls.Add(this.rbNoUse_Mon);
            this.gbMonitor.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbMonitor.Location = new System.Drawing.Point(945, 14);
            this.gbMonitor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMonitor.Name = "gbMonitor";
            this.gbMonitor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMonitor.Size = new System.Drawing.Size(229, 80);
            this.gbMonitor.TabIndex = 88;
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
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbUse_Use);
            this.gbUsable.Controls.Add(this.rbNoUse_Use);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(669, 14);
            this.gbUsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Size = new System.Drawing.Size(229, 80);
            this.gbUsable.TabIndex = 87;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
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
            // MonitorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MonitorManager";
            this.Load += new System.EventHandler(this.MonitorManager_Load);
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
            this.gbMonitor.ResumeLayout(false);
            this.gbMonitor.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtContentDll;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMoniCodeInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMoniNameInput;
        private System.Windows.Forms.TextBox txtLocate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMoniName;
        private System.Windows.Forms.TextBox txtMoniCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMonitor;
        private System.Windows.Forms.RadioButton rbUse_Mon;
        private System.Windows.Forms.RadioButton rbNoUse_Mon;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbUse_Use;
        private System.Windows.Forms.RadioButton rbNoUse_Use;
    }
}