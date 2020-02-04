namespace AdminForm
{
    partial class MoldingOrderCreation : dgvTwo
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
            this.txtOrderCreationNum = new System.Windows.Forms.TextBox();
            this.btnOrderCreationDeadline = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSo = new System.Windows.Forms.ToolStripButton();
            this.btnGun = new System.Windows.Forms.ToolStripButton();
            this.btnSung = new System.Windows.Forms.ToolStripButton();
            this.btnPo = new System.Windows.Forms.ToolStripButton();
            this.tabControl2.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtOrderCreationNum);
            this.panel1.Controls.Add(this.btnOrderCreationDeadline);
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
            // txtOrderCreationNum
            // 
            this.txtOrderCreationNum.Location = new System.Drawing.Point(472, 25);
            this.txtOrderCreationNum.Name = "txtOrderCreationNum";
            this.txtOrderCreationNum.Size = new System.Drawing.Size(100, 21);
            this.txtOrderCreationNum.TabIndex = 11;
            // 
            // btnOrderCreationDeadline
            // 
            this.btnOrderCreationDeadline.Location = new System.Drawing.Point(590, 18);
            this.btnOrderCreationDeadline.Name = "btnOrderCreationDeadline";
            this.btnOrderCreationDeadline.Size = new System.Drawing.Size(65, 33);
            this.btnOrderCreationDeadline.TabIndex = 10;
            this.btnOrderCreationDeadline.Text = "조회";
            this.btnOrderCreationDeadline.UseVisualStyleBackColor = true;
            this.btnOrderCreationDeadline.Click += new System.EventHandler(this.BtnOrderCreationDeadline_Click);
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
            this.dtpStart.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
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
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSo,
            this.btnGun,
            this.btnSung,
            this.btnPo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1156, 86);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // btnSo
            // 
            this.btnSo.AutoSize = false;
            this.btnSo.Image = global::AdminForm.Properties.Resources.Action_Save_New_32x32;
            this.btnSo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSo.Name = "btnSo";
            this.btnSo.Size = new System.Drawing.Size(80, 60);
            this.btnSo.Text = "압연계획생성";
            this.btnSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSo.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnGun
            // 
            this.btnGun.AutoSize = false;
            this.btnGun.Image = global::AdminForm.Properties.Resources.Action_Save_New_32x32;
            this.btnGun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGun.Name = "btnGun";
            this.btnGun.Size = new System.Drawing.Size(80, 60);
            this.btnGun.Text = "제강계획생성";
            this.btnGun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGun.Click += new System.EventHandler(this.btnGun_Click);
            // 
            // btnSung
            // 
            this.btnSung.AutoSize = false;
            this.btnSung.Image = global::AdminForm.Properties.Resources.Action_Save_New_32x32;
            this.btnSung.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSung.Name = "btnSung";
            this.btnSung.Size = new System.Drawing.Size(80, 60);
            this.btnSung.Text = "제선계획생성";
            this.btnSung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSung.Click += new System.EventHandler(this.btnSung_Click);
            // 
            // btnPo
            // 
            this.btnPo.AutoSize = false;
            this.btnPo.AutoToolTip = false;
            this.btnPo.Image = global::AdminForm.Properties.Resources.Action_Save_New_32x32;
            this.btnPo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPo.Name = "btnPo";
            this.btnPo.Size = new System.Drawing.Size(80, 60);
            this.btnPo.Text = "포장계획생성";
            this.btnPo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPo.Click += new System.EventHandler(this.btnPo_Click);
            // 
            // MoldingOrderCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoldingOrderCreation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MoldingOrderCreation";
            this.Activated += new System.EventHandler(this.MoldingOrderCreation_Activated);
            this.Deactivate += new System.EventHandler(this.MoldingOrderCreation_Deactivate);
            this.Load += new System.EventHandler(this.MoldingOrderCreation_Load);
            this.Controls.SetChildIndex(this.tabControl4, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.tabControl2.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrderCreationDeadline;
        private System.Windows.Forms.TextBox txtOrderCreationNum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSo;
        private System.Windows.Forms.ToolStripButton btnGun;
        private System.Windows.Forms.ToolStripButton btnSung;
        private System.Windows.Forms.ToolStripButton btnPo;
    }
}