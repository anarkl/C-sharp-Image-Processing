using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessing
{
    class Binary
    {
        public static Bitmap GetGray(Bitmap bit_org)
        {
            Bitmap bit_dst = new Bitmap(bit_org);
            BitmapData bitdata = bit_dst.LockBits(new Rectangle(0, 0, bit_dst.Width, bit_dst.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int k;
            int W_s = 3;
            int nOffset = bitdata.Stride - bit_dst.Width * 3;

            unsafe
            {
                Parallel.Invoke(
                    () =>
                    {
                        byte* ptr = (byte*)bitdata.Scan0.ToPointer();

                        for (int j = 0; j < bit_dst.Height; j++)
                        {
                            for (int i = 0; i < bit_dst.Width; i++)
                            {
                                k = (ptr[0] + ptr[1] + ptr[2]) / 3;
                                ptr[0] = (byte)k; ptr[1] = (byte)k; ptr[2] = (byte)k;
                                ptr += W_s;
                            }
                            ptr += nOffset;
                        }
                    });
            }

            bit_dst.UnlockBits(bitdata);
            return bit_dst;
        }

        public static Bitmap GetOtsuBin(Bitmap bit_org)
        {
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            int threshold;
            threshold = get_Otsu_threshold(bit_org);
            bit_dst = GetBinary(bit_org, threshold);
            return bit_dst;
        }

        public static Bitmap GetBinary(Bitmap bit_org, int threshold)
        {
            Bitmap bit_dst = new Bitmap(bit_org.Width, bit_org.Height);
            int[] LUT = new int[256];
            int k;
            BitmapData bit_data = bit_org.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bit_data_dst = bit_dst.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            for (int i = 0; i <= 255; i++)
            {
                if (i <= threshold)
                    LUT[i] = 0;
                if (i > threshold)
                    LUT[i] = 255;
            }
            unsafe
            {
                byte* ptr_org = (byte*)bit_data.Scan0.ToPointer();
                byte* ptr_dst = (byte*)bit_data_dst.Scan0.ToPointer();
                int Ws = 3;
                int stride = bit_data.Stride;
                int nOffset = stride - bit_org.Width * Ws;

                for (int i = 0; i < bit_dst.Width; i++)
                    for (int j = 0; j < bit_dst.Height; j++)
                    {
                        long p = (i * Ws) + (j * stride);

                        k = ptr_org[p];

                        ptr_dst[p] = (byte)LUT[k]; ptr_dst[p + 1] = (byte)LUT[k]; ptr_dst[p + 2] = (byte)LUT[k];
                    }
            }
            bit_org.UnlockBits(bit_data);
            bit_dst.UnlockBits(bit_data_dst);
            return bit_dst;
        }

        private static int get_Otsu_threshold(Bitmap bit_org)
        {
            int threshold = 0;
            int sum, num_pixel, k;
            int[] intensity = new int[256];
            int[] LUT = new int[256];
            double Ow, q1, q2, u1, u2, O1, O2, tmp_O;
            BitmapData bit_data = bit_org.LockBits(new Rectangle(0, 0, bit_org.Width, bit_org.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            num_pixel = bit_org.Width * bit_org.Height;

            //intensity 배열 계산
            unsafe
            {
                byte* ptr = (byte*)bit_data.Scan0.ToPointer();
                int Ws = 3;
                int stride = bit_data.Stride;
                int nOffset = stride - bit_org.Width * Ws;

                for (int i = 0; i < bit_org.Width; i++)
                    for (int j = 0; j < bit_org.Height; j++)
                    {
                        long p = (i * Ws) + (j * stride);
                        k = ptr[p];
                        intensity[k] += 1;
                    }
            }
            bit_org.UnlockBits(bit_data);

            Ow = double.MaxValue;

            for (int t = 0; t <= 255; t++)
            {
                sum = 0;
                for (int i = 0; i <= t; i++)
                    sum += intensity[i];
                q1 = (double)sum / num_pixel;
                q2 = 1 - q1;

                u1 = 0; u2 = 0;
                for (int i = 0; i <= t; i++)
                    u1 += ((double)(i * intensity[i]) / num_pixel) / q1;
                for (int i = t + 1; i <= 255; i++)
                    u2 += ((double)(i * intensity[i]) / num_pixel) / q2;

                O1 = 0; O2 = 0;
                for (int i = 0; i <= t; i++)
                    O1 += (i - u1) * (i - u1) * intensity[i] / num_pixel;
                for (int i = t + 1; i <= 255; i++)
                    O2 += (i - u2) * (i - u2) * intensity[i] / num_pixel;

                tmp_O = O1 + O2;

                if (tmp_O < Ow)
                {
                    Ow = tmp_O;
                    threshold = t;
                }
            }
            return threshold;
        }
    }
}
