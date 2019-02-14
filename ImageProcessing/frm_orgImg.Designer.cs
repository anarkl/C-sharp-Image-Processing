namespace ImageProcessing
{
    partial class frm_orgImg
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
            this.pic_org = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_org
            // 
            this.pic_org.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_org.Location = new System.Drawing.Point(0, 0);
            this.pic_org.Name = "pic_org";
            this.pic_org.Size = new System.Drawing.Size(284, 261);
            this.pic_org.TabIndex = 0;
            this.pic_org.TabStop = false;
            // 
            // frm_orgImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pic_org);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_orgImg";
            this.Text = "Src";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_orgImg_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_org;
    }
}