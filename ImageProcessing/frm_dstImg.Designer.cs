namespace ImageProcessing
{
    partial class frm_dstImg
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
            this.pic_dst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dst)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_dst
            // 
            this.pic_dst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_dst.Location = new System.Drawing.Point(0, 0);
            this.pic_dst.Name = "pic_dst";
            this.pic_dst.Size = new System.Drawing.Size(284, 261);
            this.pic_dst.TabIndex = 0;
            this.pic_dst.TabStop = false;
            // 
            // frm_dstImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pic_dst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_dstImg";
            this.Text = "Dst";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_dstImg_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_dst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_dst;
    }
}