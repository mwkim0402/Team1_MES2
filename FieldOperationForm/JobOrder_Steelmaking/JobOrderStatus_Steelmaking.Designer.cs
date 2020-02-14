namespace FieldOperationForm
{
    partial class JobOrderStatus_Steelmaking
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
            this.btn_Process = new System.Windows.Forms.Button();
            this.btn_Worker = new System.Windows.Forms.Button();
            this.btn_FieldClose = new System.Windows.Forms.Button();
            this.btn_StartEnd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Process
            // 
            this.btn_Process.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Process.BackColor = System.Drawing.Color.Ivory;
            this.btn_Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Process.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Process.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Process.Location = new System.Drawing.Point(1211, 432);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(296, 156);
            this.btn_Process.TabIndex = 16;
            this.btn_Process.Text = "공정조건\r\n등록";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // btn_Worker
            // 
            this.btn_Worker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Worker.BackColor = System.Drawing.Color.Ivory;
            this.btn_Worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Worker.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Worker.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Worker.Location = new System.Drawing.Point(818, 432);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(296, 156);
            this.btn_Worker.TabIndex = 12;
            this.btn_Worker.Text = "작업자\r\n할당";
            this.btn_Worker.UseVisualStyleBackColor = false;
            this.btn_Worker.Click += new System.EventHandler(this.btn_Worker_Click);
            // 
            // btn_FieldClose
            // 
            this.btn_FieldClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FieldClose.BackColor = System.Drawing.Color.Ivory;
            this.btn_FieldClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FieldClose.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_FieldClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_FieldClose.Location = new System.Drawing.Point(425, 432);
            this.btn_FieldClose.Name = "btn_FieldClose";
            this.btn_FieldClose.Size = new System.Drawing.Size(296, 156);
            this.btn_FieldClose.TabIndex = 11;
            this.btn_FieldClose.Text = "현장마감";
            this.btn_FieldClose.UseVisualStyleBackColor = false;
            this.btn_FieldClose.Click += new System.EventHandler(this.btn_FieldClose_Click);
            // 
            // btn_StartEnd
            // 
            this.btn_StartEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_StartEnd.BackColor = System.Drawing.Color.Ivory;
            this.btn_StartEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartEnd.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_StartEnd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_StartEnd.Location = new System.Drawing.Point(32, 432);
            this.btn_StartEnd.Name = "btn_StartEnd";
            this.btn_StartEnd.Size = new System.Drawing.Size(296, 156);
            this.btn_StartEnd.TabIndex = 10;
            this.btn_StartEnd.Text = "작업시작/ \r\n종료";
            this.btn_StartEnd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1475, 392);
            this.dataGridView1.TabIndex = 9;
            // 
            // JobOrderStatus_Steelmaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 600);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.btn_Worker);
            this.Controls.Add(this.btn_FieldClose);
            this.Controls.Add(this.btn_StartEnd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobOrderStatus_Steelmaking";
            this.Text = "JobOrderStatus_Steelmaking";
            this.Load += new System.EventHandler(this.JobOrderStatus_Steelmaking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Process;
        public System.Windows.Forms.Button btn_Worker;
        public System.Windows.Forms.Button btn_FieldClose;
        public System.Windows.Forms.Button btn_StartEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}