using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyChannelPacking
{
    public static class Funcoes
    {
        public static System.Drawing.Image RedimensionarImagem(System.Drawing.Image srcImage, int newWidth, int newHeight, PixelFormat pf, InterpolationMode mode)
        {
            if (srcImage != null)
            {
                Bitmap newImage = new Bitmap(newWidth, newHeight, pf);
                newImage.MakeTransparent();
                using (Graphics gr = Graphics.FromImage((Image)newImage))
                {
                    //gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = mode; //InterpolationMode.HighQualityBicubic;
                    //gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(srcImage, 0, 0, newWidth, newHeight);// new Rectangle(0, 0, newWidth, newHeight));
                    gr.Dispose();
                    return (Image)newImage;
                }
            }
            else
                return null;

        }
    }
}
