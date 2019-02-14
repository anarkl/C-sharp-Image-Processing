namespace ImageProcessing
{
    partial class frm_ColorModif
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
            this.txt_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.btn_multply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.chk_Gray = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(93, 12);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(100, 21);
            this.txt_C.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Constant";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 54);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "+Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.Location = new System.Drawing.Point(93, 54);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(75, 23);
            this.btn_Subtract.TabIndex = 3;
            this.btn_Subtract.Text = "-Subtract";
            this.btn_Subtract.UseVisualStyleBackColor = true;
            this.btn_Subtract.Click += new System.EventHandler(this.btn_Subtract_Click);
            // 
            // btn_multply
            // 
            this.btn_multply.Location = new System.Drawing.Point(12, 83);
            this.btn_multply.Name = "btn_multply";
            this.btn_multply.Size = new System.Drawing.Size(75, 23);
            this.btn_multply.TabIndex = 4;
            this.btn_multply.Text = "*Multiply";
            this.btn_multply.UseVisualStyleBackColor = true;
            this.btn_multply.Click += new System.EventHandler(this.btn_multply_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(93, 83);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 5;
            this.btn_divide.Text = "/Divide";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // chk_Gray
            // 
            this.chk_Gray.AutoSize = true;
            this.chk_Gray.Checked = true;
            this.chk_Gray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Gray.Location = new System.Drawing.Point(174, 58);
            this.chk_Gray.Name = "chk_Gray";
            this.chk_Gray.Size = new System.Drawing.Size(57, 16);
            this.chk_Gray.TabIndex = 6;
            this.chk_Gray.Text = "Gray?";
            this.chk_Gray.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(91, 144);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(45, 12);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "Waiting";
            // 
            // frm_ColorModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_Gray);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multply);
            this.Controls.Add(this.btn_Subtract);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_C);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ColorModif";
            this.Text = "Color Modification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ColorModif_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.Button btn_multply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.CheckBox chk_Gray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Status;
    }
}