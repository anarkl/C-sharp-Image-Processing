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
    public partial class frm_EdgeDetection : Form
    {
        int[,] mask_x;
        int[,] mask_y;
        Bitmap bit_org, bit_dst;
        bool Workable = true;

        public frm_EdgeDetection()
        {
            InitializeComponent();
        }

        private void frm_EdgeDetection_Load(object sender, EventArgs e)
        {
            bit_org = Globl.Frm_Main.ReturnOrg();
            bit_org = Binary.GetGray(bit_org);
        }

        private void frm_EdgeDetection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Globl.Frm_EdgeDetection = null;
        }

        private void btn_Sobel_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            lbl_Status.Text = "Working...";
            Application.DoEvents();

            bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            mask_x = new int[3, 3] { { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            mask_y = new int[3, 3] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            int x_tmp, y_tmp, tmp = 0, k;
            Color col = new Color();

            for (int i = 0; i < bit_org.Width; i++)
                for (int j = 0; j < bit_org.Height; j++)
                {
                    x_tmp = 0;
                    y_tmp = 0;
                    for (int m = -1; m <= 1; m++)
                        for (int n = -1; n <= 1; n++)
                        {
                            if (((i + m) < 0) || ((i + m) > bit_org.Width - 1) || ((j + n) < 0) || ((j + n) > bit_org.Height - 1))
                                k = 0;
                            else
                            {
                                col = bit_org.GetPixel(i + m, j + n);
                                k = col.R;
                            }
                            x_tmp += k * mask_x[m + 1, n + 1];
                            y_tmp += k * mask_y[m + 1, n + 1];
                            tmp = (int)Math.Sqrt(x_tmp * x_tmp + y_tmp * y_tmp);
                        }
                    if (tmp > 255)
                        tmp = 255;
                    else if (tmp < 0)
                        tmp = 0;
                    bit_dst.SetPixel(i, j, Color.FromArgb(tmp, tmp, tmp));
                }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Sobel Edge detection Done!!!";

        }

        private void btn_prewitt_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            lbl_Status.Text = "Working...";
            Application.DoEvents();

            bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            mask_x = new int[3, 3] { { 1, 0, -1 }, { 1, 0, -1 }, { 1, 0, -1 } };
            mask_y = new int[3, 3] { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
            int x_tmp, y_tmp, tmp = 0, k;
            Color col = new Color();

            for (int i = 0; i < bit_org.Width; i++)
                for (int j = 0; j < bit_org.Height; j++)
                {
                    x_tmp = 0;
                    y_tmp = 0;
                    for (int m = -1; m <= 1; m++)
                        for (int n = -1; n <= 1; n++)
                        {
                            if (((i + m) < 0) || ((i + m) > bit_org.Width - 1) || ((j + n) < 0) || ((j + n) > bit_org.Height - 1))
                                k = 0;
                            else
                            {
                                col = bit_org.GetPixel(i + m, j + n);
                                k = col.R;
                            }
                            x_tmp += k * mask_x[m + 1, n + 1];
                            y_tmp += k * mask_y[m + 1, n + 1];
                            tmp = (int)Math.Sqrt(x_tmp * x_tmp + y_tmp * y_tmp);
                        }
                    if (tmp > 255)
                        tmp = 255;
                    else if (tmp < 0)
                        tmp = 0;
                    bit_dst.SetPixel(i, j, Color.FromArgb(tmp, tmp, tmp));
                }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Prewitt Edge detection Done!!!";
        }

        private void btn_Roberts_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            lbl_Status.Text = "Working...";
            Application.DoEvents();

            bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            mask_x = new int[3, 3] { { 0, 0, -1 }, { 0, 1, 0 }, { 0, 0, 0 } };
            mask_y = new int[3, 3] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
            int x_tmp, y_tmp, tmp = 0, k;
            Color col = new Color();

            for (int i = 0; i < bit_org.Width; i++)
                for (int j = 0; j < bit_org.Height; j++)
                {
                    x_tmp = 0;
                    y_tmp = 0;
                    for (int m = -1; m <= 1; m++)
                        for (int n = -1; n <= 1; n++)
                        {
                            if (((i + m) < 0) || ((i + m) > bit_org.Width - 1) || ((j + n) < 0) || ((j + n) > bit_org.Height - 1))
                                k = 0;
                            else
                            {
                                col = bit_org.GetPixel(i + m, j + n);
                                k = col.R;
                            }
                            x_tmp += k * mask_x[m + 1, n + 1];
                            y_tmp += k * mask_y[m + 1, n + 1];
                            tmp = (int)Math.Sqrt(x_tmp * x_tmp + y_tmp * y_tmp);
                        }
                    if (tmp > 255)
                        tmp = 255;
                    else if (tmp < 0)
                        tmp = 0;
                    bit_dst.SetPixel(i, j, Color.FromArgb(tmp, tmp, tmp));
                }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Roberts Edge detection Done!!!";
        }

        private void btn_Laplacian_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            lbl_Status.Text = "Working...";
            Application.DoEvents();

            bit_dst = new Bitmap(bit_org.Width, bit_org.Height);

            if (rad_4dir.Checked)
                mask_x = new int[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
            else if (rad_8dir.Checked)
                mask_x = new int[3, 3] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };

            int tmp = 0, k;
            Color col = new Color();

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
                                col = bit_org.GetPixel(i + m, j + n);
                                k = col.R;
                            }
                            tmp += k * mask_x[m + 1, n + 1];
                        }
                    if (tmp > 255)
                        tmp = 255;
                    else if (tmp < 0)
                        tmp = 0;
                    bit_dst.SetPixel(i, j, Color.FromArgb(tmp, tmp, tmp));
                }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Laplacian Edge detection Done!!!";
        }

        public void DisableWork(bool Workable)
        {
            this.Workable = Workable;
        }
    }
}
