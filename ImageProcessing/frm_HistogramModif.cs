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
    public partial class frm_HistogramModif : Form
    {
        bool Workable = true;

        public frm_HistogramModif()
        {
            InitializeComponent();
        }

        public void DisableWork(bool Workable)
        {
            this.Workable = Workable;
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if(!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            Bitmap bit_dst = Binary.GetGray(Globl.Frm_Main.ReturnOrg());
            Application.DoEvents();
            lbl_Status.Text = "Working...";

            int[] intensity = new int[256];
            int[] LUT = new int[256];
            int k, width, height, sum = 0;

            width = bit_dst.Width;
            height = bit_dst.Height;
            int num_pixel = width * height;
            //밝기값 갯수
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    k = bit_dst.GetPixel(i, j).R;
                    intensity[k]++;
                }

            //누적합 LUT계산
            for(int i=0;i<=255;i++)
            {
                sum += intensity[i];
                LUT[i] = (int)(sum * (255 / (double)num_pixel));
            }

            //equalization
            for(int i=0;i<width;i++)
                for(int j=0;j<height;j++)
                {
                    k = bit_dst.GetPixel(i, j).R;
                    bit_dst.SetPixel(i, j, Color.FromArgb(LUT[k], LUT[k], LUT[k]));
                }
            lbl_Status.Text = "Histogram Equaliztion Done!";
            Globl.Frm_Main.SetDst(bit_dst);
        }

        private void frm_HistogramModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Globl.Frm_HistoModif = null;
        }

        private void btn_Endin_Click(object sender, EventArgs e)
        {
            double min, max;

            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            try
            {
                min = Convert.ToDouble(txt_min.Text);
                max = Convert.ToDouble(txt_max.Text);
            }
            catch (FormatException)
            {
                lbl_Status.Text = "Put float number In!";
                return;
            }
            Bitmap bit_dst = Binary.GetGray(Globl.Frm_Main.ReturnOrg());

            Application.DoEvents();
            lbl_Status.Text = "Working...";
            int[] intensity = new int[256];
            int[] LUT = new int[256];
            int k, width, height;

            width = bit_dst.Width;
            height = bit_dst.Height;
            //밝기값 갯수
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    k = bit_dst.GetPixel(i, j).R;
                    intensity[k]++;
                }

            //하한, 상한 밝기값
            int num_pixel = (int)(width * height * min / 100);
            int tmp = 0;
            int min_intensity = 0, max_intensity = 0;
            for (int i = 0; i <= 255; i++)
            {
                tmp += intensity[i];
                if (tmp >= num_pixel)
                {
                    min_intensity = i;
                    break;
                }
            }
            num_pixel = (int)(width * height * max / 100);
            tmp = 0;
            for (int i = 255; i >= 0; i--)
            {
                tmp += intensity[i];
                if (tmp >= num_pixel)
                {
                    max_intensity = i;
                    break;
                }
            }

            //LUT 계산
            for (int i = 0; i <= 255; i++)
            {
                LUT[i] = (int)((i - min_intensity) / (double)(max_intensity - min_intensity) * 255);
                if (LUT[i] < 0)
                    LUT[i] = 0;
                else if (LUT[i] > 255)
                    LUT[i] = 255;
            }

            //스트레칭
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    k = bit_dst.GetPixel(i, j).R;
                    bit_dst.SetPixel(i, j, Color.FromArgb(LUT[k], LUT[k], LUT[k]));
                }
            lbl_Status.Text = "Histogram Stratching Done!";
            Globl.Frm_Main.SetDst(bit_dst);
        }
    }
}
