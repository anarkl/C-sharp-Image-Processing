namespace ImageProcessing
{
    partial class frm_Morphology
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
            this.btn_Erosion = new System.Windows.Forms.Button();
            this.btn_Dilation = new System.Windows.Forms.Button();
            this.btn_Opening = new System.Windows.Forms.Button();
            this.btn_Closing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Erosion
            // 
            this.btn_Erosion.Location = new System.Drawing.Point(12, 12);
            this.btn_Erosion.Name = "btn_Erosion";
            this.btn_Erosion.Size = new System.Drawing.Size(75, 23);
            this.btn_Erosion.TabIndex = 0;
            this.btn_Erosion.Text = "Erosion";
            this.btn_Erosion.UseVisualStyleBackColor = true;
            this.btn_Erosion.Click += new System.EventHandler(this.btn_Erosion_Click);
            // 
            // btn_Dilation
            // 
            this.btn_Dilation.Location = new System.Drawing.Point(93, 12);
            this.btn_Dilation.Name = "btn_Dilation";
            this.btn_Dilation.Size = new System.Drawing.Size(75, 23);
            this.btn_Dilation.TabIndex = 1;
            this.btn_Dilation.Text = "Dilation";
            this.btn_Dilation.UseVisualStyleBackColor = true;
            this.btn_Dilation.Click += new System.EventHandler(this.btn_Dilation_Click);
            // 
            // btn_Opening
            // 
            this.btn_Opening.Location = new System.Drawing.Point(12, 41);
            this.btn_Opening.Name = "btn_Opening";
            this.btn_Opening.Size = new System.Drawing.Size(75, 23);
            this.btn_Opening.TabIndex = 2;
            this.btn_Opening.Text = "Opening";
            this.btn_Opening.UseVisualStyleBackColor = true;
            this.btn_Opening.Click += new System.EventHandler(this.btn_Opening_Click);
            // 
            // btn_Closing
            // 
            this.btn_Closing.Location = new System.Drawing.Point(93, 41);
            this.btn_Closing.Name = "btn_Closing";
            this.btn_Closing.Size = new System.Drawing.Size(75, 23);
            this.btn_Closing.TabIndex = 3;
            this.btn_Closing.Text = "Closing";
            this.btn_Closing.UseVisualStyleBackColor = true;
            this.btn_Closing.Click += new System.EventHandler(this.btn_Closing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(91, 99);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(57, 12);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "Waiting...";
            // 
            // frm_Morphology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Closing);
            this.Controls.Add(this.btn_Opening);
            this.Controls.Add(this.btn_Dilation);
            this.Controls.Add(this.btn_Erosion);
            this.Name = "frm_Morphology";
            this.Text = "frm_Morphology";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Erosion;
        private System.Windows.Forms.Button btn_Dilation;
        private System.Windows.Forms.Button btn_Opening;
        private System.Windows.Forms.Button btn_Closing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
    }
}