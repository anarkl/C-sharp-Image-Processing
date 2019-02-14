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
    public partial class frm_dstImg : Form
    {
        public frm_dstImg()
        {
            InitializeComponent();
        }

        public frm_dstImg(int width, int height)
        {
            InitializeComponent();
            this.pic_dst.Width = width;
            this.pic_dst.Height = height;
            this.Width = width + 15;
            this.Height = height + 40;

            pic_dst.Image = Globl.Frm_Main.ReturnDst();
        }

        public frm_dstImg(Bitmap bit_org)
        {
            InitializeComponent();
            this.pic_dst.Width = bit_org.Width;
            this.pic_dst.Height = bit_org.Height;
            this.Width = bit_org.Width + 15;
            this.Height = bit_org.Height + 40;

            pic_dst.Image = bit_org;
        }

        private void frm_dstImg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Globl.Frm_DstImg = null;
        }
    }
}
