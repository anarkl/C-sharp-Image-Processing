namespace ImageProcessing
{
    partial class frm_EdgeDetection
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
            this.btn_Sobel = new System.Windows.Forms.Button();
            this.btn_prewitt = new System.Windows.Forms.Button();
            this.btn_Roberts = new System.Windows.Forms.Button();
            this.btn_Laplacian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.rad_4dir = new System.Windows.Forms.RadioButton();
            this.rad_8dir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sobel
            // 
            this.btn_Sobel.Location = new System.Drawing.Point(12, 12);
            this.btn_Sobel.Name = "btn_Sobel";
            this.btn_Sobel.Size = new System.Drawing.Size(75, 23);
            this.btn_Sobel.TabIndex = 0;
            this.btn_Sobel.Text = "Sobel";
            this.btn_Sobel.UseVisualStyleBackColor = true;
            this.btn_Sobel.Click += new System.EventHandler(this.btn_Sobel_Click);
            // 
            // btn_prewitt
            // 
            this.btn_prewitt.Location = new System.Drawing.Point(93, 12);
            this.btn_prewitt.Name = "btn_prewitt";
            this.btn_prewitt.Size = new System.Drawing.Size(75, 23);
            this.btn_prewitt.TabIndex = 1;
            this.btn_prewitt.Text = "Prewitt";
            this.btn_prewitt.UseVisualStyleBackColor = true;
            this.btn_prewitt.Click += new System.EventHandler(this.btn_prewitt_Click);
            // 
            // btn_Roberts
            // 
            this.btn_Roberts.Location = new System.Drawing.Point(12, 41);
            this.btn_Roberts.Name = "btn_Roberts";
            this.btn_Roberts.Size = new System.Drawing.Size(75, 23);
            this.btn_Roberts.TabIndex = 2;
            this.btn_Roberts.Text = "Roberts";
            this.btn_Roberts.UseVisualStyleBackColor = true;
            this.btn_Roberts.Click += new System.EventHandler(this.btn_Roberts_Click);
            // 
            // btn_Laplacian
            // 
            this.btn_Laplacian.Location = new System.Drawing.Point(93, 41);
            this.btn_Laplacian.Name = "btn_Laplacian";
            this.btn_Laplacian.Size = new System.Drawing.Size(75, 23);
            this.btn_Laplacian.TabIndex = 3;
            this.btn_Laplacian.Text = "Laplacian";
            this.btn_Laplacian.UseVisualStyleBackColor = true;
            this.btn_Laplacian.Click += new System.EventHandler(this.btn_Laplacian_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(78, 169);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(57, 12);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "Waiting...";
            // 
            // rad_4dir
            // 
            this.rad_4dir.AutoSize = true;
            this.rad_4dir.Checked = true;
            this.rad_4dir.Location = new System.Drawing.Point(6, 24);
            this.rad_4dir.Name = "rad_4dir";
            this.rad_4dir.Size = new System.Drawing.Size(81, 16);
            this.rad_4dir.TabIndex = 6;
            this.rad_4dir.TabStop = true;
            this.rad_4dir.Text = "4 direction";
            this.rad_4dir.UseVisualStyleBackColor = true;
            // 
            // rad_8dir
            // 
            this.rad_8dir.AutoSize = true;
            this.rad_8dir.Location = new System.Drawing.Point(6, 46);
            this.rad_8dir.Name = "rad_8dir";
            this.rad_8dir.Size = new System.Drawing.Size(81, 16);
            this.rad_8dir.TabIndex = 7;
            this.rad_8dir.Text = "8 direction";
            this.rad_8dir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_4dir);
            this.groupBox1.Controls.Add(this.rad_8dir);
            this.groupBox1.Location = new System.Drawing.Point(187, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laplacian Mask";
            // 
            // frm_EdgeDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Laplacian);
            this.Controls.Add(this.btn_Roberts);
            this.Controls.Add(this.btn_prewitt);
            this.Controls.Add(this.btn_Sobel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_EdgeDetection";
            this.Text = "Edge Detection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_EdgeDetection_FormClosed);
            this.Load += new System.EventHandler(this.frm_EdgeDetection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sobel;
        private System.Windows.Forms.Button btn_prewitt;
        private System.Windows.Forms.Button btn_Roberts;
        private System.Windows.Forms.Button btn_Laplacian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.RadioButton rad_4dir;
        private System.Windows.Forms.RadioButton rad_8dir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}