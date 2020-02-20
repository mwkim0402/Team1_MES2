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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGroupManger));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUse_EditUse = new System.Windows.Forms.RadioButton();
            this.rbUse_EditNoUse = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditUserGroupCode = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEditUserGroupName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tcParent1.SuspendLayout();
            this.tcParent2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlParent1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEditUserGroupCode);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtEditUserGroupName);
            this.panel1.Size = new System.Drawing.Size(1124, 103);
            // 
            // tabPage2
            // 
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // pnlParent1
            // 
            this.pnlParent1.BackColor = System.Drawing.Color.LightGray;
            this.pnlParent1.Controls.Add(this.gbUsable);
            this.pnlParent1.Controls.Add(this.label23);
            this.pnlParent1.Controls.Add(this.label21);
            this.pnlParent1.Controls.Add(this.txtUserNameInput);
            this.pnlParent1.Controls.Add(this.btnSave);
            this.pnlParent1.Controls.Add(this.txtUserCodeInput);
            this.pnlParent1.ForeColor = System.Drawing.Color.Black;
            this.pnlParent1.Location = new System.Drawing.Point(3, 4);
            this.pnlParent1.Size = new System.Drawing.Size(1118, 95);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtUserCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 67);
            this.panel2.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtUserName.Location = new System.Drawing.Point(498, 24);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 26);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtUserCode.Location = new System.Drawing.Point(155, 24);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(152, 26);
            this.txtUserCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label3.Location = new System.Drawing.Point(350, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "사용자 그룹명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자그룹코드";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(829, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserCodeInput
            // 
            this.txtUserCodeInput.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtUserCodeInput.Location = new System.Drawing.Point(424, 37);
            this.txtUserCodeInput.Name = "txtUserCodeInput";
            this.txtUserCodeInput.Size = new System.Drawing.Size(126, 26);
            this.txtUserCodeInput.TabIndex = 53;
            // 
            // txtUserNameInput
            // 
            this.txtUserNameInput.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtUserNameInput.Location = new System.Drawing.Point(155, 38);
            this.txtUserNameInput.Name = "txtUserNameInput";
            this.txtUserNameInput.Size = new System.Drawing.Size(126, 26);
            this.txtUserNameInput.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.LightGray;
            this.label21.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(299, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 19);
            this.label21.TabIndex = 50;
            this.label21.Text = "사용자 그룹명";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.LightGray;
            this.label23.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(26, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 19);
            this.label23.TabIndex = 49;
            this.label23.Text = "사용자그룹코드";
            // 
            // gbUsable
            // 
            this.gbUsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsable.Controls.Add(this.rbUse_Use);
            this.gbUsable.Controls.Add(this.rbNoUse_Use);
            this.gbUsable.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gbUsable.Location = new System.Drawing.Point(589, 10);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Size = new System.Drawing.Size(200, 64);
            this.gbUsable.TabIndex = 89;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // rbUse_Use
            // 
            this.rbUse_Use.AutoSize = true;
            this.rbUse_Use.BackColor = System.Drawing.Color.LightGray;
            this.rbUse_Use.ForeColor = System.Drawing.Color.Black;
            this.rbUse_Use.Location = new System.Drawing.Point(43, 28);
            this.rbUse_Use.Name = "rbUse_Use";
            this.rbUse_Use.Size = new System.Drawing.Size(42, 23);
            this.rbUse_Use.TabIndex = 77;
            this.rbUse_Use.TabStop = true;
            this.rbUse_Use.Text = "유";
            this.rbUse_Use.UseVisualStyleBackColor = false;
            // 
            // rbNoUse_Use
            // 
            this.rbNoUse_Use.AutoSize = true;
            this.rbNoUse_Use.BackColor = System.Drawing.Color.LightGray;
            this.rbNoUse_Use.ForeColor = System.Drawing.Color.Black;
            this.rbNoUse_Use.Location = new System.Drawing.Point(111, 28);
            this.rbNoUse_Use.Name = "rbNoUse_Use";
            this.rbNoUse_Use.Size = new System.Drawing.Size(42, 23);
            this.rbNoUse_Use.TabIndex = 79;
            this.rbNoUse_Use.TabStop = true;
            this.rbNoUse_Use.Text = "무";
            this.rbNoUse_Use.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbUse_EditUse);
            this.groupBox1.Controls.Add(this.rbUse_EditNoUse);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.groupBox1.Location = new System.Drawing.Point(582, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 64);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용여부";
            // 
            // rbUse_EditUse
            // 
            this.rbUse_EditUse.AutoSize = true;
            this.rbUse_EditUse.BackColor = System.Drawing.Color.LightGray;
            this.rbUse_EditUse.Location = new System.Drawing.Point(43, 28);
            this.rbUse_EditUse.Name = "rbUse_EditUse";
            this.rbUse_EditUse.Size = new System.Drawing.Size(42, 23);
            this.rbUse_EditUse.TabIndex = 77;
            this.rbUse_EditUse.TabStop = true;
            this.rbUse_EditUse.Text = "유";
            this.rbUse_EditUse.UseVisualStyleBackColor = false;
            // 
            // rbUse_EditNoUse
            // 
            this.rbUse_EditNoUse.AutoSize = true;
            this.rbUse_EditNoUse.BackColor = System.Drawing.Color.LightGray;
            this.rbUse_EditNoUse.Location = new System.Drawing.Point(111, 28);
            this.rbUse_EditNoUse.Name = "rbUse_EditNoUse";
            this.rbUse_EditNoUse.Size = new System.Drawing.Size(42, 23);
            this.rbUse_EditNoUse.TabIndex = 79;
            this.rbUse_EditNoUse.TabStop = true;
            this.rbUse_EditNoUse.Text = "무";
            this.rbUse_EditNoUse.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = "사용자그룹코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label4.Location = new System.Drawing.Point(301, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "사용자 그룹명";
            // 
            // txtEditUserGroupCode
            // 
            this.txtEditUserGroupCode.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtEditUserGroupCode.Location = new System.Drawing.Point(157, 43);
            this.txtEditUserGroupCode.Name = "txtEditUserGroupCode";
            this.txtEditUserGroupCode.Size = new System.Drawing.Size(126, 26);
            this.txtEditUserGroupCode.TabIndex = 92;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(807, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 48);
            this.btnEdit.TabIndex = 94;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEditUserGroupName
            // 
            this.txtEditUserGroupName.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtEditUserGroupName.Location = new System.Drawing.Point(426, 42);
            this.txtEditUserGroupName.Name = "txtEditUserGroupName";
            this.txtEditUserGroupName.Size = new System.Drawing.Size(126, 26);
            this.txtEditUserGroupName.TabIndex = 93;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1156, 63);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton1.Text = "조건검색";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // UserGroupManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserGroupManger";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UserGroupManger";
            this.Activated += new System.EventHandler(this.UserGroupManger_Activated);
            this.Deactivate += new System.EventHandler(this.UserGroupManger_Deactivate);
            this.Load += new System.EventHandler(this.UserGroupManger_Load);
            this.Controls.SetChildIndex(this.tcParent1, 0);
            this.Controls.SetChildIndex(this.tcParent2, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.tcParent1.ResumeLayout(false);
            this.tcParent2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlParent1.ResumeLayout(false);
            this.pnlParent1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUse_EditUse;
        private System.Windows.Forms.RadioButton rbUse_EditNoUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditUserGroupCode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEditUserGroupName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}