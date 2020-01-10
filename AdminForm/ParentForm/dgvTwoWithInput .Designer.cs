namespace AdminForm
{
    partial class dgvTwoWithInput
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
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl4.Location = new System.Drawing.Point(2, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(94, 28);
            this.tabControl4.TabIndex = 7;
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
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(2, 32);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.Size = new System.Drawing.Size(739, 337);
            this.dgvSearchResult.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 84);
            this.panel1.TabIndex = 8;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(11, 375);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(94, 28);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(86, 0);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "입력정보";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(1, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(84, 28);
            this.tabControl3.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(76, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "조회내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSelect
            // 
            this.dgvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(0, 32);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowTemplate.Height = 23;
            this.dgvSelect.Size = new System.Drawing.Size(374, 456);
            this.dgvSelect.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(20, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dgvSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl4);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSearchResult);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 488);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 12;
            // 
            // dgvTwoWithInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "dgvTwoWithInput";
            this.Text = "dgvTwoWithInput";
            this.tabControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl4;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.DataGridView dgvSearchResult;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}