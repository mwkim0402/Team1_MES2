namespace FieldOperationForm
{
    partial class Main_P
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
            this.components = new System.ComponentModel.Container();
            this.btn_home1 = new System.Windows.Forms.Button();
        
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Job = new System.Windows.Forms.Label();
            this.btn_FormClose = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Notice = new System.Windows.Forms.Label();
            this.btn_NonOperation = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
           // btn_home1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home1
            // 
          this.btn_home1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.btn_home1.BackColor = System.Drawing.Color.DarkSlateGray;
          this.btn_home1.BackgroundImage = global::FieldOperationForm.Properties.Resources.홈;
          this.  btn_home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
          this.  btn_home1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.  btn_home1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
          this.  btn_home1.Location = new System.Drawing.Point(1080, 12);
          this.  btn_home1.Name = "btn_home1";
          this.  btn_home1.Size = new System.Drawing.Size(80, 68);
          this.  btn_home1.TabIndex = 12;
          this.  btn_home1.UseVisualStyleBackColor = false;
          this.  btn_home1.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_Job);
            this.panel1.Controls.Add(this.btn_home1);
            this.panel1.Controls.Add(this.btn_FormClose);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 95);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(177, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 43);
            this.label3.TabIndex = 13;
            this.label3.Text = "님";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.BackColor = System.Drawing.Color.Ivory;
            this.lbl_name.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_name.Location = new System.Drawing.Point(2, 49);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(270, 43);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "ㄹ옹로";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Job
            // 
            this.lbl_Job.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Job.BackColor = System.Drawing.Color.Ivory;
            this.lbl_Job.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Job.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_Job.Location = new System.Drawing.Point(4, 3);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(270, 43);
            this.lbl_Job.TabIndex = 12;
            this.lbl_Job.Text = "ㄶㄶ";
            this.lbl_Job.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FormClose
            // 
            this.btn_FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FormClose.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_FormClose.BackgroundImage = global::FieldOperationForm.Properties.Resources.종료1;
            this.btn_FormClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FormClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_FormClose.Location = new System.Drawing.Point(1245, 12);
            this.btn_FormClose.Name = "btn_FormClose";
            this.btn_FormClose.Size = new System.Drawing.Size(73, 68);
            this.btn_FormClose.TabIndex = 12;
            this.btn_FormClose.UseVisualStyleBackColor = false;
            this.btn_FormClose.Click += new System.EventHandler(this.btn_FormClose_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_logout.BackgroundImage = global::FieldOperationForm.Properties.Resources.로그아웃;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_logout.Location = new System.Drawing.Point(1166, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(73, 68);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.BackColor = System.Drawing.Color.Ivory;
            this.lblChange.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChange.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblChange.Location = new System.Drawing.Point(445, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(440, 95);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "ㅎㄴ아ㅓ한";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_NonOperation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 783);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 60);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Notice);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 55);
            this.panel3.TabIndex = 15;
            // 
            // lbl_Notice
            // 
            this.lbl_Notice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notice.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notice.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Notice.Location = new System.Drawing.Point(3, 8);
            this.lbl_Notice.Name = "lbl_Notice";
            this.lbl_Notice.Size = new System.Drawing.Size(1170, 41);
            this.lbl_Notice.TabIndex = 12;
            this.lbl_Notice.Text = "~공지사항~ qefsghfhdhd";
            this.lbl_Notice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Notice.Click += new System.EventHandler(this.lbl_Notice_Click);
            // 
            // btn_NonOperation
            // 
            this.btn_NonOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NonOperation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_NonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NonOperation.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_NonOperation.Location = new System.Drawing.Point(1187, 5);
            this.btn_NonOperation.Name = "btn_NonOperation";
            this.btn_NonOperation.Size = new System.Drawing.Size(136, 50);
            this.btn_NonOperation.TabIndex = 14;
            this.btn_NonOperation.Text = "비가동 등록";
            this.btn_NonOperation.UseVisualStyleBackColor = false;
            this.btn_NonOperation.Click += new System.EventHandler(this.btn_NonOperation_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 843);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.Name = "Main_P";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FieldmanagementP_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_FormClose;
        public System.Windows.Forms.Button btn_NonOperation;
        private System.Windows.Forms.Label lbl_Notice;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_Job;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btn_home1;
    }
}