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
    public partial class frm_Threshold : Form
    {
        Bitmap bit_org, bit_dst;
        bool Workable = true;

        public frm_Threshold()
        {
            InitializeComponent();
        }

        //원본 이미지 불러오기, 그레이스케일
        private void frm_Threshold_Load(object sender, EventArgs e)
        {
            bit_org = Globl.Frm_Main.ReturnOrg();
            bit_org = Binary.GetGray(bit_org);
        }

        //Form 닫혔을 시 초기화
        private void frm_Threshold_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Globl.Frm_Threshold = null;
        }

        #region 이진화 실행
        private void hsc_Threshold_Scroll(object sender, ScrollEventArgs e)
        {
            txt_Threshold.Text = hsc_Threshold.Value.ToString();
            if (rad_threshold.Checked)
                btn_Binary.PerformClick();
        }

        private void btn_Binary_Click(object sender, EventArgs e)
        {
            if (!Workable)
            {
                lbl_Status.Text = "There is No Original Image!!";
                return;
            }
            lbl_Status.Text = "Working....";
            Application.DoEvents();
            int threshold = 0;
            try
            {
                threshold = Convert.ToInt32(txt_Threshold.Text);
            }
            catch(FormatException)
            {
                lbl_Status.Text = "Put Integer Num In!!!";
                return;
            }
            if (rad_threshold.Checked)
            {
                bit_dst = Binary.GetBinary(bit_org, threshold);
            }
            else if (rad_otsu.Checked)
            {
                bit_dst = Binary.GetOtsuBin(bit_org);
            }

            Globl.Frm_Main.SetDst(bit_dst);
            lbl_Status.Text = "Image Binary Done!!!";
        }
        #endregion

        public void DisableWork(bool Workable)
        {
            this.Workable = Workable;
        }
    }
}
