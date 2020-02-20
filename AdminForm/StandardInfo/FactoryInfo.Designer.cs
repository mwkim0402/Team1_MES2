namespace AdminForm
{
    partial class FactoryInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtWPCode = new System.Windows.Forms.TextBox();
            this.txtWPName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.rbUse = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbProcessCode = new System.Windows.Forms.ComboBox();
            this.fcFactory = new AdminForm.FIndCategory();
            this.txtWPCodeInput = new System.Windows.Forms.TextBox();
            this.cmbPerformUnit = new System.Windows.Forms.ComboBox();
            this.txtWPNameInput = new System.Windows.Forms.TextBox();
            this.cmbWPCategory = new System.Windows.Forms.ComboBox();
            this.cmbPerformCat = new System.Windows.Forms.ComboBox();
            this.txtFactoryNameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbUseTrue = new System.Windows.Forms.RadioButton();
            this.rbUseFalse = new System.Windows.Forms.RadioButton();
            this.gbMoldEquip = new System.Windows.Forms.GroupBox();
            this.rbUse_MoldEq = new System.Windows.Forms.RadioButton();
            this.rbNoUse_MoldEq = new System.Windows.Forms.RadioButton();
            this.gbPalletCreate = new System.Windows.Forms.GroupBox();
            this.rbUse_Pallet = new System.Windows.Forms.RadioButton();
            this.rbNoUse_Pallet = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbMoldEquip.SuspendLayout();
            this.gbPalletCreate.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtWPCode);
            this.panel2.Controls.Add(this.txtWPName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 67);
            this.panel2.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(517, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 38);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtWPCode
            // 
            this.txtWPCode.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtWPCode.Location = new System.Drawing.Point(105, 24);
            this.txtWPCode.Name = "txtWPCode";
            this.txtWPCode.Size = new System.Drawing.Size(141, 26);
            this.txtWPCode.TabIndex = 18;
            // 
            // txtWPName
            // 
            this.txtWPName.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtWPName.Location = new System.Drawing.Point(350, 24);
            this.txtWPName.Name = "txtWPName";
            this.txtWPName.Size = new System.Drawing.Size(141, 26);
            this.txtWPName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label5.Location = new System.Drawing.Point(275, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "작업장명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "작업장코드";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(832, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 64);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용여부";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButton9.Location = new System.Drawing.Point(43, 28);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(42, 20);
            this.radioButton9.TabIndex = 77;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "유";
            this.radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.radioButton10.Location = new System.Drawing.Point(111, 28);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(42, 20);
            this.radioButton10.TabIndex = 79;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "무";
            this.radioButton10.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(419, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 16);
            this.label21.TabIndex = 90;
            this.label21.Text = "비고";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(98, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 16);
            this.label23.TabIndex = 89;
            this.label23.Text = "공정코드";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(176, 13);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(152, 21);
            this.textBox14.TabIndex = 92;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(471, 46);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(337, 21);
            this.textBox12.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1038, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 48);
            this.button1.TabIndex = 99;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(114, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "공정명";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 21);
            this.textBox2.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(387, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "공정그룹";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(471, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 21);
            this.textBox4.TabIndex = 103;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(86, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "조회내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(13, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 180);
            this.panel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.rbUse);
            this.panel6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel6.Location = new System.Drawing.Point(808, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 180);
            this.panel6.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label15.Location = new System.Drawing.Point(8, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 19);
            this.label15.TabIndex = 126;
            this.label15.Text = "비고";
            // 
            // rbUse
            // 
            this.rbUse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbUse.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbUse.Location = new System.Drawing.Point(8, 34);
            this.rbUse.Multiline = true;
            this.rbUse.Name = "rbUse";
            this.rbUse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rbUse.Size = new System.Drawing.Size(186, 141);
            this.rbUse.TabIndex = 143;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.cbProcessCode);
            this.panel3.Controls.Add(this.fcFactory);
            this.panel3.Controls.Add(this.txtWPCodeInput);
            this.panel3.Controls.Add(this.cmbPerformUnit);
            this.panel3.Controls.Add(this.txtWPNameInput);
            this.panel3.Controls.Add(this.cmbWPCategory);
            this.panel3.Controls.Add(this.cmbPerformCat);
            this.panel3.Controls.Add(this.txtFactoryNameInput);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 180);
            this.panel3.TabIndex = 129;
            // 
            // cbProcessCode
            // 
            this.cbProcessCode.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.cbProcessCode.FormattingEnabled = true;
            this.cbProcessCode.Location = new System.Drawing.Point(412, 23);
            this.cbProcessCode.Name = "cbProcessCode";
            this.cbProcessCode.Size = new System.Drawing.Size(166, 27);
            this.cbProcessCode.TabIndex = 143;
            this.cbProcessCode.SelectedIndexChanged += new System.EventHandler(this.cbProcessCode_SelectedIndexChanged);
            // 
            // fcFactory
            // 
            this.fcFactory.Category = AdminForm.CategoryMode.Process;
            this.fcFactory.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.fcFactory.Location = new System.Drawing.Point(-614, -728);
            this.fcFactory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fcFactory.Name = "fcFactory";
            this.fcFactory.SendCode = null;
            this.fcFactory.SendName = null;
            this.fcFactory.Size = new System.Drawing.Size(190, 27);
            this.fcFactory.TabIndex = 21;
            // 
            // txtWPCodeInput
            // 
            this.txtWPCodeInput.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtWPCodeInput.Location = new System.Drawing.Point(108, 64);
            this.txtWPCodeInput.Name = "txtWPCodeInput";
            this.txtWPCodeInput.ReadOnly = true;
            this.txtWPCodeInput.Size = new System.Drawing.Size(154, 26);
            this.txtWPCodeInput.TabIndex = 139;
            // 
            // cmbPerformUnit
            // 
            this.cmbPerformUnit.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.cmbPerformUnit.FormattingEnabled = true;
            this.cmbPerformUnit.Items.AddRange(new object[] {
            "시간당 생산량\t",
            "일간 생산량",
            "주간 생산량",
            "월간 생산량"});
            this.cmbPerformUnit.Location = new System.Drawing.Point(108, 143);
            this.cmbPerformUnit.Name = "cmbPerformUnit";
            this.cmbPerformUnit.Size = new System.Drawing.Size(154, 27);
            this.cmbPerformUnit.TabIndex = 142;
            this.cmbPerformUnit.Text = "시간당 생산량\t";
            // 
            // txtWPNameInput
            // 
            this.txtWPNameInput.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtWPNameInput.Location = new System.Drawing.Point(108, 104);
            this.txtWPNameInput.Name = "txtWPNameInput";
            this.txtWPNameInput.Size = new System.Drawing.Size(154, 26);
            this.txtWPNameInput.TabIndex = 140;
            // 
            // cmbWPCategory
            // 
            this.cmbWPCategory.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.cmbWPCategory.FormattingEnabled = true;
            this.cmbWPCategory.Items.AddRange(new object[] {
            "제선",
            "제강",
            "압연",
            "포장"});
            this.cmbWPCategory.Location = new System.Drawing.Point(108, 26);
            this.cmbWPCategory.Name = "cmbWPCategory";
            this.cmbWPCategory.Size = new System.Drawing.Size(154, 27);
            this.cmbWPCategory.TabIndex = 141;
            this.cmbWPCategory.Text = "제선";
            this.cmbWPCategory.SelectedIndexChanged += new System.EventHandler(this.cmbWPCategory_SelectedIndexChanged);
            // 
            // cmbPerformCat
            // 
            this.cmbPerformCat.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.cmbPerformCat.FormattingEnabled = true;
            this.cmbPerformCat.Items.AddRange(new object[] {
            "임시",
            "임시",
            "임시"});
            this.cmbPerformCat.Location = new System.Drawing.Point(412, 105);
            this.cmbPerformCat.Name = "cmbPerformCat";
            this.cmbPerformCat.Size = new System.Drawing.Size(166, 27);
            this.cmbPerformCat.TabIndex = 137;
            // 
            // txtFactoryNameInput
            // 
            this.txtFactoryNameInput.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.txtFactoryNameInput.Location = new System.Drawing.Point(412, 64);
            this.txtFactoryNameInput.Name = "txtFactoryNameInput";
            this.txtFactoryNameInput.ReadOnly = true;
            this.txtFactoryNameInput.Size = new System.Drawing.Size(166, 26);
            this.txtFactoryNameInput.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label7.Location = new System.Drawing.Point(300, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 129;
            this.label7.Text = "공정 코드";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label8.Location = new System.Drawing.Point(300, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 130;
            this.label8.Text = "공정명";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label14.Location = new System.Drawing.Point(300, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 19);
            this.label14.TabIndex = 132;
            this.label14.Text = "실적등록 유형";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label16.Location = new System.Drawing.Point(4, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 19);
            this.label16.TabIndex = 124;
            this.label16.Text = "실적 단위";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 101;
            this.label10.Text = "작업장코드";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label11.Location = new System.Drawing.Point(4, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 104;
            this.label11.Text = "작업장 유형";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.label9.Location = new System.Drawing.Point(4, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 103;
            this.label9.Text = "작업장명";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.gbMoldEquip);
            this.panel5.Controls.Add(this.gbPalletCreate);
            this.panel5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Location = new System.Drawing.Point(596, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 240);
            this.panel5.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbUseTrue);
            this.groupBox2.Controls.Add(this.rbUseFalse);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.groupBox2.Location = new System.Drawing.Point(14, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 47);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용 유무";
            // 
            // rbUseTrue
            // 
            this.rbUseTrue.AutoSize = true;
            this.rbUseTrue.BackColor = System.Drawing.Color.Transparent;
            this.rbUseTrue.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbUseTrue.Location = new System.Drawing.Point(48, 20);
            this.rbUseTrue.Name = "rbUseTrue";
            this.rbUseTrue.Size = new System.Drawing.Size(42, 23);
            this.rbUseTrue.TabIndex = 77;
            this.rbUseTrue.Text = "유";
            this.rbUseTrue.UseVisualStyleBackColor = false;
            // 
            // rbUseFalse
            // 
            this.rbUseFalse.AutoSize = true;
            this.rbUseFalse.BackColor = System.Drawing.Color.Transparent;
            this.rbUseFalse.Checked = true;
            this.rbUseFalse.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbUseFalse.Location = new System.Drawing.Point(116, 20);
            this.rbUseFalse.Name = "rbUseFalse";
            this.rbUseFalse.Size = new System.Drawing.Size(42, 23);
            this.rbUseFalse.TabIndex = 79;
            this.rbUseFalse.TabStop = true;
            this.rbUseFalse.Text = "무";
            this.rbUseFalse.UseVisualStyleBackColor = false;
            // 
            // gbMoldEquip
            // 
            this.gbMoldEquip.Controls.Add(this.rbUse_MoldEq);
            this.gbMoldEquip.Controls.Add(this.rbNoUse_MoldEq);
            this.gbMoldEquip.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gbMoldEquip.Location = new System.Drawing.Point(14, 8);
            this.gbMoldEquip.Name = "gbMoldEquip";
            this.gbMoldEquip.Size = new System.Drawing.Size(170, 49);
            this.gbMoldEquip.TabIndex = 107;
            this.gbMoldEquip.TabStop = false;
            this.gbMoldEquip.Text = "금형 장착 여부";
            // 
            // rbUse_MoldEq
            // 
            this.rbUse_MoldEq.AutoSize = true;
            this.rbUse_MoldEq.BackColor = System.Drawing.Color.Transparent;
            this.rbUse_MoldEq.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbUse_MoldEq.Location = new System.Drawing.Point(48, 20);
            this.rbUse_MoldEq.Name = "rbUse_MoldEq";
            this.rbUse_MoldEq.Size = new System.Drawing.Size(42, 23);
            this.rbUse_MoldEq.TabIndex = 77;
            this.rbUse_MoldEq.Text = "유";
            this.rbUse_MoldEq.UseVisualStyleBackColor = false;
            // 
            // rbNoUse_MoldEq
            // 
            this.rbNoUse_MoldEq.AutoSize = true;
            this.rbNoUse_MoldEq.BackColor = System.Drawing.Color.Transparent;
            this.rbNoUse_MoldEq.Checked = true;
            this.rbNoUse_MoldEq.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbNoUse_MoldEq.Location = new System.Drawing.Point(116, 20);
            this.rbNoUse_MoldEq.Name = "rbNoUse_MoldEq";
            this.rbNoUse_MoldEq.Size = new System.Drawing.Size(42, 23);
            this.rbNoUse_MoldEq.TabIndex = 79;
            this.rbNoUse_MoldEq.TabStop = true;
            this.rbNoUse_MoldEq.Text = "무";
            this.rbNoUse_MoldEq.UseVisualStyleBackColor = false;
            // 
            // gbPalletCreate
            // 
            this.gbPalletCreate.Controls.Add(this.rbUse_Pallet);
            this.gbPalletCreate.Controls.Add(this.rbNoUse_Pallet);
            this.gbPalletCreate.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gbPalletCreate.Location = new System.Drawing.Point(14, 70);
            this.gbPalletCreate.Name = "gbPalletCreate";
            this.gbPalletCreate.Size = new System.Drawing.Size(170, 47);
            this.gbPalletCreate.TabIndex = 106;
            this.gbPalletCreate.TabStop = false;
            this.gbPalletCreate.Text = "팔레트 생성 유무";
            // 
            // rbUse_Pallet
            // 
            this.rbUse_Pallet.AutoSize = true;
            this.rbUse_Pallet.BackColor = System.Drawing.Color.Transparent;
            this.rbUse_Pallet.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbUse_Pallet.Location = new System.Drawing.Point(48, 20);
            this.rbUse_Pallet.Name = "rbUse_Pallet";
            this.rbUse_Pallet.Size = new System.Drawing.Size(42, 23);
            this.rbUse_Pallet.TabIndex = 77;
            this.rbUse_Pallet.Text = "유";
            this.rbUse_Pallet.UseVisualStyleBackColor = false;
            // 
            // rbNoUse_Pallet
            // 
            this.rbNoUse_Pallet.AutoSize = true;
            this.rbNoUse_Pallet.BackColor = System.Drawing.Color.Transparent;
            this.rbNoUse_Pallet.Checked = true;
            this.rbNoUse_Pallet.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.rbNoUse_Pallet.Location = new System.Drawing.Point(116, 20);
            this.rbNoUse_Pallet.Name = "rbNoUse_Pallet";
            this.rbNoUse_Pallet.Size = new System.Drawing.Size(42, 23);
            this.rbNoUse_Pallet.TabIndex = 79;
            this.rbNoUse_Pallet.TabStop = true;
            this.rbNoUse_Pallet.Text = "무";
            this.rbNoUse_Pallet.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1008, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 180);
            this.panel4.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 167);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl4.Location = new System.Drawing.Point(16, 85);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(94, 28);
            this.tabControl4.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(86, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "조회내역";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 448);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(94, 28);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(86, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "입력정보";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 317);
            this.dataGridView1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FactoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FactoryInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FactoryInfo";
            this.Activated += new System.EventHandler(this.FactoryInfo_Activated);
            this.Deactivate += new System.EventHandler(this.FactoryInfo_Deactivate);
            this.Load += new System.EventHandler(this.FactoryInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbMoldEquip.ResumeLayout(false);
            this.gbMoldEquip.PerformLayout();
            this.gbPalletCreate.ResumeLayout(false);
            this.gbPalletCreate.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtWPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtWPCode;
        private System.Windows.Forms.TabPage tabPage3;
        protected System.Windows.Forms.Panel panel1;
        private FIndCategory fcFactory;
        private System.Windows.Forms.GroupBox gbPalletCreate;
        private System.Windows.Forms.RadioButton rbUse_Pallet;
        private System.Windows.Forms.RadioButton rbNoUse_Pallet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbMoldEquip;
        private System.Windows.Forms.RadioButton rbUse_MoldEq;
        private System.Windows.Forms.RadioButton rbNoUse_MoldEq;
        protected System.Windows.Forms.TabControl tabControl4;
        protected System.Windows.Forms.TabPage tabPage4;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtWPCodeInput;
        private System.Windows.Forms.TextBox rbUse;
        private System.Windows.Forms.ComboBox cmbPerformUnit;
        private System.Windows.Forms.TextBox txtWPNameInput;
        private System.Windows.Forms.ComboBox cmbWPCategory;
        private System.Windows.Forms.ComboBox cmbPerformCat;
        private System.Windows.Forms.TextBox txtFactoryNameInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbProcessCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbUseTrue;
        private System.Windows.Forms.RadioButton rbUseFalse;
    }
}