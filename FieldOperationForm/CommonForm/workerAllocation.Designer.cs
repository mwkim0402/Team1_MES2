namespace FieldOperationForm
{
    partial class workerAllocation 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Wc_Name = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_WorkerNum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_WorkerOn = new System.Windows.Forms.Button();
            this.btn_WorkerOff = new System.Windows.Forms.Button();
            this.btn_WorkerFullOff = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업장";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "할당 작업자수";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Wc_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cb_Wc_Name
            // 
            this.cb_Wc_Name.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Wc_Name.FormattingEnabled = true;
            this.cb_Wc_Name.Location = new System.Drawing.Point(118, 21);
            this.cb_Wc_Name.Name = "cb_Wc_Name";
            this.cb_Wc_Name.Size = new System.Drawing.Size(406, 36);
            this.cb_Wc_Name.TabIndex = 20;
            this.cb_Wc_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Wc_Name_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_WorkerNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(591, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txt_WorkerNum
            // 
            this.txt_WorkerNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_WorkerNum.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_WorkerNum.Location = new System.Drawing.Point(199, 18);
            this.txt_WorkerNum.Multiline = true;
            this.txt_WorkerNum.Name = "txt_WorkerNum";
            this.txt_WorkerNum.Size = new System.Drawing.Size(372, 41);
            this.txt_WorkerNum.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 474);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_WorkerOn
            // 
            this.btn_WorkerOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_WorkerOn.BackColor = System.Drawing.Color.Ivory;
            this.btn_WorkerOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_WorkerOn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_WorkerOn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_WorkerOn.Location = new System.Drawing.Point(9, 54);
            this.btn_WorkerOn.Name = "btn_WorkerOn";
            this.btn_WorkerOn.Size = new System.Drawing.Size(219, 134);
            this.btn_WorkerOn.TabIndex = 8;
            this.btn_WorkerOn.Text = "작업자 할당\r\n\r\n";
            this.btn_WorkerOn.UseVisualStyleBackColor = false;
            this.btn_WorkerOn.Click += new System.EventHandler(this.btn_WorkerOn_Click);
            // 
            // btn_WorkerOff
            // 
            this.btn_WorkerOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_WorkerOff.BackColor = System.Drawing.Color.Ivory;
            this.btn_WorkerOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_WorkerOff.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_WorkerOff.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_WorkerOff.Location = new System.Drawing.Point(9, 225);
            this.btn_WorkerOff.Name = "btn_WorkerOff";
            this.btn_WorkerOff.Size = new System.Drawing.Size(219, 134);
            this.btn_WorkerOff.TabIndex = 9;
            this.btn_WorkerOff.Text = "작업자 해제\r\n\r\n";
            this.btn_WorkerOff.UseVisualStyleBackColor = false;
            this.btn_WorkerOff.Click += new System.EventHandler(this.btn_WorkerOff_Click);
            // 
            // btn_WorkerFullOff
            // 
            this.btn_WorkerFullOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_WorkerFullOff.BackColor = System.Drawing.Color.Ivory;
            this.btn_WorkerFullOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_WorkerFullOff.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_WorkerFullOff.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_WorkerFullOff.Location = new System.Drawing.Point(9, 394);
            this.btn_WorkerFullOff.Name = "btn_WorkerFullOff";
            this.btn_WorkerFullOff.Size = new System.Drawing.Size(219, 134);
            this.btn_WorkerFullOff.TabIndex = 12;
            this.btn_WorkerFullOff.Text = "작업자\r\n전체해제\r\n\r\n";
            this.btn_WorkerFullOff.UseVisualStyleBackColor = false;
            this.btn_WorkerFullOff.Click += new System.EventHandler(this.btn_WorkerFullOff_Click);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(3, 54);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(627, 474);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(97, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "←";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(97, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "→";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(97, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "→";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(627, 40);
            this.label6.TabIndex = 17;
            this.label6.Text = "할당 작업자";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(627, 40);
            this.label7.TabIndex = 18;
            this.label7.Text = "할당 대상 작업자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 536);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(899, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 536);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_WorkerOn);
            this.panel3.Controls.Add(this.btn_WorkerOff);
            this.panel3.Controls.Add(this.btn_WorkerFullOff);
            this.panel3.Location = new System.Drawing.Point(655, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 536);
            this.panel3.TabIndex = 18;
            // 
            // workerAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 628);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "workerAllocation";
            this.Text = "workerAllocation";
            this.Load += new System.EventHandler(this.workerAllocation_Load);
            this.Shown += new System.EventHandler(this.workerAllocation_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_WorkerNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_WorkerOn;
        private System.Windows.Forms.Button btn_WorkerOff;
        private System.Windows.Forms.Button btn_WorkerFullOff;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Wc_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}