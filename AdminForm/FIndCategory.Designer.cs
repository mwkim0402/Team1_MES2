namespace AdminForm
{
    partial class FIndCategory
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(3, 3);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.ReadOnly = true;
            this.txtCatCode.Size = new System.Drawing.Size(56, 21);
            this.txtCatCode.TabIndex = 0;
            // 
            // txtCatName
            // 
            this.txtCatName.Enabled = false;
            this.txtCatName.Location = new System.Drawing.Point(96, 3);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(91, 21);
            this.txtCatName.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(62, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(31, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // FIndCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.txtCatCode);
            this.Name = "FIndCategory";
            this.Size = new System.Drawing.Size(190, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Button btnFind;
    }
}
