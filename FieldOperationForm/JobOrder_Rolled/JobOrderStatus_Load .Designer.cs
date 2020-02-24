namespace FieldOperationForm
{
    partial class JobOrderStatus_Load
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_StartEnd = new System.Windows.Forms.Button();
            this.btn_FieldClose = new System.Windows.Forms.Button();
            this.btn_Worker = new System.Windows.Forms.Button();
            this.btn_Process = new System.Windows.Forms.Button();
            this.btn_mold = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.btn_StartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_StartEnd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_StartEnd.Location = new System.Drawing.Point(30, 437);
            this.btn_StartEnd.Name = "btn_StartEnd";
            this.btn_StartEnd.Size = new System.Drawing.Size(210, 151);
            this.btn_StartEnd.TabIndex = 1;
            this.btn_StartEnd.Text = "작업시작";
            this.btn_StartEnd.UseVisualStyleBackColor = false;
            this.btn_StartEnd.Click += new System.EventHandler(this.btn_StartEnd_Click);
            // 
            // btn_FieldClose
            // 
            this.btn_FieldClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FieldClose.BackColor = System.Drawing.Color.Ivory;
            this.btn_FieldClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FieldClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_FieldClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_FieldClose.Location = new System.Drawing.Point(283, 437);
            this.btn_FieldClose.Name = "btn_FieldClose";
            this.btn_FieldClose.Size = new System.Drawing.Size(210, 151);
            this.btn_FieldClose.TabIndex = 2;
            this.btn_FieldClose.Text = "현장마감";
            this.btn_FieldClose.UseVisualStyleBackColor = false;
            this.btn_FieldClose.Click += new System.EventHandler(this.btn_FieldClose_Click);
            // 
            // btn_Worker
            // 
            this.btn_Worker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Worker.BackColor = System.Drawing.Color.Ivory;
            this.btn_Worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Worker.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Worker.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Worker.Location = new System.Drawing.Point(536, 437);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(215, 151);
            this.btn_Worker.TabIndex = 4;
            this.btn_Worker.Text = "작업자\r\n할당";
            this.btn_Worker.UseVisualStyleBackColor = false;
            this.btn_Worker.Click += new System.EventHandler(this.btn_Worker_Click);
            // 
            // btn_Process
            // 
            this.btn_Process.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Process.BackColor = System.Drawing.Color.Ivory;
            this.btn_Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Process.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Process.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Process.Location = new System.Drawing.Point(1295, 437);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(215, 151);
            this.btn_Process.TabIndex = 8;
            this.btn_Process.Text = "공정조건\r\n등록";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // btn_mold
            // 
            this.btn_mold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_mold.BackColor = System.Drawing.Color.Ivory;
            this.btn_mold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mold.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mold.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_mold.Location = new System.Drawing.Point(789, 437);
            this.btn_mold.Name = "btn_mold";
            this.btn_mold.Size = new System.Drawing.Size(215, 151);
            this.btn_mold.TabIndex = 9;
            this.btn_mold.Text = "금형 장착/\r\n탈착";
            this.btn_mold.UseVisualStyleBackColor = false;
            this.btn_mold.Click += new System.EventHandler(this.btn_mold_Click);
            // 
            // s
            // 
            this.s.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.s.BackColor = System.Drawing.Color.Ivory;
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.s.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.s.Location = new System.Drawing.Point(1042, 437);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(215, 151);
            this.s.TabIndex = 10;
            this.s.Text = "품질 측정";
            this.s.UseVisualStyleBackColor = false;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(30, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 151);
            this.button2.TabIndex = 1;
            this.button2.Text = "작업시작";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_StartEnd_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(283, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 151);
            this.button3.TabIndex = 2;
            this.button3.Text = "현장마감";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_FieldClose_Click);
            // 
            // JobOrderStatus_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 600);
            this.ControlBox = false;
            this.Controls.Add(this.s);
            this.Controls.Add(this.btn_mold);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.btn_Worker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_FieldClose);
            this.Controls.Add(this.btn_StartEnd);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobOrderStatus_Load";
            this.Text = "JoboOderStatus";
            this.Load += new System.EventHandler(this.JobOrderStatus_Load_Load);
            this.Shown += new System.EventHandler(this.JobOrderStatus_Load_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_StartEnd;
        private System.Windows.Forms.Button btn_FieldClose;
        private System.Windows.Forms.Button btn_Worker;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Button btn_mold;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}