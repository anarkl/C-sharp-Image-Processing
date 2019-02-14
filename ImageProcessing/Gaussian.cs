using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    class Gaussian
    {
        public static Bitmap G_blur_3x3(Bitmap bit_org)
        {
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            double[,] mask = new double[3, 3];
            double tmp;
            int k;
            BitmapData bit_data = bit_org.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bit_data_dst = bit_dst.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            Parallel.Invoke(
                () =>
                {
                    //mask 생성
                    mask[0, 0] = (double)1 / 16; mask[0, 1] = (double)2 / 16; mask[0, 2] = (double)1 / 16;
                    mask[1, 0] = (double)2 / 16; mask[1, 1] = (double)4 / 16; mask[1, 2] = (double)2 / 16;
                    mask[2, 0] = (double)1 / 16; mask[2, 1] = (double)2 / 16; mask[2, 2] = (double)1 / 16;

                    //filtering
                    unsafe
                    {
                        byte* ptr_org = (byte*)bit_data.Scan0.ToPointer();
                        byte* ptr_dst = (byte*)bit_data_dst.Scan0.ToPointer();
                        int Ws = 3;
                        int stride = bit_data.Stride;
                        int nOffset = stride - bit_org.Width * Ws;

                        for (int i = 0; i < bit_org.Width; i++)
                            for (int j = 0; j < bit_dst.Height; j++)
                            {
                                tmp = 0;
                                long p = (i * Ws) + (j * stride);

                                for (int m = -1; m <= 1; m++)
                                    for (int n = -1; n <= 1; n++)
                                    {
                                        if ((i + m < 0) || (i + m > bit_org.Width - 1) || (j + n < 0) || (j + n > bit_org.Height - 1))
                                            k = 0;
                                        else
                                        {
                                            k = ptr_org[((i + m) * Ws) + ((j + n) * stride)];
                                        }
                                        tmp += k * mask[m + 1, n + 1];
                                    }
                                ptr_dst[p] = (byte)tmp; ptr_dst[p + 1] = (byte)tmp; ptr_dst[p + 2] = (byte)tmp;
                            }

                    }
                }
                );
            bit_org.UnlockBits(bit_data);
            bit_dst.UnlockBits(bit_data_dst);

            return bit_dst;
        }

        public static Bitmap G_blur_5x5(Bitmap bit_org)
        {
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            double[,] mask = new double[5, 5];
            double tmp;
            int k;
            BitmapData bit_data = bit_org.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bit_data_dst = bit_dst.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            Parallel.Invoke(
                () =>
                {
                    //mask 생성
                    mask[0, 0] = (double)2 / 159; mask[0, 1] = (double)4 / 159; mask[0, 2] = (double)5 / 159; mask[0, 3] = (double)4 / 159; mask[0, 4] = (double)2 / 159;
                    mask[1, 0] = (double)4 / 159; mask[1, 1] = (double)9 / 159; mask[1, 2] = (double)12 / 159; mask[1, 3] = (double)9 / 159; mask[1, 4] = (double)4 / 159;
                    mask[2, 0] = (double)5 / 159; mask[2, 1] = (double)12 / 159; mask[2, 2] = (double)15 / 159; mask[2, 3] = (double)12 / 159; mask[2, 4] = (double)5 / 159;
                    mask[3, 0] = (double)4 / 159; mask[3, 1] = (double)9 / 159; mask[3, 2] = (double)12 / 159; mask[3, 3] = (double)9 / 159; mask[3, 4] = (double)4 / 159;
                    mask[4, 0] = (double)2 / 159; mask[4, 1] = (double)4 / 159; mask[4, 2] = (double)5 / 159; mask[4, 3] = (double)4 / 159; mask[4, 4] = (double)2 / 159;

                    //filtering
                    unsafe
                    {
                        byte* ptr_org = (byte*)bit_data.Scan0.ToPointer();
                        byte* ptr_dst = (byte*)bit_data_dst.Scan0.ToPointer();
                        int Ws = 3;
                        int stride = bit_data.Stride;
                        int nOffset = stride - bit_org.Width * Ws;

                        for (int i = 0; i < bit_org.Width; i++)
                            for (int j = 0; j < bit_dst.Height; j++)
                            {
                                tmp = 0;
                                long p = (i * Ws) + (j * stride);

                                for (int m = -2; m <= 2; m++)
                                    for (int n = -2; n <= 2; n++)
                                    {
                                        if ((i + m < 0) || (i + m > bit_org.Width - 1) || (j + n < 0) || (j + n > bit_org.Height - 1))
                                            k = 0;
                                        else
                                        {
                                            k = ptr_org[((i + m) * Ws) + ((j + n) * stride)];
                                        }
                                        tmp += k * mask[m + 2, n + 2];
                                    }
                                ptr_dst[p] = (byte)tmp; ptr_dst[p + 1] = (byte)tmp; ptr_dst[p + 2] = (byte)tmp;
                            }
                        bit_org.UnlockBits(bit_data);
                        bit_dst.UnlockBits(bit_data_dst);
                    }
                }
                );
            return bit_dst;
        }
    }
}
