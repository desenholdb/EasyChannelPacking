using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace EasyChannelPacking
{
    public static class ImageExtension
    {

        public static System.Drawing.Image RedimensionarImagem(int newSize, char orientacao, System.Drawing.Image srcImage)
        {
            if (srcImage != null)
            {
                if (orientacao == 'w' || orientacao == 'W')
                {
                    int newH = newSize * srcImage.Height / srcImage.Width;
                    return RedimensionarImagem(srcImage, newSize, newH);
                }
                else
                {
                    int newW = newSize * srcImage.Width / srcImage.Height;
                    return RedimensionarImagem(srcImage, newW, newSize);
                }
            }
            else return null;

        }

        public static System.Drawing.Image RedimensionarImagem(this System.Drawing.Image srcImage, int newWidth, int newHeight)
        {
            return RedimensionarImagem(srcImage, newWidth, newHeight, PixelFormat.Format24bppRgb);
        }
        /// <summary>
        /// Redimensiona um Objeto System.Drawing.Image
        /// </summary>
        /// <param name="srcImage">System.Drawing.Image</param>
        /// <param name="newWidth">int Largura (pixels)</param>
        /// <param name="newHeight">int Altura  (pixels)</param>
        /// <returns>System.Drawing.Image</returns>
        public static System.Drawing.Image RedimensionarImagem(System.Drawing.Image srcImage, int newWidth, int newHeight, PixelFormat pf)
        {
            if (srcImage != null)
            {
                Bitmap newImage = new Bitmap(newWidth, newHeight, pf);
                newImage.MakeTransparent();
                using (Graphics gr = Graphics.FromImage((Image)newImage))
                {
                    //gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage(srcImage, 0, 0, newWidth, newHeight);// new Rectangle(0, 0, newWidth, newHeight));
                    gr.Dispose();
                    return (Image)newImage;
                }
            }
            else
                return null;

        }

        /// <summary>
        /// Redimensiona uma imagem
        /// </summary>
        public static System.Drawing.Image RedimensionarImagem(System.Drawing.Image img, decimal percentual)
        {
            if (img != null)
            {
                int nW = (int)(img.Width * percentual / 100);
                int nH = (int)(img.Height * percentual / 100);
                return RedimensionarImagem(img, nW, nH);
            }
            else return null;

        }

        /// <summary>
        /// Redimensiona uma imagem
        /// </summary>
        public static System.Drawing.Image RedimensionarImagem(System.Drawing.Image img, int limite, char c)
        {
            if (c == 'h' || c == 'H')
            {
                if (img.Height > limite)
                {
                    int delta = img.Height - limite;
                    decimal percent = 100 - (delta * 100 / img.Height);
                    percent = percent < 0 ? percent + 100 : percent;

                    return RedimensionarImagem(img, percent);
                }
                else
                    return img;

            }
            else
            {
                if (img.Width > limite)
                {
                    int delta = img.Width - limite;
                    decimal percent = delta * 100 / img.Width;
                    percent = percent < 0 ? percent + 100 : percent;
                    return RedimensionarImagem(img, percent);
                }
                return img;
            }


        }

    }
}
