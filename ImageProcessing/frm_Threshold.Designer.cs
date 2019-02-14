namespace ImageProcessing
{
    partial class frm_Threshold
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
            this.hsc_Threshold = new System.Windows.Forms.HScrollBar();
            this.txt_Threshold = new System.Windows.Forms.TextBox();
            this.btn_Binary = new System.Windows.Forms.Button();
            this.rad_threshold = new System.Windows.Forms.RadioButton();
            this.rad_otsu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hsc_Threshold
            // 
            this.hsc_Threshold.Location = new System.Drawing.Point(24, 32);
            this.hsc_Threshold.Maximum = 255;
            this.hsc_Threshold.Name = "hsc_Threshold";
            this.hsc_Threshold.Size = new System.Drawing.Size(283, 17);
            this.hsc_Threshold.TabIndex = 0;
            this.hsc_Threshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsc_Threshold_Scroll);
            // 
            // txt_Threshold
            // 
            this.txt_Threshold.Location = new System.Drawing.Point(162, 58);
            this.txt_Threshold.Name = "txt_Threshold";
            this.txt_Threshold.Size = new System.Drawing.Size(100, 21);
            this.txt_Threshold.TabIndex = 1;
            this.txt_Threshold.Text = "0";
            // 
            // btn_Binary
            // 
            this.btn_Binary.Location = new System.Drawing.Point(162, 148);
            this.btn_Binary.Name = "btn_Binary";
            this.btn_Binary.Size = new System.Drawing.Size(75, 23);
            this.btn_Binary.TabIndex = 2;
            this.btn_Binary.Text = "Binary";
            this.btn_Binary.UseVisualStyleBackColor = true;
            this.btn_Binary.Click += new System.EventHandler(this.btn_Binary_Click);
            // 
            // rad_threshold
            // 
            this.rad_threshold.AutoSize = true;
            this.rad_threshold.Checked = true;
            this.rad_threshold.Location = new System.Drawing.Point(6, 20);
            this.rad_threshold.Name = "rad_threshold";
            this.rad_threshold.Size = new System.Drawing.Size(90, 16);
            this.rad_threshold.TabIndex = 3;
            this.rad_threshold.TabStop = true;
            this.rad_threshold.Text = "Tresholding";
            this.rad_threshold.UseVisualStyleBackColor = true;
            // 
            // rad_otsu
            // 
            this.rad_otsu.AutoSize = true;
            this.rad_otsu.Location = new System.Drawing.Point(6, 42);
            this.rad_otsu.Name = "rad_otsu";
            this.rad_otsu.Size = new System.Drawing.Size(106, 16);
            this.rad_otsu.TabIndex = 4;
            this.rad_otsu.Text = "Otsu\'s Method";
            this.rad_otsu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_otsu);
            this.groupBox1.Controls.Add(this.rad_threshold);
            this.groupBox1.Location = new System.Drawing.Point(24, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(96, 192);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(57, 12);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "Waiting...";
            // 
            // frm_Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 229);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Binary);
            this.Controls.Add(this.txt_Threshold);
            this.Controls.Add(this.hsc_Threshold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Threshold";
            this.Text = "Binary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Threshold_FormClosed);
            this.Load += new System.EventHandler(this.frm_Threshold_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsc_Threshold;
        private System.Windows.Forms.TextBox txt_Threshold;
        private System.Windows.Forms.Button btn_Binary;
        private System.Windows.Forms.RadioButton rad_threshold;
        private System.Windows.Forms.RadioButton rad_otsu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Status;
    }
}