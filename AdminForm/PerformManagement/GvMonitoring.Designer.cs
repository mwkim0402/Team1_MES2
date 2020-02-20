namespace AdminForm
{
    partial class GVMonitoring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvNoRun = new System.Windows.Forms.DataGridView();
            this.dgvRun = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 54);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "작업장 현황";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvRun);
            this.panel2.Controls.Add(this.tabControl4);
            this.panel2.Location = new System.Drawing.Point(16, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 351);
            this.panel2.TabIndex = 0;
            // 
            // tabControl4
            // 
            this.tabControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl4.Location = new System.Drawing.Point(3, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1125, 25);
            this.tabControl4.TabIndex = 12;
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1117, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "가동중인 작업장";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvNoRun);
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(16, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 147);
            this.panel3.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 25);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1117, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "비가동 작업장";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvNoRun
            // 
            this.dgvNoRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNoRun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNoRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoRun.Location = new System.Drawing.Point(2, 28);
            this.dgvNoRun.Name = "dgvNoRun";
            this.dgvNoRun.RowTemplate.Height = 23;
            this.dgvNoRun.Size = new System.Drawing.Size(1125, 119);
            this.dgvNoRun.TabIndex = 13;
            // 
            // dgvRun
            // 
            this.dgvRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRun.Location = new System.Drawing.Point(2, 25);
            this.dgvRun.Name = "dgvRun";
            this.dgvRun.RowTemplate.Height = 23;
            this.dgvRun.Size = new System.Drawing.Size(1125, 323);
            this.dgvRun.TabIndex = 12;
            // 
            // GVMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GVMonitoring";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GvMonitoring";
            this.Activated += new System.EventHandler(this.GVMonitoring_Activated);
            this.Deactivate += new System.EventHandler(this.GVMonitoring_Deactivate);
            this.Load += new System.EventHandler(this.GvMonitoring_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvNoRun;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvRun;
    }
}