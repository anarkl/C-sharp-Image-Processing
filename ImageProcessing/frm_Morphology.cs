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
    public partial class frm_Morphology : Form
    {
        bool Workable = true;
        public frm_Morphology()
        {
            InitializeComponent();
        }

        public void DisableWork(bool Workable)
        {
            this.Workable = Workable;
        }

        private void btn_Erosion_Click(object sender, EventArgs e)
        {
            if(!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";
            Bitmap bit_dst = Globl.Frm_Main.ReturnOrg();
            bit_dst = Morphology.Erosion(bit_dst);
            Globl.Frm_Main.SetDst(bit_dst);
            lbl_Status.Text = "Erosion Done";
        }

        private void btn_Dilation_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";
            Bitmap bit_dst = Globl.Frm_Main.ReturnOrg();
            bit_dst = Morphology.Dilation(bit_dst);
            Globl.Frm_Main.SetDst(bit_dst);
            lbl_Status.Text = "Dilation Done";
        }

        private void btn_Opening_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";
            Bitmap bit_dst = Globl.Frm_Main.ReturnOrg();
            bit_dst = Morphology.Opening(bit_dst);
            Globl.Frm_Main.SetDst(bit_dst);
            lbl_Status.Text = "Opening Done";
        }

        private void btn_Closing_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No loaded Image!!";
                return;
            }
            Application.DoEvents();
            lbl_Status.Text = "Working...";
            Bitmap bit_dst = Globl.Frm_Main.ReturnOrg();
            bit_dst = Morphology.Closing(bit_dst);
            Globl.Frm_Main.SetDst(bit_dst);
            lbl_Status.Text = "Closing Done";
        }
    }
}
