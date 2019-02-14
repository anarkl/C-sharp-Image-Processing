using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageProcessing
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        public Bitmap ReturnOrg()
        {
            return (Bitmap)pic_org.Image;
        }

        public Bitmap ReturnDst()
        {
            return (Bitmap)pic_dst.Image;
        }

        public void SetDst(Bitmap bit_dst)
        {
            pic_dst.Image = bit_dst;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";

            openFileDialog1.Filter = "비트맵 파일(*.bmp)|*.bmp|모든 파일(*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                pic_org.Image = Image.FromFile(path);
                pic_dst.Image = null;
                imageProcessToolStripMenuItem.Enabled = true;
                viewToolStripMenuItem.Enabled = true;

                //이미지 프로세싱 Form 리로딩
                if (Globl.Frm_Threshold != null)
                {
                    Globl.Frm_Threshold.Close();
                    Globl.Frm_Threshold = new frm_Threshold();
                    int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
                    int Y = Globl.Frm_Main.Location.Y;
                    Globl.Frm_Threshold.StartPosition = FormStartPosition.Manual;
                    Globl.Frm_Threshold.Location = new Point(X, Y);
                    Globl.Frm_Threshold.Show();
                }
                if (Globl.Frm_EdgeDetection != null)
                {
                    Globl.Frm_EdgeDetection.Close();
                    Globl.Frm_EdgeDetection = new frm_EdgeDetection();
                    int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
                    int Y = Globl.Frm_Main.Location.Y;
                    Globl.Frm_EdgeDetection.StartPosition = FormStartPosition.Manual;
                    Globl.Frm_EdgeDetection.Location = new Point(X, Y);
                    Globl.Frm_EdgeDetection.Show();
                }
                if (Globl.Frm_Color != null)
                {
                    Globl.Frm_Color.Close();
                    Globl.Frm_Color = new frm_ColorModif();
                    int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
                    int Y = Globl.Frm_Main.Location.Y;
                    Globl.Frm_Color.StartPosition = FormStartPosition.Manual;
                    Globl.Frm_Color.Location = new Point(X, Y);
                    Globl.Frm_Color.Show();
                }
                if (Globl.Frm_HistoModif != null)
                {
                    Globl.Frm_HistoModif.Close();
                    Globl.Frm_HistoModif = new frm_HistogramModif();
                    int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
                    int Y = Globl.Frm_Main.Location.Y;
                    Globl.Frm_HistoModif.StartPosition = FormStartPosition.Manual;
                    Globl.Frm_HistoModif.Location = new Point(X, Y);
                    Globl.Frm_HistoModif.Show();
                }
                if(Globl.Frm_Filtering!=null)
                {
                    Globl.Frm_Filtering.Close();
                    Globl.Frm_Filtering = new frm_Filtering();
                    int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
                    int Y = Globl.Frm_Main.Location.Y;
                    Globl.Frm_Filtering.StartPosition = FormStartPosition.Manual;
                    Globl.Frm_Filtering.Location = new Point(X, Y);
                    Globl.Frm_Filtering.Show();
                }
                if(Globl.Frm_Morphology!=null)
                {
                    Globl.Frm_Morphology.Close();
                    Globl.Frm_Morphology = new frm_Morphology();
                    int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
                    int Y = Globl.Frm_Main.Location.Y;
                    Globl.Frm_Morphology.StartPosition = FormStartPosition.Manual;
                    Globl.Frm_Morphology.Location = new Point(X, Y);
                    Globl.Frm_Morphology.Show();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "";
            Bitmap bit_dst;

            saveFileDialog1.Filter = "비트맵 파일(*.bmp)|*.bmp";
            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                bit_dst = (Bitmap)pic_dst.Image;
                bit_dst.Save(path);
            }
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globl.Frm_Threshold != null)
                return;

            //다른 Form 닫기
            if (Globl.Frm_EdgeDetection != null)
                Globl.Frm_EdgeDetection.Close();
            if (Globl.Frm_Color != null)
                Globl.Frm_Color.Close();
            if (Globl.Frm_HistoModif != null)
                Globl.Frm_HistoModif.Close();
            if (Globl.Frm_Filtering != null)
                Globl.Frm_Filtering.Close();
            if (Globl.Frm_Morphology != null)
                Globl.Frm_Morphology.Close();

            Globl.Frm_Threshold = new frm_Threshold();
            int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
            int Y = Globl.Frm_Main.Location.Y;
            Globl.Frm_Threshold.StartPosition = FormStartPosition.Manual;
            Globl.Frm_Threshold.Location = new Point(X, Y);
            Globl.Frm_Threshold.Show();
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globl.Frm_EdgeDetection != null)
                return;

            //다른 Form 닫기
            if (Globl.Frm_Threshold != null)
                Globl.Frm_Threshold.Close();
            if (Globl.Frm_Color != null)
                Globl.Frm_Color.Close();
            if (Globl.Frm_HistoModif != null)
                Globl.Frm_HistoModif.Close();
            if (Globl.Frm_Filtering != null)
                Globl.Frm_Filtering.Close();
            if (Globl.Frm_Morphology != null)
                Globl.Frm_Morphology.Close();

            Globl.Frm_EdgeDetection = new frm_EdgeDetection();
            int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
            int Y = Globl.Frm_Main.Location.Y;
            Globl.Frm_EdgeDetection.StartPosition = FormStartPosition.Manual;
            Globl.Frm_EdgeDetection.Location = new Point(X, Y);
            Globl.Frm_EdgeDetection.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            pic_org.Image = null;
            pic_dst.Image = null;
            imageProcessToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;

            if (Globl.Frm_Threshold != null)
                Globl.Frm_Threshold.DisableWork(false);
            if (Globl.Frm_EdgeDetection != null)
                Globl.Frm_EdgeDetection.DisableWork(false);
            if (Globl.Frm_Color != null)
                Globl.Frm_Color.DisableWork(false);
            if (Globl.Frm_HistoModif != null)
                Globl.Frm_HistoModif.DisableWork(false);
            if (Globl.Frm_Morphology != null)
                Globl.Frm_Morphology.DisableWork(false);
        }

        private void originalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_org.Image == null)
            {
                MessageBox.Show("There is No loaded Image!!!");
                return;
            }
            int width, height;
            width = pic_org.Image.Width;
            height = pic_org.Image.Height;

            Globl.Frm_OrgImg = new frm_orgImg(width, height);
            Globl.Frm_OrgImg.Show();
        }

        private void modifiedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_dst.Image == null)
            {
                MessageBox.Show("There is No modified Image!!!");
                return;
            }
            int width, height;
            width = pic_dst.Image.Width;
            height = pic_dst.Image.Height;

            Globl.Frm_DstImg = new frm_dstImg(width, height);
            Globl.Frm_DstImg.Show();
        }

        private void pic_org_Click(object sender, EventArgs e)
        {
            originalImageToolStripMenuItem.PerformClick();
        }

        private void pic_dst_Click(object sender, EventArgs e)
        {
            modifiedImageToolStripMenuItem.PerformClick();
        }

        private void colorModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globl.Frm_Color != null)
                return;

            //다른 Form 닫기
            if (Globl.Frm_Threshold != null)
                Globl.Frm_Threshold.Close();
            if (Globl.Frm_EdgeDetection != null)
                Globl.Frm_EdgeDetection.Close();
            if (Globl.Frm_HistoModif != null)
                Globl.Frm_HistoModif.Close();
            if (Globl.Frm_Filtering != null)
                Globl.Frm_Filtering.Close();
            if (Globl.Frm_Morphology != null)
                Globl.Frm_Morphology.Close();

            Globl.Frm_Color = new frm_ColorModif();
            int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
            int Y = Globl.Frm_Main.Location.Y;
            Globl.Frm_Color.StartPosition = FormStartPosition.Manual;
            Globl.Frm_Color.Location = new Point(X, Y);
            Globl.Frm_Color.Show();
        }

        private void histogramModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globl.Frm_HistoModif != null)
                return;

            //다른 Form 닫기
            if (Globl.Frm_Threshold != null)
                Globl.Frm_Threshold.Close();
            if (Globl.Frm_EdgeDetection != null)
                Globl.Frm_EdgeDetection.Close();
            if (Globl.Frm_Color != null)
                Globl.Frm_Color.Close();
            if (Globl.Frm_Filtering != null)
                Globl.Frm_Filtering.Close();
            if (Globl.Frm_Morphology != null)
                Globl.Frm_Morphology.Close();

            Globl.Frm_HistoModif = new frm_HistogramModif();
            int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
            int Y = Globl.Frm_Main.Location.Y;
            Globl.Frm_HistoModif.StartPosition = FormStartPosition.Manual;
            Globl.Frm_HistoModif.Location = new Point(X, Y);
            Globl.Frm_HistoModif.Show();
        }

        private void originalHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_org.Image == null)
            {
                MessageBox.Show("There is No loaded Image!!!");
                return;
            }
            Bitmap histogram = GetHistogram((Bitmap)pic_org.Image);

            Globl.Frm_OrgImg = new frm_orgImg(histogram);
            Globl.Frm_OrgImg.Show();
        }

        private void modifiedHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pic_dst.Image == null)
            {
                MessageBox.Show("There is No modified Image!!!");
                return;
            }
            Bitmap histogram = GetHistogram((Bitmap)pic_dst.Image);

            Globl.Frm_DstImg = new frm_dstImg(histogram);
            Globl.Frm_DstImg.Show();
        }

        private Bitmap GetHistogram(Bitmap bit_org)
        {
            Bitmap histogram = new Bitmap(512, 256);
            int width = bit_org.Width;
            int height = bit_org.Height;
            int k;
            int[] intensity = new int[256];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    k = bit_org.GetPixel(i, j).R;
                    intensity[k]++;
                }
            int max = 0;

            for (int i = 0; i < 256; i++)
                if (intensity[i] > max)
                    max = intensity[i];

            Graphics g = Graphics.FromImage(histogram);

            for (int i = 0; i < 256; i++)
            {
                int length = (int)(intensity[i] / (double)max * 511);
                g.DrawLine(Pens.Black, 2 * i, 511, 2 * i, 511 - length);
            }
            return histogram;
        }

        private void btn_Gray_Click(object sender, EventArgs e)
        {
            try
            {
                pic_org.Image = Binary.GetGray((Bitmap)pic_org.Image);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("There is No loaded Image!!");
            }
        }

        private void filteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globl.Frm_Filtering != null)
                return;

            //다른 Form 닫기
            if (Globl.Frm_Threshold != null)
                Globl.Frm_Threshold.Close();
            if (Globl.Frm_EdgeDetection != null)
                Globl.Frm_EdgeDetection.Close();
            if (Globl.Frm_Color != null)
                Globl.Frm_Color.Close();
            if (Globl.Frm_HistoModif != null)
                Globl.Frm_HistoModif.Close();
            if (Globl.Frm_Morphology != null)
                Globl.Frm_Morphology.Close();

            Globl.Frm_Filtering = new frm_Filtering();
            int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
            int Y = Globl.Frm_Main.Location.Y;
            Globl.Frm_Filtering.StartPosition = FormStartPosition.Manual;
            Globl.Frm_Filtering.Location = new Point(X, Y);
            Globl.Frm_Filtering.Show();
        }

        public void SetOrg(Bitmap bit_org)
        {
            pic_org.Image = bit_org;
        }

        private void morphologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globl.Frm_Morphology != null)
                return;

            //다른 Form 닫기
            if (Globl.Frm_Threshold != null)
                Globl.Frm_Threshold.Close();
            if (Globl.Frm_EdgeDetection != null)
                Globl.Frm_EdgeDetection.Close();
            if (Globl.Frm_Color != null)
                Globl.Frm_Color.Close();
            if (Globl.Frm_HistoModif != null)
                Globl.Frm_HistoModif.Close();
            if (Globl.Frm_Filtering != null)
                Globl.Frm_Filtering.Close();

            Globl.Frm_Morphology = new frm_Morphology();
            int X = Globl.Frm_Main.Location.X + Globl.Frm_Main.Width;
            int Y = Globl.Frm_Main.Location.Y;
            Globl.Frm_Morphology.StartPosition = FormStartPosition.Manual;
            Globl.Frm_Morphology.Location = new Point(X, Y);
            Globl.Frm_Morphology.Show();
        }
    }
}
