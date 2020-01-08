namespace AdminForm
{
    partial class ProcessInfo : dgvOneWithInput
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
            this.txtFacCode = new System.Windows.Forms.TextBox();
            this.cmbUsable = new System.Windows.Forms.ComboBox();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUsable = new System.Windows.Forms.GroupBox();
            this.rbUse = new System.Windows.Forms.RadioButton();
            this.rbNoUse = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFacCodeInput = new System.Windows.Forms.TextBox();
            this.txtPS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFacGroupInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbUsable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFacGroupInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFacNameInput);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.gbUsable);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtPS);
            this.panel1.Controls.Add(this.txtFacCodeInput);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtFacCode);
            this.panel2.Controls.Add(this.cmbUsable);
            this.panel2.Controls.Add(this.txtFacName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 67);
            this.panel2.TabIndex = 4;
            // 
            // txtFacCode
            // 
            this.txtFacCode.Location = new System.Drawing.Point(108, 26);
            this.txtFacCode.Name = "txtFacCode";
            this.txtFacCode.Size = new System.Drawing.Size(141, 21);
            this.txtFacCode.TabIndex = 18;
            // 
            // cmbUsable
            // 
            this.cmbUsable.FormattingEnabled = true;
            this.cmbUsable.Location = new System.Drawing.Point(622, 29);
            this.cmbUsable.Name = "cmbUsable";
            this.cmbUsable.Size = new System.Drawing.Size(121, 20);
            this.cmbUsable.TabIndex = 17;
            // 
            // txtFacName
            // 
            this.txtFacName.Location = new System.Drawing.Point(349, 27);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.Size = new System.Drawing.Size(141, 21);
            this.txtFacName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(274, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "공정명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(534, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "사용여부";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "공정코드";
            // 
            // gbUsable
            // 
            this.gbUsable.Controls.Add(this.rbUse);
            this.gbUsable.Controls.Add(this.rbNoUse);
            this.gbUsable.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbUsable.Location = new System.Drawing.Point(832, 10);
            this.gbUsable.Name = "gbUsable";
            this.gbUsable.Size = new System.Drawing.Size(200, 64);
            this.gbUsable.TabIndex = 96;
            this.gbUsable.TabStop = false;
            this.gbUsable.Text = "사용여부";
            // 
            // rbUse
            // 
            this.rbUse.AutoSize = true;
            this.rbUse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbUse.Location = new System.Drawing.Point(43, 28);
            this.rbUse.Name = "rbUse";
            this.rbUse.Size = new System.Drawing.Size(42, 20);
            this.rbUse.TabIndex = 77;
            this.rbUse.TabStop = true;
            this.rbUse.Text = "유";
            this.rbUse.UseVisualStyleBackColor = false;
            // 
            // rbNoUse
            // 
            this.rbNoUse.AutoSize = true;
            this.rbNoUse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rbNoUse.Location = new System.Drawing.Point(111, 28);
            this.rbNoUse.Name = "rbNoUse";
            this.rbNoUse.Size = new System.Drawing.Size(42, 20);
            this.rbNoUse.TabIndex = 79;
            this.rbNoUse.TabStop = true;
            this.rbNoUse.Text = "무";
            this.rbNoUse.UseVisualStyleBackColor = false;
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
            // txtFacCodeInput
            // 
            this.txtFacCodeInput.Location = new System.Drawing.Point(176, 13);
            this.txtFacCodeInput.Name = "txtFacCodeInput";
            this.txtFacCodeInput.Size = new System.Drawing.Size(152, 21);
            this.txtFacCodeInput.TabIndex = 92;
            // 
            // txtPS
            // 
            this.txtPS.Location = new System.Drawing.Point(471, 46);
            this.txtPS.Name = "txtPS";
            this.txtPS.Size = new System.Drawing.Size(337, 21);
            this.txtPS.TabIndex = 94;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1038, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 48);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // txtFacNameInput
            // 
            this.txtFacNameInput.Location = new System.Drawing.Point(176, 45);
            this.txtFacNameInput.Name = "txtFacNameInput";
            this.txtFacNameInput.Size = new System.Drawing.Size(152, 21);
            this.txtFacNameInput.TabIndex = 101;
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
            // txtFacGroupInput
            // 
            this.txtFacGroupInput.Location = new System.Drawing.Point(471, 17);
            this.txtFacGroupInput.Name = "txtFacGroupInput";
            this.txtFacGroupInput.Size = new System.Drawing.Size(152, 21);
            this.txtFacGroupInput.TabIndex = 103;
            // 
            // ProcessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 604);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ProcessInfo";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.tabControl2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbUsable.ResumeLayout(false);
            this.gbUsable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsable;
        private System.Windows.Forms.GroupBox gbUsable;
        private System.Windows.Forms.RadioButton rbUse;
        private System.Windows.Forms.RadioButton rbNoUse;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPS;
        private System.Windows.Forms.TextBox txtFacCodeInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFacGroupInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacNameInput;
        private System.Windows.Forms.TextBox txtFacCode;
    }
}