namespace AdminForm
{
    partial class ViewFaultyImage
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
            this.picFaulty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFaulty)).BeginInit();
            this.SuspendLayout();
            // 
            // picFaulty
            // 
            this.picFaulty.Location = new System.Drawing.Point(12, 12);
            this.picFaulty.Name = "picFaulty";
            this.picFaulty.Size = new System.Drawing.Size(355, 331);
            this.picFaulty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFaulty.TabIndex = 0;
            this.picFaulty.TabStop = false;
            // 
            // ViewFaultyImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 355);
            this.Controls.Add(this.picFaulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewFaultyImage";
            this.Text = "사진 보기";
            this.Load += new System.EventHandler(this.ViewFaultyImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFaulty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFaulty;
    }
}