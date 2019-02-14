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
    public partial class frm_Filtering : Form
    {
        bool Workable = true;

        public frm_Filtering()
        {
            InitializeComponent();
        }

        public void DisableWork(bool Workable)
        {
            this.Workable = Workable;
        }

        private void btn_Smoothing_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";

            Bitmap bit_org = Globl.Frm_Main.ReturnOrg();
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            int tmp, k;

            double[,] mask = new double[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    mask[i, j] = (double)1 / 9;

            for (int i = 0; i < bit_org.Width; i++)
                for (int j = 0; j < bit_org.Height; j++)
                {
                    tmp = 0;
                    for (int m = -1; m <= 1; m++)
                        for (int n = -1; n <= 1; n++)
                        {
                            if (((i + m) < 0) || ((i + m) > bit_org.Width - 1) || ((j + n) < 0) || ((j + n) > bit_org.Height - 1))
                                k = 0;
                            else
                            {
                                k = bit_org.GetPixel(i + m, j + n).R;
                            }
                            tmp += (int)(k * mask[m + 1, n + 1]);
                        }
                    if (tmp > 255)
                        tmp = 255;
                    else if (tmp < 0)
                        tmp = 0;
                    bit_dst.SetPixel(i, j, Color.FromArgb(tmp, tmp, tmp));
                }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Smooting Filtering Done!!!";
        }

        private void btn_Median_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";

            Bitmap bit_org = Globl.Frm_Main.ReturnOrg();
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            int tmp, k;

            int[] mask = new int[9];

            for (int i = 0; i < bit_org.Width; i++)
                for (int j = 0; j < bit_org.Height; j++)
                {
                    tmp = 0;
                    for (int m = -1; m <= 1; m++)
                        for (int n = -1; n <= 1; n++)
                        {
                            if (((i + m) < 0) || ((i + m) > bit_org.Width - 1) || ((j + n) < 0) || ((j + n) > bit_org.Height - 1))
                                k = 0;
                            else
                            {
                                k = bit_org.GetPixel(i + m, j + n).R;
                            }
                            mask[tmp] = k;
                            tmp += 1;
                        }
                    Array.Sort(mask);
                    k = mask[5];
                    bit_dst.SetPixel(i, j, Color.FromArgb(k, k, k));
                }

            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Median Filtering Done!!!";
        }

        private void btn_noise_Click(object sender, EventArgs e)
        {
            Bitmap bit_org = Globl.Frm_Main.ReturnOrg();
            Random rnd = new Random();

            int width = bit_org.Width;
            int height = bit_org.Height;

            for (int i = 0; i <= width*height*0.05; i++)

                bit_org.SetPixel(rnd.Next(0, bit_org.Width - 1), rnd.Next(0, bit_org.Height - 1), Color.White);

            for (int i = 0; i <= width*height*0.05; i++)
                bit_org.SetPixel(rnd.Next(0, bit_org.Width - 1), rnd.Next(0, bit_org.Height - 1), Color.Black);

            Globl.Frm_Main.SetOrg(bit_org);
        }

        private void btn_Gaussian_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";

            Bitmap bit_dst = Globl.Frm_Main.ReturnOrg();
            bit_dst = Gaussian.G_blur_3x3(bit_dst);
            Globl.Frm_Main.SetDst(bit_dst);
            lbl_Status.Text = "Gaussian Filtering Done!";
        }
    }
}
