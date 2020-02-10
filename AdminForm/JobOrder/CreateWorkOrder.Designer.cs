namespace AdminForm
{
    partial class CreateWorkOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuDefaultQty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nuQty = new System.Windows.Forms.NumericUpDown();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtIem = new System.Windows.Forms.TextBox();
            this.txtWorkReqNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPlanEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.nuPlanQty = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpPlanStart = new System.Windows.Forms.DateTimePicker();
            this.cbWorkCenter = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDefaultQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPlanQty)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuDefaultQty);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nuQty);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.txtIem);
            this.groupBox1.Controls.Add(this.txtWorkReqNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nuDefaultQty
            // 
            this.nuDefaultQty.Enabled = false;
            this.nuDefaultQty.Location = new System.Drawing.Point(362, 72);
            this.nuDefaultQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuDefaultQty.Name = "nuDefaultQty";
            this.nuDefaultQty.ReadOnly = true;
            this.nuDefaultQty.Size = new System.Drawing.Size(122, 26);
            this.nuDefaultQty.TabIndex = 31;
            this.nuDefaultQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuDefaultQty.ValueChanged += new System.EventHandler(this.nuDefaultQty_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "잔여 수량";
            // 
            // nuQty
            // 
            this.nuQty.Enabled = false;
            this.nuQty.Location = new System.Drawing.Point(129, 72);
            this.nuQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuQty.Name = "nuQty";
            this.nuQty.ReadOnly = true;
            this.nuQty.Size = new System.Drawing.Size(117, 26);
            this.nuQty.TabIndex = 29;
            this.nuQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(623, 72);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(112, 26);
            this.dtpEndDate.TabIndex = 28;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(362, 28);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(122, 26);
            this.txtClient.TabIndex = 13;
            // 
            // txtIem
            // 
            this.txtIem.Location = new System.Drawing.Point(621, 28);
            this.txtIem.Name = "txtIem";
            this.txtIem.ReadOnly = true;
            this.txtIem.Size = new System.Drawing.Size(114, 26);
            this.txtIem.TabIndex = 9;
            // 
            // txtWorkReqNo
            // 
            this.txtWorkReqNo.Location = new System.Drawing.Point(129, 28);
            this.txtWorkReqNo.Name = "txtWorkReqNo";
            this.txtWorkReqNo.ReadOnly = true;
            this.txtWorkReqNo.Size = new System.Drawing.Size(117, 26);
            this.txtWorkReqNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "거래처명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "생산의뢰 마감일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "의뢰 수량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "품목명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "생사의뢰번호";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpPlanEnd);
            this.groupBox2.Controls.Add(this.dtpEndTime);
            this.groupBox2.Controls.Add(this.dtpStartTime);
            this.groupBox2.Controls.Add(this.nuPlanQty);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.dtpPlanStart);
            this.groupBox2.Controls.Add(this.cbWorkCenter);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(578, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "-";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(-3, -20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "label11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "계획일자";
            // 
            // dtpPlanEnd
            // 
            this.dtpPlanEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpPlanEnd.Enabled = false;
            this.dtpPlanEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPlanEnd.Location = new System.Drawing.Point(450, 70);
            this.dtpPlanEnd.Name = "dtpPlanEnd";
            this.dtpPlanEnd.Size = new System.Drawing.Size(122, 26);
            this.dtpPlanEnd.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(574, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(596, 70);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(109, 26);
            this.dtpEndTime.TabIndex = 26;
            this.dtpEndTime.Value = new System.DateTime(2020, 1, 30, 0, 0, 0, 0);
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(669, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Enabled = false;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(249, 70);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(107, 26);
            this.dtpStartTime.TabIndex = 25;
            this.dtpStartTime.Value = new System.DateTime(2020, 1, 30, 0, 0, 0, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpEndTime_ValueChanged);
            // 
            // nuPlanQty
            // 
            this.nuPlanQty.Location = new System.Drawing.Point(103, 117);
            this.nuPlanQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuPlanQty.Name = "nuPlanQty";
            this.nuPlanQty.Size = new System.Drawing.Size(90, 26);
            this.nuPlanQty.TabIndex = 24;
            this.nuPlanQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "계획수량";
            // 
            // dtpPlanStart
            // 
            this.dtpPlanStart.CustomFormat = "yyyy-MM-dd";
            this.dtpPlanStart.Enabled = false;
            this.dtpPlanStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPlanStart.Location = new System.Drawing.Point(103, 70);
            this.dtpPlanStart.Name = "dtpPlanStart";
            this.dtpPlanStart.Size = new System.Drawing.Size(122, 26);
            this.dtpPlanStart.TabIndex = 13;
            // 
            // cbWorkCenter
            // 
            this.cbWorkCenter.FormattingEnabled = true;
            this.cbWorkCenter.Items.AddRange(new object[] {
            "DYCenter_0001"});
            this.cbWorkCenter.Location = new System.Drawing.Point(102, 27);
            this.cbWorkCenter.Name = "cbWorkCenter";
            this.cbWorkCenter.Size = new System.Drawing.Size(263, 27);
            this.cbWorkCenter.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "일정 조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "계획일자";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "작업장 명";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProcessName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(12, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 28);
            this.panel1.TabIndex = 11;
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProcessName.Location = new System.Drawing.Point(26, 4);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(106, 21);
            this.lblProcessName.TabIndex = 10;
            this.lblProcessName.Text = "소성계획생성";
            // 
            // label12
            // 
            this.label12.Image = global::AdminForm.Properties.Resources.Reading_16x16;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 27);
            this.label12.TabIndex = 9;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(12, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 28);
            this.panel3.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(26, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 21);
            this.label17.TabIndex = 10;
            this.label17.Text = "생산의뢰 정보";
            // 
            // label18
            // 
            this.label18.Image = global::AdminForm.Properties.Resources.Reading_16x16;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(3, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 27);
            this.label18.TabIndex = 9;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 409);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "CreateWorkOrder";
            this.Text = "작업지시 생성";
            this.Load += new System.EventHandler(this.CreateWorkOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDefaultQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPlanQty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWorkReqNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtIem;
        private System.Windows.Forms.ComboBox cbWorkCenter;
        private System.Windows.Forms.NumericUpDown nuPlanQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nuQty;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nuDefaultQty;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker dtpPlanStart;
        public System.Windows.Forms.DateTimePicker dtpStartTime;
        public System.Windows.Forms.DateTimePicker dtpPlanEnd;
        public System.Windows.Forms.DateTimePicker dtpEndTime;
        //   private UserCalendar userCalendar2;
    }
}