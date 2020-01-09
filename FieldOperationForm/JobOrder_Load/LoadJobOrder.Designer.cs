namespace FieldOperationForm
{
    partial class LoadJobOrder
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
            this.btn_JobOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_PlannedQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WorkerDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_WorkPlace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Process = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Item = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_SearchTruck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_JobOrder
            // 
            this.btn_JobOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_JobOrder.BackColor = System.Drawing.Color.Ivory;
            this.btn_JobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JobOrder.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_JobOrder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_JobOrder.Location = new System.Drawing.Point(910, 459);
            this.btn_JobOrder.Name = "btn_JobOrder";
            this.btn_JobOrder.Size = new System.Drawing.Size(621, 157);
            this.btn_JobOrder.TabIndex = 20;
            this.btn_JobOrder.Text = "작업지시 생성";
            this.btn_JobOrder.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_PlannedQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_WorkerDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_WorkPlace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Process);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Item);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(910, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 448);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txt_PlannedQuantity
            // 
            this.txt_PlannedQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PlannedQuantity.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_PlannedQuantity.Location = new System.Drawing.Point(210, 377);
            this.txt_PlannedQuantity.Multiline = true;
            this.txt_PlannedQuantity.Name = "txt_PlannedQuantity";
            this.txt_PlannedQuantity.Size = new System.Drawing.Size(368, 41);
            this.txt_PlannedQuantity.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(41, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "계획수량";
            // 
            // txt_WorkerDate
            // 
            this.txt_WorkerDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_WorkerDate.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_WorkerDate.Location = new System.Drawing.Point(210, 290);
            this.txt_WorkerDate.Multiline = true;
            this.txt_WorkerDate.Name = "txt_WorkerDate";
            this.txt_WorkerDate.Size = new System.Drawing.Size(368, 41);
            this.txt_WorkerDate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(41, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "작업지시일";
            // 
            // cb_WorkPlace
            // 
            this.cb_WorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_WorkPlace.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_WorkPlace.FormattingEnabled = true;
            this.cb_WorkPlace.Location = new System.Drawing.Point(210, 205);
            this.cb_WorkPlace.Name = "cb_WorkPlace";
            this.cb_WorkPlace.Size = new System.Drawing.Size(368, 39);
            this.cb_WorkPlace.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(41, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "작업장";
            // 
            // cb_Process
            // 
            this.cb_Process.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Process.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Process.FormattingEnabled = true;
            this.cb_Process.Location = new System.Drawing.Point(210, 120);
            this.cb_Process.Name = "cb_Process";
            this.cb_Process.Size = new System.Drawing.Size(368, 39);
            this.cb_Process.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(41, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "공정";
            // 
            // cb_Item
            // 
            this.cb_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Item.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Item.FormattingEnabled = true;
            this.cb_Item.Location = new System.Drawing.Point(210, 35);
            this.cb_Item.Name = "cb_Item";
            this.cb_Item.Size = new System.Drawing.Size(368, 39);
            this.cb_Item.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(41, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "품목";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.Ivory;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Search.Location = new System.Drawing.Point(781, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 41);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "찾기";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(892, 548);
            this.dataGridView1.TabIndex = 27;
            // 
            // txt_SearchTruck
            // 
            this.txt_SearchTruck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SearchTruck.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_SearchTruck.Location = new System.Drawing.Point(229, 12);
            this.txt_SearchTruck.Multiline = true;
            this.txt_SearchTruck.Name = "txt_SearchTruck";
            this.txt_SearchTruck.Size = new System.Drawing.Size(546, 41);
            this.txt_SearchTruck.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 41);
            this.label7.TabIndex = 26;
            this.label7.Text = "대차 검색";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadJobOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1538, 628);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_SearchTruck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_JobOrder);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadJobOrder";
            this.Text = "LoadJobOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_JobOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_PlannedQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_WorkerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_WorkPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Item;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_SearchTruck;
        private System.Windows.Forms.Label label7;
    }
}