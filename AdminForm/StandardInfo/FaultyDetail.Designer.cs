namespace AdminForm
{
    partial class FaultyDetail
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFaultCatCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInsRemark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInsFalse = new System.Windows.Forms.RadioButton();
            this.rbInsTrue = new System.Windows.Forms.RadioButton();
            this.txtInsDetailName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsDetailCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInsMasterCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtFaultCatCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 67);
            this.panel2.TabIndex = 16;
            // 
            // txtFaultCatCode
            // 
            this.txtFaultCatCode.Location = new System.Drawing.Point(182, 27);
            this.txtFaultCatCode.Name = "txtFaultCatCode";
            this.txtFaultCatCode.Size = new System.Drawing.Size(159, 21);
            this.txtFaultCatCode.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "불량현상 대분류 코드";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 95);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvSelect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2.Controls.Add(this.dgvSearchResult);
            this.splitContainer1.Size = new System.Drawing.Size(1140, 540);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 25);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "불량현상 대분류";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSelect
            // 
            this.dgvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(3, 28);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowTemplate.Height = 23;
            this.dgvSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelect.Size = new System.Drawing.Size(373, 509);
            this.dgvSelect.TabIndex = 0;
            this.dgvSelect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellDoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.tabControl3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 328);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(757, 212);
            this.panel5.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtInsDetailName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtInsDetailCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbInsMasterCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 164);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(697, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(49, 162);
            this.panel4.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 156);
            this.button1.TabIndex = 0;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtInsRemark);
            this.panel3.Location = new System.Drawing.Point(425, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 156);
            this.panel3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "비고";
            // 
            // txtInsRemark
            // 
            this.txtInsRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsRemark.Location = new System.Drawing.Point(3, 29);
            this.txtInsRemark.Multiline = true;
            this.txtInsRemark.Name = "txtInsRemark";
            this.txtInsRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInsRemark.Size = new System.Drawing.Size(264, 124);
            this.txtInsRemark.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInsFalse);
            this.groupBox1.Controls.Add(this.rbInsTrue);
            this.groupBox1.Location = new System.Drawing.Point(15, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 44);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용유무";
            // 
            // rbInsFalse
            // 
            this.rbInsFalse.AutoSize = true;
            this.rbInsFalse.Location = new System.Drawing.Point(124, 22);
            this.rbInsFalse.Name = "rbInsFalse";
            this.rbInsFalse.Size = new System.Drawing.Size(35, 16);
            this.rbInsFalse.TabIndex = 1;
            this.rbInsFalse.Text = "무";
            this.rbInsFalse.UseVisualStyleBackColor = true;
            // 
            // rbInsTrue
            // 
            this.rbInsTrue.AutoSize = true;
            this.rbInsTrue.Checked = true;
            this.rbInsTrue.Location = new System.Drawing.Point(41, 22);
            this.rbInsTrue.Name = "rbInsTrue";
            this.rbInsTrue.Size = new System.Drawing.Size(35, 16);
            this.rbInsTrue.TabIndex = 0;
            this.rbInsTrue.TabStop = true;
            this.rbInsTrue.Text = "유";
            this.rbInsTrue.UseVisualStyleBackColor = true;
            // 
            // txtInsDetailName
            // 
            this.txtInsDetailName.Location = new System.Drawing.Point(205, 90);
            this.txtInsDetailName.Name = "txtInsDetailName";
            this.txtInsDetailName.Size = new System.Drawing.Size(169, 21);
            this.txtInsDetailName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "불량현상 상세분류 이름";
            // 
            // txtInsDetailCode
            // 
            this.txtInsDetailCode.Location = new System.Drawing.Point(205, 53);
            this.txtInsDetailCode.Name = "txtInsDetailCode";
            this.txtInsDetailCode.Size = new System.Drawing.Size(169, 21);
            this.txtInsDetailCode.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "불량현상 상세분류 코드";
            // 
            // cbInsMasterCode
            // 
            this.cbInsMasterCode.FormattingEnabled = true;
            this.cbInsMasterCode.Location = new System.Drawing.Point(205, 17);
            this.cbInsMasterCode.MaxDropDownItems = 5;
            this.cbInsMasterCode.Name = "cbInsMasterCode";
            this.cbInsMasterCode.Size = new System.Drawing.Size(169, 20);
            this.cbInsMasterCode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "불량현상 대분류 코드";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl3.Location = new System.Drawing.Point(7, 9);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(200, 28);
            this.tabControl3.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "입력정보";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl2.Location = new System.Drawing.Point(7, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 27);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 0);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "불량현상 상세분류";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(7, 36);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.Size = new System.Drawing.Size(747, 286);
            this.dgvSearchResult.TabIndex = 1;
            // 
            // FaultyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 644);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FaultyDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FaultyDetail";
            this.Activated += new System.EventHandler(this.FaultyDetail_Activated);
            this.Deactivate += new System.EventHandler(this.FaultyDetail_Deactivate);
            this.Load += new System.EventHandler(this.FaultyDetail_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFaultCatCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbInsMasterCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInsRemark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInsFalse;
        private System.Windows.Forms.RadioButton rbInsTrue;
        private System.Windows.Forms.TextBox txtInsDetailName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsDetailCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
    }
}