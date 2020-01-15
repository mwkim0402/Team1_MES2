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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_NonOperation = new System.Windows.Forms.DataGridView();
            this.btn_NonOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NonOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NonOperation
            // 
            this.dgv_NonOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_NonOperation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NonOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NonOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NonOperation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NonOperation.Location = new System.Drawing.Point(12, 11);
            this.dgv_NonOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_NonOperation.Name = "dgv_NonOperation";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NonOperation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NonOperation.RowHeadersVisible = false;
            this.dgv_NonOperation.RowTemplate.Height = 23;
            this.dgv_NonOperation.Size = new System.Drawing.Size(1305, 606);
            this.dgv_NonOperation.TabIndex = 0;
            // 
            // btn_NonOperation
            // 
            this.btn_NonOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NonOperation.BackColor = System.Drawing.Color.Ivory;
            this.btn_NonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NonOperation.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_NonOperation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_NonOperation.Location = new System.Drawing.Point(1335, 11);
            this.btn_NonOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NonOperation.Name = "btn_NonOperation";
            this.btn_NonOperation.Size = new System.Drawing.Size(196, 606);
            this.btn_NonOperation.TabIndex = 18;
            this.btn_NonOperation.Text = "비가동\r\n사유변경";
            this.btn_NonOperation.UseVisualStyleBackColor = false;
            // 
            // NonOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 628);
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
    }
}