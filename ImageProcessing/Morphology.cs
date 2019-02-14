using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageProcessing
{
    class Morphology
    {
        public static Bitmap Erosion(Bitmap bit_org)
        {
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            int k;

            for(int i=0;i<bit_dst.Width;i++)
                for(int j=0;j<bit_dst.Height;j++)
                {
                    bit_dst.SetPixel(i, j, Color.Black);
                }


            for(int i=1;i<bit_org.Width-1;i++)
                for(int j=1;j<bit_org.Height-1;j++)
                {
                    int sum = 0;
                    for(int m=-1;m<=1;m++)
                        for(int n=-1;n<=1;n++)
                        {
                            k = bit_org.GetPixel(i + m, j + n).R;
                            if (k == 255)
                                sum++;
                        }
                    if (sum == 9)
                        bit_dst.SetPixel(i, j, Color.White);
                    else
                        bit_dst.SetPixel(i, j, Color.Black);
                }

            return bit_dst;
        }

        public static Bitmap Dilation(Bitmap bit_org)
        {
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            int k;

            for (int i = 0; i < bit_dst.Width; i++)
                for (int j = 0; j < bit_dst.Height; j++)
                {
                    bit_dst.SetPixel(i, j, Color.Black);
                }


            for (int i = 1; i < bit_org.Width - 1; i++)
                for (int j = 1; j < bit_org.Height - 1; j++)
                {
                    int sum = 0;
                    for (int m = -1; m <= 1; m++)
                        for (int n = -1; n <= 1; n++)
                        {
                            k = bit_org.GetPixel(i + m, j + n).R;
                            if (k == 0)
                                sum++;
                        }
                    if (sum == 9)
                        bit_dst.SetPixel(i, j, Color.Black);
                    else
                        bit_dst.SetPixel(i, j, Color.White);
                }
            return bit_dst;
        }
        
        public static Bitmap Opening(Bitmap bit_org)
        {
            Bitmap bit_dst = Erosion(bit_org);
            bit_dst = Dilation(bit_dst);

            return bit_dst;
        }

        public static Bitmap Closing(Bitmap bit_org)
        {
            Bitmap bit_dst = Dilation(bit_org);
            bit_dst = Dilation(bit_dst);

            return bit_dst;
        }
    }
}
