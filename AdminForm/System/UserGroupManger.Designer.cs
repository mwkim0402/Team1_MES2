namespace AdminForm
{
    partial class UserGroupManger : dgvOneWithInput
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserCodeInput = new System.Windows.Forms.TextBox();
            this.txtUserNameInput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbUse_Use = new System.Windows.Forms.RadioButton();
            this.rbNoUse_Use = new System.Windows.Forms.RadioButton();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtUserNameInput);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtUserCodeInput);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(99, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtUserCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 84);
            this.panel2.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(569, 30);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 25);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(177, 30);
            this.txtUserCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(173, 25);
            this.txtUserCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(400, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "사용자 그룹명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자그룹코드";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1183, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 60);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtUserCodeInput
            // 
            this.txtUserCodeInput.Location = new System.Drawing.Point(483, 22);
            this.txtUserCodeInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserCodeInput.Name = "txtUserCodeInput";
            this.txtUserCodeInput.Size = new System.Drawing.Size(143, 25);
            this.txtUserCodeInput.TabIndex = 53;
            // 
            // txtUserNameInput
            // 
            this.txtUserNameInput.Location = new System.Drawing.Point(176, 24);
            this.txtUserNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserNameInput.Name = "txtUserNameInput";
            this.txtUserNameInput.Size = new System.Drawing.Size(143, 25);
            this.txtUserNameInput.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(351, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 20);
            this.label21.TabIndex = 50;
            this.label21.Text = "사용자 그룹명";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(22, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 20);
            this.label23.TabIndex = 49;
            this.label23.Text = "사용자그룹코드";
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbUse_Use);
            this.gbUsable.Controls.Add(this.rbNoUse_Use);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(915, 12);
            this.gbUsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUsable.Size = new System.Drawing.Size(229, 80);
            this.gbUsable.TabIndex = 89;
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
            // UserGroupManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserGroupManger";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UserGroupManger";
            this.Load += new System.EventHandler(this.UserGroupManger_Load);
            this.Controls.SetChildIndex(this.tabControl4, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
           // this.Controls.SetChildIndex(this.panel1, 0);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUserCodeInput;
        private System.Windows.Forms.TextBox txtUserNameInput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbUse_Use;
        private System.Windows.Forms.RadioButton rbNoUse_Use;
    }
}