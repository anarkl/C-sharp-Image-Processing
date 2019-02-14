using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Globl.Frm_Main = new frm_Main();
            Globl.Frm_Main.StartPosition = FormStartPosition.Manual;
            Globl.Frm_Main.Location = new System.Drawing.Point(20, 20);
            Globl.Frm_Main.Show();
            Globl.Frm_Main.Activate();

            Application.Run(Globl.Frm_Main);
        }

        private static void Form_loading()
        {
            
           
        }
        
    }
}
