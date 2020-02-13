namespace FieldOperationForm
{
    partial class JobOrderStatus_Package
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_StartEnd = new System.Windows.Forms.Button();
            this.btn_FieldClose = new System.Windows.Forms.Button();
            this.btn_Worker = new System.Windows.Forms.Button();
            this.btn_CreatePalette = new System.Windows.Forms.Button();
            this.btn_BarCode = new System.Windows.Forms.Button();
            this.btn_warehousing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1475, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_StartEnd
            // 
            this.btn_StartEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_StartEnd.BackColor = System.Drawing.Color.Ivory;
            this.btn_StartEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartEnd.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_StartEnd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_StartEnd.Location = new System.Drawing.Point(30, 433);
            this.btn_StartEnd.Name = "btn_StartEnd";
            this.btn_StartEnd.Size = new System.Drawing.Size(219, 154);
            this.btn_StartEnd.TabIndex = 1;
            this.btn_StartEnd.Text = "작업시작/ \r\n종료";
            this.btn_StartEnd.UseVisualStyleBackColor = false;
            this.btn_StartEnd.Click += new System.EventHandler(this.btn_StartEnd_Click);
            // 
            // btn_FieldClose
            // 
            this.btn_FieldClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FieldClose.BackColor = System.Drawing.Color.Ivory;
            this.btn_FieldClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FieldClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_FieldClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_FieldClose.Location = new System.Drawing.Point(281, 433);
            this.btn_FieldClose.Name = "btn_FieldClose";
            this.btn_FieldClose.Size = new System.Drawing.Size(219, 154);
            this.btn_FieldClose.TabIndex = 2;
            this.btn_FieldClose.Text = "현장마감";
            this.btn_FieldClose.UseVisualStyleBackColor = false;
            // 
            // btn_Worker
            // 
            this.btn_Worker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Worker.BackColor = System.Drawing.Color.Ivory;
            this.btn_Worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Worker.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Worker.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Worker.Location = new System.Drawing.Point(532, 433);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(219, 154);
            this.btn_Worker.TabIndex = 4;
            this.btn_Worker.Text = "작업자\r\n할당";
            this.btn_Worker.UseVisualStyleBackColor = false;
            this.btn_Worker.Click += new System.EventHandler(this.btn_Worker_Click);
            // 
            // btn_CreatePalette
            // 
            this.btn_CreatePalette.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_CreatePalette.BackColor = System.Drawing.Color.Ivory;
            this.btn_CreatePalette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreatePalette.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CreatePalette.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_CreatePalette.Location = new System.Drawing.Point(783, 433);
            this.btn_CreatePalette.Name = "btn_CreatePalette";
            this.btn_CreatePalette.Size = new System.Drawing.Size(219, 154);
            this.btn_CreatePalette.TabIndex = 5;
            this.btn_CreatePalette.Text = "팔레트\r\n생성";
            this.btn_CreatePalette.UseVisualStyleBackColor = false;
            this.btn_CreatePalette.Click += new System.EventHandler(this.btn_CreatePalette_Click);
            // 
            // btn_BarCode
            // 
            this.btn_BarCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_BarCode.BackColor = System.Drawing.Color.Ivory;
            this.btn_BarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BarCode.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BarCode.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_BarCode.Location = new System.Drawing.Point(1034, 433);
            this.btn_BarCode.Name = "btn_BarCode";
            this.btn_BarCode.Size = new System.Drawing.Size(219, 154);
            this.btn_BarCode.TabIndex = 6;
            this.btn_BarCode.Text = "팔레트 바코드\r\n재발행";
            this.btn_BarCode.UseVisualStyleBackColor = false;
            this.btn_BarCode.Click += new System.EventHandler(this.btn_BarCode_Click);
            // 
            // btn_warehousing
            // 
            this.btn_warehousing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_warehousing.BackColor = System.Drawing.Color.Ivory;
            this.btn_warehousing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehousing.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_warehousing.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_warehousing.Location = new System.Drawing.Point(1285, 433);
            this.btn_warehousing.Name = "btn_warehousing";
            this.btn_warehousing.Size = new System.Drawing.Size(219, 154);
            this.btn_warehousing.TabIndex = 7;
            this.btn_warehousing.Text = "입고등록";
            this.btn_warehousing.UseVisualStyleBackColor = false;
            this.btn_warehousing.Click += new System.EventHandler(this.btn_warehousing_Click);
            // 
            // JobOrderStatus_Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btn_warehousing);
            this.Controls.Add(this.btn_BarCode);
            this.Controls.Add(this.btn_CreatePalette);
            this.Controls.Add(this.btn_Worker);
            this.Controls.Add(this.btn_FieldClose);
            this.Controls.Add(this.btn_StartEnd);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobOrderStatus_Package";
            this.Text = "JoboOderStatus";
            this.Load += new System.EventHandler(this.JobOrderStatus_Package_Load);
            this.Shown += new System.EventHandler(this.JobOrderStatus_Package_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_StartEnd;
        private System.Windows.Forms.Button btn_FieldClose;
        private System.Windows.Forms.Button btn_Worker;
        private System.Windows.Forms.Button btn_CreatePalette;
        private System.Windows.Forms.Button btn_BarCode;
        private System.Windows.Forms.Button btn_warehousing;
    }
}