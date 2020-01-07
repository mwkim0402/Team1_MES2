﻿namespace AdminForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlMainButton = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnBookMark = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.trvBookMark = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTab = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlMainButton.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogo,
            this.btnSave,
            this.btnCreate,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 86);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogo
            // 
            this.btnLogo.AutoSize = false;
            this.btnLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(190, 60);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 50);
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = false;
            this.btnCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(40, 50);
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreate.ToolTipText = "작성";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 50);
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.ToolTipText = "수정";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 50);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.ToolTipText = "삭제";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 83);
            this.toolStripLabel1.Text = "자식 toolStrip";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.trvBookMark);
            this.pnlMenu.Controls.Add(this.button7);
            this.pnlMenu.Controls.Add(this.button6);
            this.pnlMenu.Controls.Add(this.button5);
            this.pnlMenu.Controls.Add(this.trvMenu);
            this.pnlMenu.Controls.Add(this.button4);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 33);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(190, 550);
            this.pnlMenu.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(0, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 33);
            this.button7.TabIndex = 97;
            this.button7.Text = "금형관리";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(0, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 33);
            this.button6.TabIndex = 96;
            this.button6.Text = "일지관리";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(0, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 33);
            this.button5.TabIndex = 95;
            this.button5.Text = "품질관리";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // trvMenu
            // 
            this.trvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvMenu.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trvMenu.Location = new System.Drawing.Point(0, 218);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(190, 358);
            this.trvMenu.TabIndex = 2;
            this.trvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvBookMark_NodeMouseDoubleClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(0, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 33);
            this.button4.TabIndex = 94;
            this.button4.Text = "실적관리";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(0, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 33);
            this.button3.TabIndex = 93;
            this.button3.Text = "작업지시관리";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(0, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 33);
            this.button2.TabIndex = 92;
            this.button2.Text = "기준정보관리";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 33);
            this.button1.TabIndex = 91;
            this.button1.Text = "시스템관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1090, 550);
            this.tabControl2.TabIndex = 6;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            this.tabControl2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(177, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(96, 33);
            this.btnMenu.TabIndex = 98;
            this.btnMenu.Text = "메뉴";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMainButton
            // 
            this.pnlMainButton.Controls.Add(this.btnBookMark);
            this.pnlMainButton.Controls.Add(this.btnMenu);
            this.pnlMainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainButton.Location = new System.Drawing.Point(0, 0);
            this.pnlMainButton.Name = "pnlMainButton";
            this.pnlMainButton.Size = new System.Drawing.Size(190, 33);
            this.pnlMainButton.TabIndex = 100;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Controls.Add(this.pnlMainButton);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 86);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(190, 583);
            this.pnlMain.TabIndex = 101;
            // 
            // btnBookMark
            // 
            this.btnBookMark.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMark.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookMark.ForeColor = System.Drawing.Color.White;
            this.btnBookMark.Location = new System.Drawing.Point(94, 0);
            this.btnBookMark.Name = "btnBookMark";
            this.btnBookMark.Size = new System.Drawing.Size(96, 33);
            this.btnBookMark.TabIndex = 99;
            this.btnBookMark.Text = "즐겨찾기";
            this.btnBookMark.UseVisualStyleBackColor = false;
            this.btnBookMark.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTab);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(190, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 583);
            this.panel1.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(854, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 86);
            this.panel2.TabIndex = 103;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(259, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "로그인";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(339, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "환경설정";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // trvBookMark
            // 
            this.trvBookMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvBookMark.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trvBookMark.Location = new System.Drawing.Point(2, 232);
            this.trvBookMark.Name = "trvBookMark";
            this.trvBookMark.Size = new System.Drawing.Size(190, 358);
            this.trvBookMark.TabIndex = 98;
            this.trvBookMark.Visible = false;
            this.trvBookMark.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvBookMark_NodeMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblLocation);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 33);
            this.panel3.TabIndex = 7;
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.tabControl2);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab.Location = new System.Drawing.Point(0, 33);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(1090, 550);
            this.pnlTab.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(30, 10);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(484, 21);
            this.lblLocation.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MES_Solution";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMainButton.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnLogo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlMainButton;
        private System.Windows.Forms.Button btnBookMark;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TreeView trvBookMark;
        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLocation;
    }
}