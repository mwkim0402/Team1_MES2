namespace FieldOperationForm
{
    partial class Notice
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
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.dgv_Notice = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Title.Location = new System.Drawing.Point(765, 142);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.ReadOnly = true;
            this.txt_Title.Size = new System.Drawing.Size(493, 29);
            this.txt_Title.TabIndex = 6;
            // 
            // txt_Des
            // 
            this.txt_Des.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Des.Location = new System.Drawing.Point(765, 236);
            this.txt_Des.Multiline = true;
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.ReadOnly = true;
            this.txt_Des.Size = new System.Drawing.Size(493, 433);
            this.txt_Des.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(873, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "작성자";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Name.Location = new System.Drawing.Point(933, 189);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(118, 29);
            this.txt_Name.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1066, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "등록일";
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_date.Location = new System.Drawing.Point(1140, 189);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(118, 29);
            this.txt_date.TabIndex = 13;
            // 
            // dgv_Notice
            // 
            this.dgv_Notice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Notice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Notice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Notice.EnableHeadersVisualStyles = false;
            this.dgv_Notice.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_Notice.Location = new System.Drawing.Point(21, 54);
            this.dgv_Notice.MultiSelect = false;
            this.dgv_Notice.Name = "dgv_Notice";
            this.dgv_Notice.RowHeadersVisible = false;
            this.dgv_Notice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Notice.RowTemplate.Height = 23;
            this.dgv_Notice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Notice.Size = new System.Drawing.Size(673, 528);
            this.dgv_Notice.TabIndex = 4;
            this.dgv_Notice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Notice_CellClick);
            this.dgv_Notice.SelectionChanged += new System.EventHandler(this.dgv_Notice_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "공지 목록";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv_Notice);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 601);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 58);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::FieldOperationForm.Properties.Resources.캡처11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1208, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(14, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 630);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1295, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Des);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notice";
            this.Text = "공지사항";
            this.Load += new System.EventHandler(this.Notice_Load);
            this.Shown += new System.EventHandler(this.Notice_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Des;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.DataGridView dgv_Notice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}