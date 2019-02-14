namespace ImageProcessing
{
    partial class frm_Filtering
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
            this.btn_Smoothing = new System.Windows.Forms.Button();
            this.btn_Median = new System.Windows.Forms.Button();
            this.btn_Gaussian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_noise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Smoothing
            // 
            this.btn_Smoothing.Location = new System.Drawing.Point(12, 12);
            this.btn_Smoothing.Name = "btn_Smoothing";
            this.btn_Smoothing.Size = new System.Drawing.Size(75, 23);
            this.btn_Smoothing.TabIndex = 0;
            this.btn_Smoothing.Text = "Smoothing";
            this.btn_Smoothing.UseVisualStyleBackColor = true;
            this.btn_Smoothing.Click += new System.EventHandler(this.btn_Smoothing_Click);
            // 
            // btn_Median
            // 
            this.btn_Median.Location = new System.Drawing.Point(12, 41);
            this.btn_Median.Name = "btn_Median";
            this.btn_Median.Size = new System.Drawing.Size(75, 23);
            this.btn_Median.TabIndex = 1;
            this.btn_Median.Text = "Median";
            this.btn_Median.UseVisualStyleBackColor = true;
            this.btn_Median.Click += new System.EventHandler(this.btn_Median_Click);
            // 
            // btn_Gaussian
            // 
            this.btn_Gaussian.Location = new System.Drawing.Point(12, 70);
            this.btn_Gaussian.Name = "btn_Gaussian";
            this.btn_Gaussian.Size = new System.Drawing.Size(75, 23);
            this.btn_Gaussian.TabIndex = 2;
            this.btn_Gaussian.Text = "Gaussian";
            this.btn_Gaussian.UseVisualStyleBackColor = true;
            this.btn_Gaussian.Click += new System.EventHandler(this.btn_Gaussian_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(85, 157);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(45, 12);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = "Waiting";
            // 
            // btn_noise
            // 
            this.btn_noise.Location = new System.Drawing.Point(93, 12);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(75, 23);
            this.btn_noise.TabIndex = 5;
            this.btn_noise.Text = "Noise";
            this.btn_noise.UseVisualStyleBackColor = true;
            this.btn_noise.Click += new System.EventHandler(this.btn_noise_Click);
            // 
            // frm_Filtering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_noise);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gaussian);
            this.Controls.Add(this.btn_Median);
            this.Controls.Add(this.btn_Smoothing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Filtering";
            this.Text = "frm_Filtering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Smoothing;
        private System.Windows.Forms.Button btn_Median;
        private System.Windows.Forms.Button btn_Gaussian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_noise;
    }
}