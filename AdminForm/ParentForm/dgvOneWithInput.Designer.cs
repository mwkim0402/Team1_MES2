namespace AdminForm
{
    partial class dgvOneWithInput
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
            this.tcParent1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.tcParent2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlParent1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcParent1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.tcParent2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcParent1
            // 
            this.tcParent1.Controls.Add(this.tabPage4);
            this.tcParent1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcParent1.Location = new System.Drawing.Point(16, 85);
            this.tcParent1.Name = "tcParent1";
            this.tcParent1.SelectedIndex = 0;
            this.tcParent1.Size = new System.Drawing.Size(94, 28);
            this.tcParent1.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(86, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "조회내역";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(16, 114);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.Size = new System.Drawing.Size(1128, 333);
            this.dgvSearchResult.TabIndex = 6;
            // 
            // tcParent2
            // 
            this.tcParent2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcParent2.Controls.Add(this.tabPage2);
            this.tcParent2.Controls.Add(this.tabPage1);
            this.tcParent2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcParent2.Location = new System.Drawing.Point(13, 466);
            this.tcParent2.Name = "tcParent2";
            this.tcParent2.SelectedIndex = 0;
            this.tcParent2.Size = new System.Drawing.Size(1132, 135);
            this.tcParent2.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlParent1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1124, 99);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "입력정보";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlParent1
            // 
            this.pnlParent1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlParent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent1.Location = new System.Drawing.Point(0, 0);
            this.pnlParent1.Name = "pnlParent1";
            this.pnlParent1.Size = new System.Drawing.Size(1124, 99);
            this.pnlParent1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1124, 99);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "수정정보";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 99);
            this.panel1.TabIndex = 9;
            // 
            // dgvOneWithInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 630);
            this.Controls.Add(this.tcParent2);
            this.Controls.Add(this.tcParent1);
            this.Controls.Add(this.dgvSearchResult);
            this.Name = "dgvOneWithInput";
            this.Text = "dgvOneWithInput";
            this.tcParent1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.tcParent2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tcParent1;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView dgvSearchResult;
        public System.Windows.Forms.TabControl tcParent2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Panel pnlParent1;
    }
}