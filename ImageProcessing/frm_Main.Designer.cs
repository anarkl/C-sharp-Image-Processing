namespace ImageProcessing
{
    partial class frm_Main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiedHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorModificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramModificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_org = new System.Windows.Forms.PictureBox();
            this.pic_dst = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Gray = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dst)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.imageProcessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalImageToolStripMenuItem,
            this.modifiedImageToolStripMenuItem,
            this.originalHistogramToolStripMenuItem,
            this.modifiedHistogramToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // originalImageToolStripMenuItem
            // 
            this.originalImageToolStripMenuItem.Name = "originalImageToolStripMenuItem";
            this.originalImageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.originalImageToolStripMenuItem.Text = "Original Image";
            this.originalImageToolStripMenuItem.Click += new System.EventHandler(this.originalImageToolStripMenuItem_Click);
            // 
            // modifiedImageToolStripMenuItem
            // 
            this.modifiedImageToolStripMenuItem.Name = "modifiedImageToolStripMenuItem";
            this.modifiedImageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modifiedImageToolStripMenuItem.Text = "Modified Image";
            this.modifiedImageToolStripMenuItem.Click += new System.EventHandler(this.modifiedImageToolStripMenuItem_Click);
            // 
            // originalHistogramToolStripMenuItem
            // 
            this.originalHistogramToolStripMenuItem.Name = "originalHistogramToolStripMenuItem";
            this.originalHistogramToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.originalHistogramToolStripMenuItem.Text = "Original Histogram";
            this.originalHistogramToolStripMenuItem.Click += new System.EventHandler(this.originalHistogramToolStripMenuItem_Click);
            // 
            // modifiedHistogramToolStripMenuItem
            // 
            this.modifiedHistogramToolStripMenuItem.Name = "modifiedHistogramToolStripMenuItem";
            this.modifiedHistogramToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modifiedHistogramToolStripMenuItem.Text = "Modified Histogram";
            this.modifiedHistogramToolStripMenuItem.Click += new System.EventHandler(this.modifiedHistogramToolStripMenuItem_Click);
            // 
            // imageProcessToolStripMenuItem
            // 
            this.imageProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.colorModificationToolStripMenuItem,
            this.histogramModificationToolStripMenuItem,
            this.filteringToolStripMenuItem,
            this.morphologyToolStripMenuItem});
            this.imageProcessToolStripMenuItem.Enabled = false;
            this.imageProcessToolStripMenuItem.Name = "imageProcessToolStripMenuItem";
            this.imageProcessToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.imageProcessToolStripMenuItem.Text = "Image Process";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            this.edgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionToolStripMenuItem_Click);
            // 
            // colorModificationToolStripMenuItem
            // 
            this.colorModificationToolStripMenuItem.Name = "colorModificationToolStripMenuItem";
            this.colorModificationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.colorModificationToolStripMenuItem.Text = "Color Modification";
            this.colorModificationToolStripMenuItem.Click += new System.EventHandler(this.colorModificationToolStripMenuItem_Click);
            // 
            // histogramModificationToolStripMenuItem
            // 
            this.histogramModificationToolStripMenuItem.Name = "histogramModificationToolStripMenuItem";
            this.histogramModificationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.histogramModificationToolStripMenuItem.Text = "Histogram Modification";
            this.histogramModificationToolStripMenuItem.Click += new System.EventHandler(this.histogramModificationToolStripMenuItem_Click);
            // 
            // filteringToolStripMenuItem
            // 
            this.filteringToolStripMenuItem.Name = "filteringToolStripMenuItem";
            this.filteringToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.filteringToolStripMenuItem.Text = "Filtering";
            this.filteringToolStripMenuItem.Click += new System.EventHandler(this.filteringToolStripMenuItem_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            this.morphologyToolStripMenuItem.Click += new System.EventHandler(this.morphologyToolStripMenuItem_Click);
            // 
            // pic_org
            // 
            this.pic_org.BackColor = System.Drawing.Color.White;
            this.pic_org.Location = new System.Drawing.Point(12, 52);
            this.pic_org.Name = "pic_org";
            this.pic_org.Size = new System.Drawing.Size(256, 256);
            this.pic_org.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_org.TabIndex = 2;
            this.pic_org.TabStop = false;
            this.pic_org.Click += new System.EventHandler(this.pic_org_Click);
            // 
            // pic_dst
            // 
            this.pic_dst.BackColor = System.Drawing.Color.White;
            this.pic_dst.Location = new System.Drawing.Point(274, 52);
            this.pic_dst.Name = "pic_dst";
            this.pic_dst.Size = new System.Drawing.Size(256, 256);
            this.pic_dst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dst.TabIndex = 3;
            this.pic_dst.TabStop = false;
            this.pic_dst.Click += new System.EventHandler(this.pic_dst_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 314);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear Image";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Gray
            // 
            this.btn_Gray.Location = new System.Drawing.Point(111, 314);
            this.btn_Gray.Name = "btn_Gray";
            this.btn_Gray.Size = new System.Drawing.Size(107, 23);
            this.btn_Gray.TabIndex = 5;
            this.btn_Gray.Text = "Convert to Gray";
            this.btn_Gray.UseVisualStyleBackColor = true;
            this.btn_Gray.Click += new System.EventHandler(this.btn_Gray_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 347);
            this.Controls.Add(this.btn_Gray);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pic_dst);
            this.Controls.Add(this.pic_org);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_org)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorModificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramModificationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic_org;
        private System.Windows.Forms.PictureBox pic_dst;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiedHistogramToolStripMenuItem;
        private System.Windows.Forms.Button btn_Gray;
    }
}

