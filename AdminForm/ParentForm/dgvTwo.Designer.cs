namespace AdminForm
{
    partial class dgvTwo
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvJobOrder = new System.Windows.Forms.DataGridView();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvProductRequset = new System.Windows.Forms.DataGridView();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrder)).BeginInit();
            this.tabControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductRequset)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(12, 327);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(94, 28);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(86, 0);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "작업지시";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvJobOrder
            // 
            this.dgvJobOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobOrder.Location = new System.Drawing.Point(12, 356);
            this.dgvJobOrder.Name = "dgvJobOrder";
            this.dgvJobOrder.RowTemplate.Height = 23;
            this.dgvJobOrder.Size = new System.Drawing.Size(1132, 220);
            this.dgvJobOrder.TabIndex = 9;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl4.Location = new System.Drawing.Point(12, 84);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(94, 28);
            this.tabControl4.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(86, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "생산의뢰";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvProductRequset
            // 
            this.dgvProductRequset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductRequset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductRequset.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductRequset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductRequset.Location = new System.Drawing.Point(12, 113);
            this.dgvProductRequset.Name = "dgvProductRequset";
            this.dgvProductRequset.RowTemplate.Height = 23;
            this.dgvProductRequset.Size = new System.Drawing.Size(1132, 207);
            this.dgvProductRequset.TabIndex = 7;
            // 
            // dgvTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.dgvJobOrder);
            this.Controls.Add(this.tabControl4);
            this.Controls.Add(this.dgvProductRequset);
            this.Name = "dgvTwo";
            this.Text = "dgvTwo";
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrder)).EndInit();
            this.tabControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductRequset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dgvJobOrder;
        public System.Windows.Forms.TabControl tabControl4;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView dgvProductRequset;
    }
}