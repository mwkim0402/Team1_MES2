namespace FieldOperationForm
{
    partial class warehousing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.txt_WorkPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_WorkDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_WorkNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Rating = new System.Windows.Forms.TextBox();
            this.txt_PaletteNum = new System.Windows.Forms.TextBox();
            this.txt_PaletteQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_warehousing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(18, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(837, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "금일 입고 팔레트 목록";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 562);
            this.dataGridView1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Item);
            this.groupBox1.Controls.Add(this.txt_WorkPlace);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_WorkDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_WorkNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Rating);
            this.groupBox1.Controls.Add(this.txt_PaletteNum);
            this.groupBox1.Controls.Add(this.txt_PaletteQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(877, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 456);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.Ivory;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Search.Location = new System.Drawing.Point(570, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(63, 54);
            this.btn_Search.TabIndex = 23;
            this.btn_Search.Text = "찾기";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Item
            // 
            this.txt_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Item.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item.Location = new System.Drawing.Point(203, 210);
            this.txt_Item.Multiline = true;
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(430, 41);
            this.txt_Item.TabIndex = 32;
            // 
            // txt_WorkPlace
            // 
            this.txt_WorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_WorkPlace.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_WorkPlace.Location = new System.Drawing.Point(203, 271);
            this.txt_WorkPlace.Multiline = true;
            this.txt_WorkPlace.Name = "txt_WorkPlace";
            this.txt_WorkPlace.Size = new System.Drawing.Size(430, 41);
            this.txt_WorkPlace.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(21, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "작업장";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(21, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "품목";
            // 
            // txt_WorkDate
            // 
            this.txt_WorkDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_WorkDate.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_WorkDate.Location = new System.Drawing.Point(203, 149);
            this.txt_WorkDate.Multiline = true;
            this.txt_WorkDate.Name = "txt_WorkDate";
            this.txt_WorkDate.Size = new System.Drawing.Size(430, 41);
            this.txt_WorkDate.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(21, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "작업 지시일";
            // 
            // txt_WorkNum
            // 
            this.txt_WorkNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_WorkNum.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_WorkNum.Location = new System.Drawing.Point(203, 88);
            this.txt_WorkNum.Multiline = true;
            this.txt_WorkNum.Name = "txt_WorkNum";
            this.txt_WorkNum.Size = new System.Drawing.Size(430, 41);
            this.txt_WorkNum.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "작업 지시번호";
            // 
            // txt_Rating
            // 
            this.txt_Rating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Rating.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Rating.Location = new System.Drawing.Point(203, 393);
            this.txt_Rating.Multiline = true;
            this.txt_Rating.Name = "txt_Rating";
            this.txt_Rating.Size = new System.Drawing.Size(430, 41);
            this.txt_Rating.TabIndex = 23;
            // 
            // txt_PaletteNum
            // 
            this.txt_PaletteNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PaletteNum.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_PaletteNum.Location = new System.Drawing.Point(203, 27);
            this.txt_PaletteNum.Multiline = true;
            this.txt_PaletteNum.Name = "txt_PaletteNum";
            this.txt_PaletteNum.Size = new System.Drawing.Size(361, 41);
            this.txt_PaletteNum.TabIndex = 22;
            this.txt_PaletteNum.TextChanged += new System.EventHandler(this.txt_PaletteNum_TextChanged);
            // 
            // txt_PaletteQuantity
            // 
            this.txt_PaletteQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PaletteQuantity.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_PaletteQuantity.Location = new System.Drawing.Point(203, 332);
            this.txt_PaletteQuantity.Multiline = true;
            this.txt_PaletteQuantity.Name = "txt_PaletteQuantity";
            this.txt_PaletteQuantity.Size = new System.Drawing.Size(430, 41);
            this.txt_PaletteQuantity.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(21, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "팔레트 수량";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(21, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "등급";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Ivory;
            this.label11.Location = new System.Drawing.Point(21, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 28);
            this.label11.TabIndex = 12;
            this.label11.Text = "팔레트 번호";
            // 
            // btn_warehousing
            // 
            this.btn_warehousing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_warehousing.BackColor = System.Drawing.Color.Ivory;
            this.btn_warehousing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehousing.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_warehousing.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_warehousing.Location = new System.Drawing.Point(877, 511);
            this.btn_warehousing.Name = "btn_warehousing";
            this.btn_warehousing.Size = new System.Drawing.Size(653, 105);
            this.btn_warehousing.TabIndex = 22;
            this.btn_warehousing.Text = "입고";
            this.btn_warehousing.UseVisualStyleBackColor = false;
            this.btn_warehousing.Click += new System.EventHandler(this.btn_warehousing_Click);
            // 
            // warehousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 628);
            this.Controls.Add(this.btn_warehousing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "warehousing";
            this.Text = "ReceivingRegistration";
            this.Deactivate += new System.EventHandler(this.warehousing_Deactivate);
            this.Load += new System.EventHandler(this.warehousing_Load);
            this.Shown += new System.EventHandler(this.warehousing_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Rating;
        private System.Windows.Forms.TextBox txt_PaletteNum;
        private System.Windows.Forms.TextBox txt_PaletteQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_WorkDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_WorkNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.TextBox txt_WorkPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_warehousing;
        private System.Windows.Forms.Button btn_Search;
    }
}