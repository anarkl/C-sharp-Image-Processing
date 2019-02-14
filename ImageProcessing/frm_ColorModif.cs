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
    public partial class frm_ColorModif : Form
    {
        Bitmap bit_org, bit_dst;
        bool Workable = true;

        public frm_ColorModif()
        {
            InitializeComponent();
        }

        public void DisableWork(bool Workable)
        {
            this.Workable = Workable;
        }
        
        #region 상수 연산
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            Color col = new Color();
            int k, red, green, blue, C = 0;
            try
            {
                C = Convert.ToInt32(txt_C.Text);
            }
            catch (FormatException)
            {
                lbl_Status.Text = "Put Integer num In!";
                return;
            }

            Application.DoEvents();
            lbl_Status.Text = "Working...";

            bit_org = Globl.Frm_Main.ReturnOrg();

            if (chk_Gray.Checked)
            {
                bit_dst = Binary.GetGray(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        k = bit_dst.GetPixel(i, j).R;
                        k += C;
                        if (k > 255)
                            k = 255;
                        if (k < 0)
                            k = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(k, k, k));
                    }
            }
            else if (!chk_Gray.Checked)
            {
                bit_dst = new Bitmap(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        col = bit_dst.GetPixel(i, j);
                        red = col.R;
                        green = col.G;
                        blue = col.B;

                        red += C; green += C; blue += C;

                        if (red > 255)
                            red = 255;
                        if (red < 0)
                            red = 0;
                        if (green > 255)
                            green = 255;
                        if (green < 0)
                            green = 0;
                        if (blue > 255)
                            blue = 255;
                        if (blue < 0)
                            blue = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
            }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Constant Adding Done!!";
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            Color col = new Color();
            int k, red, green, blue, C = 0;
            try
            {
                C = Convert.ToInt32(txt_C.Text);
            }
            catch (FormatException)
            {
                lbl_Status.Text = "Put Integer num In!";
                return;
            }

            Application.DoEvents();
            lbl_Status.Text = "Working...";

            bit_org = Globl.Frm_Main.ReturnOrg();

            if (chk_Gray.Checked)
            {
                bit_dst = Binary.GetGray(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        k = bit_dst.GetPixel(i, j).R;
                        k -= C;
                        if (k > 255)
                            k = 255;
                        if (k < 0)
                            k = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(k, k, k));
                    }
            }
            else if (!chk_Gray.Checked)
            {
                bit_dst = new Bitmap(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        col = bit_dst.GetPixel(i, j);
                        red = col.R;
                        green = col.G;
                        blue = col.B;

                        red -= C; green -= C; blue -= C;

                        if (red > 255)
                            red = 255;
                        if (red < 0)
                            red = 0;
                        if (green > 255)
                            green = 255;
                        if (green < 0)
                            green = 0;
                        if (blue > 255)
                            blue = 255;
                        if (blue < 0)
                            blue = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
            }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Constant Subtracting Done!!";
        }

        private void btn_multply_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            Color col = new Color();
            int k, red, green, blue;
            double C = 0;
            try
            {
                C = Convert.ToDouble(txt_C.Text);
            }
            catch (FormatException)
            {
                lbl_Status.Text = "Put Float num In!";
                return;
            }

            Application.DoEvents();
            lbl_Status.Text = "Working...";
            bit_org = Globl.Frm_Main.ReturnOrg();

            if (chk_Gray.Checked)
            {
                bit_dst = Binary.GetGray(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        k = bit_dst.GetPixel(i, j).R;
                        k = (int)(C * k);
                        if (k > 255)
                            k = 255;
                        if (k < 0)
                            k = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(k, k, k));
                    }
            }
            else if (!chk_Gray.Checked)
            {
                bit_dst = new Bitmap(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        col = bit_dst.GetPixel(i, j);
                        red = col.R;
                        green = col.G;
                        blue = col.B;

                        red = (int)(C * red); green = (int)(C * green); blue = (int)(C * blue);

                        if (red > 255)
                            red = 255;
                        if (red < 0)
                            red = 0;
                        if (green > 255)
                            green = 255;
                        if (green < 0)
                            green = 0;
                        if (blue > 255)
                            blue = 255;
                        if (blue < 0)
                            blue = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
            }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Constant Multiplying Done!!";
        }

        private void frm_ColorModif_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Globl.Frm_Color = null;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }

            Color col = new Color();
            int k, red, green, blue;
            double C = 0;
            try
            {
                C = Convert.ToDouble(txt_C.Text);
            }
            catch (FormatException)
            {
                lbl_Status.Text = "Put Float num In!";
                return;
            }
            bit_org = Globl.Frm_Main.ReturnOrg();

            if (chk_Gray.Checked)
            {
                bit_dst = Binary.GetGray(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        k = bit_dst.GetPixel(i, j).R;
                        k = (int)(k / C);
                        if (k > 255)
                            k = 255;
                        if (k < 0)
                            k = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(k, k, k));
                    }
            }
            else if (!chk_Gray.Checked)
            {
                bit_dst = new Bitmap(bit_org);

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        col = bit_dst.GetPixel(i, j);
                        red = col.R;
                        green = col.G;
                        blue = col.B;

                        red = (int)(red / C); green = (int)(green / C); blue = (int)(blue / C);

                        if (red > 255)
                            red = 255;
                        if (red < 0)
                            red = 0;
                        if (green > 255)
                            green = 255;
                        if (green < 0)
                            green = 0;
                        if (blue > 255)
                            blue = 255;
                        if (blue < 0)
                            blue = 0;
                        bit_dst.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
            }
            Globl.Frm_Main.SetDst(bit_dst);

            lbl_Status.Text = "Constant Dividing Done!!";
        }
        #endregion
    }
}