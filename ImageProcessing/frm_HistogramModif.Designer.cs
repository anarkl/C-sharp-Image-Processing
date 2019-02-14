namespace ImageProcessing
{
    partial class frm_HistogramModif
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
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_Endin = new System.Windows.Forms.Button();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Equal
            // 
            this.btn_Equal.Location = new System.Drawing.Point(14, 41);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(84, 23);
            this.btn_Equal.TabIndex = 0;
            this.btn_Equal.Text = "Equalization";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // btn_Endin
            // 
            this.btn_Endin.Location = new System.Drawing.Point(14, 12);
            this.btn_Endin.Name = "btn_Endin";
            this.btn_Endin.Size = new System.Drawing.Size(102, 23);
            this.btn_Endin.TabIndex = 1;
            this.btn_Endin.Text = "End-In-Search";
            this.btn_Endin.UseVisualStyleBackColor = true;
            this.btn_Endin.Click += new System.EventHandler(this.btn_Endin_Click);
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(172, 138);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(100, 21);
            this.txt_min.TabIndex = 2;
            this.txt_min.Text = "3";
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(172, 165);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(100, 21);
            this.txt_max.TabIndex = 3;
            this.txt_max.Text = "3";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(128, 147);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(40, 12);
            this.min.TabIndex = 4;
            this.min.Text = "min %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "max %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(88, 217);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(54, 12);
            this.lbl_Status.TabIndex = 7;
            this.lbl_Status.Text = "Wating...";
            // 
            // frm_HistogramModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.min);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.btn_Endin);
            this.Controls.Add(this.btn_Equal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_HistogramModif";
            this.Text = "Histogram Modification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_HistogramModif_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button btn_Endin;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Status;
    }
}