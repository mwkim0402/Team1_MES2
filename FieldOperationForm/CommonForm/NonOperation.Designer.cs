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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_NonOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 576);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_NonOperation
            // 
            this.btn_NonOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NonOperation.BackColor = System.Drawing.Color.Ivory;
            this.btn_NonOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NonOperation.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_NonOperation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_NonOperation.Location = new System.Drawing.Point(1329, 12);
            this.btn_NonOperation.Name = "btn_NonOperation";
            this.btn_NonOperation.Size = new System.Drawing.Size(203, 576);
            this.btn_NonOperation.TabIndex = 18;
            this.btn_NonOperation.Text = "비가동\r\n사유변경";
            this.btn_NonOperation.UseVisualStyleBackColor = false;
            // 
            // NonOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 600);
            this.Controls.Add(this.btn_NonOperation);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonOperation";
            this.Text = "NonOperation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_NonOperation;
    }
}