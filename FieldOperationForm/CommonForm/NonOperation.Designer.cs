namespace FieldOperationForm
{
    partial class NonOperation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_NonOperation = new System.Windows.Forms.DataGridView();
            this.btn_NonOperation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NonOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NonOperation
            // 
            this.dgv_NonOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_NonOperation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NonOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_NonOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NonOperation.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_NonOperation.Location = new System.Drawing.Point(12, 11);
            this.dgv_NonOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NonOperation.Name = "dgv_NonOperation";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NonOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_NonOperation.RowHeadersVisible = false;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.dgv_NonOperation.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_NonOperation.RowTemplate.Height = 23;
            this.dgv_NonOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NonOperation.Size = new System.Drawing.Size(1305, 606);
            this.dgv_NonOperation.TabIndex = 0;
            this.dgv_NonOperation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NonOperation_CellClick);
            // 
            // btn_NonOperation
            // 
            this.btn_NonOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NonOperation.BackColor = System.Drawing.Color.Ivory;
            this.btn_NonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NonOperation.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_NonOperation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_NonOperation.Location = new System.Drawing.Point(1335, 145);
            this.btn_NonOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NonOperation.Name = "btn_NonOperation";
            this.btn_NonOperation.Size = new System.Drawing.Size(196, 472);
            this.btn_NonOperation.TabIndex = 18;
            this.btn_NonOperation.Text = "비가동\r\n사유변경";
            this.btn_NonOperation.UseVisualStyleBackColor = false;
            this.btn_NonOperation.Click += new System.EventHandler(this.btn_NonOperation_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.BackgroundImage = global::FieldOperationForm.Properties.Resources.캡처1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(1335, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 121);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NonOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_NonOperation);
            this.Controls.Add(this.dgv_NonOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NonOperation";
            this.Text = "NonOperation";
            this.Load += new System.EventHandler(this.NonOperation_Load);
            this.Shown += new System.EventHandler(this.NonOperation_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NonOperation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NonOperation;
        private System.Windows.Forms.Button btn_NonOperation;
        private System.Windows.Forms.Button button1;
    }
}