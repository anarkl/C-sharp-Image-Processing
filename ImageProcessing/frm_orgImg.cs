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
    public partial class frm_orgImg : Form
    {
        public frm_orgImg()
        {
            InitializeComponent();
        }

        public frm_orgImg(int width,int height)
        {
            InitializeComponent();
            this.pic_org.Width = width;
            this.pic_org.Height = height;
            this.Width = width + 15;
            this.Height = height + 40;

            pic_org.Image = Globl.Frm_Main.ReturnOrg();
        }
        public frm_orgImg(Bitmap bit_org)
        {
            InitializeComponent();
            this.pic_org.Width = bit_org.Width;
            this.pic_org.Height = bit_org.Height;
            this.Width = bit_org.Width + 15;
            this.Height = bit_org.Height + 40;

            pic_org.Image = bit_org;
        }

        private void frm_orgImg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Globl.Frm_OrgImg = null;
        }
    }
}
