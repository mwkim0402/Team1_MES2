namespace AdminForm
{
    partial class UserManager : dgvOneWithInput
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
            this.txtStandFac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserGroup = new System.Windows.Forms.TextBox();
            this.txtUserIDInput = new System.Windows.Forms.TextBox();
            this.txtUserNameInput = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.cmbUsable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fcPermiGroup = new AdminForm.FIndCategory();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbIP = new System.Windows.Forms.GroupBox();
            this.rbUse_IP = new System.Windows.Forms.RadioButton();
            this.rbNoUse_IP = new System.Windows.Forms.RadioButton();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbUse_Use = new System.Windows.Forms.RadioButton();
            this.rbNoUse_Use = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbIP.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbIP);
            this.panel1.Controls.Add(this.txtStandFac);
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtUserNameInput);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtUserIDInput);
            this.panel1.Controls.Add(this.txtUserGroup);
            // 
            // txtStandFac
            // 
            this.txtStandFac.Location = new System.Drawing.Point(418, 48);
            this.txtStandFac.Name = "txtStandFac";
            this.txtStandFac.Size = new System.Drawing.Size(152, 21);
            this.txtStandFac.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(319, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "기본 공정";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1036, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 48);
            this.button1.TabIndex = 81;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUserGroup
            // 
            this.txtUserGroup.Location = new System.Drawing.Point(418, 16);
            this.txtUserGroup.Name = "txtUserGroup";
            this.txtUserGroup.Size = new System.Drawing.Size(152, 21);
            this.txtUserGroup.TabIndex = 76;
            // 
            // txtUserIDInput
            // 
            this.txtUserIDInput.Location = new System.Drawing.Point(119, 47);
            this.txtUserIDInput.Name = "txtUserIDInput";
            this.txtUserIDInput.Size = new System.Drawing.Size(152, 21);
            this.txtUserIDInput.TabIndex = 75;
            // 
            // txtUserNameInput
            // 
            this.txtUserNameInput.Location = new System.Drawing.Point(119, 16);
            this.txtUserNameInput.Name = "txtUserNameInput";
            this.txtUserNameInput.Size = new System.Drawing.Size(152, 21);
            this.txtUserNameInput.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label19.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(20, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 72;
            this.label19.Text = "사용자 ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(319, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 16);
            this.label21.TabIndex = 71;
            this.label21.Text = "사용자 그룹";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(20, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 16);
            this.label23.TabIndex = 70;
            this.label23.Text = "사용자 이름";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtUserID);
            this.panel2.Controls.Add(this.cmbUsable);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.fcPermiGroup);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 67);
            this.panel2.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(702, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(129, 21);
            this.txtUserName.TabIndex = 11;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(431, 25);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(129, 21);
            this.txtUserID.TabIndex = 10;
            // 
            // cmbUsable
            // 
            this.cmbUsable.FormattingEnabled = true;
            this.cmbUsable.Location = new System.Drawing.Point(971, 26);
            this.cmbUsable.Name = "cmbUsable";
            this.cmbUsable.Size = new System.Drawing.Size(121, 20);
            this.cmbUsable.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(893, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "사용여부";
            // 
            // fcPermiGroup
            // 
            this.fcPermiGroup.Location = new System.Drawing.Point(102, 22);
            this.fcPermiGroup.Name = "fcPermiGroup";
            this.fcPermiGroup.Size = new System.Drawing.Size(190, 27);
            this.fcPermiGroup.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(603, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "사용자 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(357, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "사용자ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "권한 그룹";
            // 
            // gbIP
            // 
            this.gbIP.Controls.Add(this.rbUse_IP);
            this.gbIP.Controls.Add(this.rbNoUse_IP);
            this.gbIP.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbIP.Location = new System.Drawing.Point(820, 11);
            this.gbIP.Name = "gbIP";
            this.gbIP.Size = new System.Drawing.Size(200, 64);
            this.gbIP.TabIndex = 89;
            this.gbIP.TabStop = false;
            this.gbIP.Text = "IP보안 적용유무";
            // 
            // rbUse_IP
            // 
            this.rbUse_IP.AutoSize = true;
            this.rbUse_IP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbUse_IP.Location = new System.Drawing.Point(43, 28);
            this.rbUse_IP.Name = "rbUse_IP";
            this.rbUse_IP.Size = new System.Drawing.Size(42, 20);
            this.rbUse_IP.TabIndex = 77;
            this.rbUse_IP.TabStop = true;
            this.rbUse_IP.Text = "유";
            this.rbUse_IP.UseVisualStyleBackColor = false;
            // 
            // rbNoUse_IP
            // 
            this.rbNoUse_IP.AutoSize = true;
            this.rbNoUse_IP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNoUse_IP.Location = new System.Drawing.Point(111, 28);
            this.rbNoUse_IP.Name = "rbNoUse_IP";
            this.rbNoUse_IP.Size = new System.Drawing.Size(42, 20);
            this.rbNoUse_IP.TabIndex = 79;
            this.rbNoUse_IP.TabStop = true;
            this.rbNoUse_IP.Text = "무";
            this.rbNoUse_IP.UseVisualStyleBackColor = false;
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbUse_Use);
            this.gbUsable.Controls.Add(this.rbNoUse_Use);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(597, 11);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Size = new System.Drawing.Size(200, 64);
            this.gbUsable.TabIndex = 88;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
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
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UserManager";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbIP.ResumeLayout(false);
            this.gbIP.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtStandFac;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtUserNameInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserIDInput;
        private System.Windows.Forms.TextBox txtUserGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.ComboBox cmbUsable;
        private System.Windows.Forms.Label label5;
        private FIndCategory fcPermiGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbIP;
        private System.Windows.Forms.RadioButton rbUse_IP;
        private System.Windows.Forms.RadioButton rbNoUse_IP;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbUse_Use;
        private System.Windows.Forms.RadioButton rbNoUse_Use;
    }
}