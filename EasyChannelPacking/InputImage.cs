using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyChannelPacking
{
    public partial class InputImage : UserControl
    {
        
        public Image myImage;

        public Image initialImage;
        
        private Bitmap bmpA;
        private Bitmap bmpR;
        private Bitmap bmpG;
        private Bitmap bmpB;

        [Editor]
        public string Caption { get => groupBox1.Text; set => groupBox1.Text = value; }
        [Editor]
        public string Channel { get => comboChannel.Text; set => comboChannel.Text = value; }
        [Editor]
        public bool Invert { get => checkBoxinvert.Checked; set => checkBoxinvert.Checked = value; }
        public bool CanInvert { get => checkBoxinvert.Visible; set => checkBoxinvert.Visible = value; }

        public bool ChannelVisible { get => comboChannel.Visible; set => comboChannel.Visible = value; }
        
        public Bitmap BmpR { get => bmpR; }
        public Bitmap BmpG { get => bmpG; }
        public Bitmap BmpB { get => bmpB; }
        public Bitmap BmpA { get => bmpA; }
        public bool ForceAlpha100 { get; set; }

        public delegate void ImageProcessCompleteEventHandler(Object sender, EventArgs e);
        public event ImageProcessCompleteEventHandler ImageProcessComplete;


        public delegate void ChannelChangedEventHandler(Object sender, EventArgs e);
        public event ChannelChangedEventHandler ChannelChanged;

        public struct TImageProcess
        {
            public int Part;
            public Bitmap Source;
            public Bitmap BmpR;
            public Bitmap BmpG;
            public Bitmap BmpB;
            public Bitmap BmpA;
        }


        public Bitmap GetImage
        {
            get => backgroundWorkerProcessaImagem.IsBusy? null : ( this.Channel == "R" ? this.BmpR : this.Channel == "G" ? this.BmpG : this.Channel == "B" ? this.BmpB : this.BmpA);
        }


        public InputImage()
        {
            InitializeComponent();
            myImage = (Bitmap)pictureBox1.Image;
            initialImage = myImage;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.RestoreDirectory = true;
                diag.Multiselect = false;
                diag.Title = "Select a image";
                diag.Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg";

                if (diag.ShowDialog() == DialogResult.OK)
                {
                    //diag.FileName
                    CarregarImagem(diag.FileName);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string arquivo = files[0];
                CarregarImagem(arquivo);
            }
        }


        bool cancel = false;
        public void CarregarImagem(string arquivo)
        {
            if (!String.IsNullOrWhiteSpace(arquivo))
            {
                myImage = (Bitmap)Bitmap.FromFile(arquivo);
                pictureBox1.Image = myImage;
            }
            else
            {
                bmpA =
            bmpR =
            bmpG =
            bmpB = null;
                myImage = null;
                pictureBox1.Image = initialImage; 
                
            }
            

            if (backgroundWorkerProcessaImagem.IsBusy)
            {
                backgroundWorkerProcessaImagem.CancelAsync();
                cancel = true;
            }
            else
            {
                Bitmap bmp = myImage == null ? null : new Bitmap(myImage);
                backgroundWorkerProcessaImagem.RunWorkerAsync(bmp);
            }

        }

        private void backgroundWorkerProcessaImagem_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap ImgCache = e.Argument as Bitmap;
            bool parallel = true;
            if (parallel)
            {
                DateTime start = DateTime.Now;
                List<TImageProcess> arrayBmp = new List<TImageProcess>(2);
                List<TImageProcess> arrayResultBmp = new List<TImageProcess>(2);
                int nw = ImgCache.Width / 2;
                int dif = ImgCache.Width - (nw * 2);
                Bitmap p1 =  new Bitmap(nw, ImgCache.Height);
                Bitmap p2 = new Bitmap(nw + dif, ImgCache.Height);
                
                arrayBmp.Add(new TImageProcess() {Source = p1, Part = 1 });
                arrayBmp.Add(new TImageProcess() { Source = p2, Part =2 });

                using (Graphics g = Graphics.FromImage(arrayBmp[0].Source))
                {
                    g.DrawImage(ImgCache, new Rectangle() { Height = ImgCache.Height, Width = arrayBmp[0].Source.Width, X = 0, Y = 0 }, new Rectangle() { Height = ImgCache.Height, Width = nw, X = 0, Y = 0 }, GraphicsUnit.Pixel);
                }
                using (Graphics g = Graphics.FromImage(arrayBmp[1].Source))
                {
                    g.DrawImage(ImgCache, new Rectangle() { Height = ImgCache.Height, Width = arrayBmp[1].Source.Width, X = 0, Y = 0 }, new Rectangle() { Height = ImgCache.Height, Width = nw+dif, X = arrayBmp[0].Source.Width + dif, Y = 0 }, GraphicsUnit.Pixel);
                }

                Parallel.ForEach(arrayBmp, img =>
                {

                    if (img.Source != null)
                    {
                        Color pixel;

                        img.BmpR = new Bitmap(img.Source.Width, img.Source.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        img.BmpG = new Bitmap(img.BmpR);
                        img.BmpB = new Bitmap(img.BmpR);
                        img.BmpA = new Bitmap(img.BmpR);
                        int total = img.Source.Width * img.Source.Height;
                        bool report = true;
                        int p = 0;
                        for (int x = 0; x < img.Source.Width; x++)
                        {
                            for (int y = 0; y < img.Source.Height; y++)
                            {
                                pixel = img.Source.GetPixel(x, y);

                                //bmpR.SetPixel(x, y, Color.FromArgb(255, pixel.R, 0, 0));
                                //bmpG.SetPixel(x, y, Color.FromArgb(255, 0, pixel.G, 0));
                                //bmpB.SetPixel(x, y, Color.FromArgb(255, 0, 0, pixel.B));
                                //bmpA.SetPixel(x, y, Color.FromArgb(pixel.A, 0, 0, 0));

                                if (Invert) //IF it should invert color
                                {
                                    if (img.BmpR != null)
                                        img.BmpR.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.R, 255 - pixel.R, 255 - pixel.R, 255 - pixel.R));
                                    if (img.BmpG != null)
                                        img.BmpG.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.G, 255 - pixel.G, 255 - pixel.G, 255 - pixel.G));
                                    if (img.BmpB != null)
                                        img.BmpB.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.B, 255 - pixel.B, 255 - pixel.B, 255 - pixel.B));
                                    if (img.BmpA != null)
                                        img.BmpA.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.A, 255 - pixel.A, 255 - pixel.A, 255 - pixel.A));
                                }
                                else
                                {
                                    if (img.BmpR != null)
                                        img.BmpR.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.R, pixel.R, pixel.R, pixel.R));
                                    if (img.BmpG != null)
                                        img.BmpG.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.G, pixel.G, pixel.G, pixel.G));
                                    if (img.BmpB != null)
                                        img.BmpB.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.B, pixel.B, pixel.B, pixel.B));
                                    if (img.BmpA != null)
                                        img.BmpA.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.A, pixel.A, pixel.A, pixel.A));
                                }



                                //bmpR.SetPixel(x, y, Color.FromArgb(255, pixel.R, pixel.R, pixel.R));
                                //bmpG.SetPixel(x, y, Color.FromArgb(255, pixel.G, pixel.G, pixel.G));
                                //bmpB.SetPixel(x, y, Color.FromArgb(255, pixel.B, pixel.B, pixel.B));
                                //bmpA.SetPixel(x, y, Color.FromArgb(pixel.A, pixel.A, pixel.A, pixel.A));

                                if (cancel)
                                {
                                    break;
                                }

                                p++;

                            }

                            report = !report;

                            if (report)
                            {
                                backgroundWorkerProcessaImagem.ReportProgress((p * 100) / total);
                            }

                            if (cancel)
                            {
                                break;
                            }
                        }
                    }


                    arrayResultBmp.Add(img);
                });


                bmpR = new Bitmap(ImgCache.Width, ImgCache.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                bmpG = new Bitmap(bmpR);
                bmpB = new Bitmap(bmpR);
                bmpA = new Bitmap(bmpR);


                using (Graphics g = Graphics.FromImage(bmpR))
                {
                    g.DrawImage(arrayResultBmp.Where(x=>x.Part==1).FirstOrDefault().BmpR, 0, 0);
                    g.DrawImage(arrayResultBmp.Where(x => x.Part == 2).FirstOrDefault().BmpR, arrayBmp[0].Source.Width , 0);
                }
                using (Graphics g = Graphics.FromImage(bmpG))
                {
                    g.DrawImage(arrayResultBmp.Where(x=>x.Part==1).FirstOrDefault().BmpG, 0, 0);
                    g.DrawImage(arrayResultBmp.Where(x => x.Part == 2).FirstOrDefault().BmpG, arrayBmp[0].Source.Width , 0);
                }
                using (Graphics g = Graphics.FromImage(bmpB))
                {
                    g.DrawImage(arrayResultBmp.Where(x=>x.Part==1).FirstOrDefault().BmpB, 0, 0);
                    g.DrawImage(arrayResultBmp.Where(x => x.Part == 2).FirstOrDefault().BmpB, arrayBmp[0].Source.Width , 0);
                }
                using (Graphics g = Graphics.FromImage(bmpA))
                {
                    g.DrawImage(arrayResultBmp.Where(x=>x.Part==1).FirstOrDefault().BmpA, 0, 0);
                    g.DrawImage(arrayResultBmp.Where(x => x.Part == 2).FirstOrDefault().BmpA, arrayBmp[0].Source.Width , 0);
                }

                TimeSpan dur = DateTime.Now - start;

                string pause = ";";

            }
            else
            {
                cancel = false;
                DateTime start = DateTime.Now;
                if (ImgCache != null)
                {
                    Color pixel;

                    bmpR = new Bitmap(ImgCache.Width, ImgCache.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    bmpG = new Bitmap(bmpR);
                    bmpB = new Bitmap(bmpR);
                    bmpA = new Bitmap(bmpR);
                    int total = ImgCache.Width * ImgCache.Height;
                    bool report = true;
                    int p = 0;
                    for (int x = 0; x < ImgCache.Width; x++)
                    {
                        for (int y = 0; y < ImgCache.Height; y++)
                        {
                            pixel = ImgCache.GetPixel(x, y);

                            //bmpR.SetPixel(x, y, Color.FromArgb(255, pixel.R, 0, 0));
                            //bmpG.SetPixel(x, y, Color.FromArgb(255, 0, pixel.G, 0));
                            //bmpB.SetPixel(x, y, Color.FromArgb(255, 0, 0, pixel.B));
                            //bmpA.SetPixel(x, y, Color.FromArgb(pixel.A, 0, 0, 0));

                            if (Invert) //IF it should invert color
                            {
                                if (bmpR != null)
                                    bmpR.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.R, 255 - pixel.R, 255 - pixel.R, 255 - pixel.R));
                                if (bmpG != null)
                                    bmpG.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.G, 255 - pixel.G, 255 - pixel.G, 255 - pixel.G));
                                if (bmpB != null)
                                    bmpB.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.B, 255 - pixel.B, 255 - pixel.B, 255 - pixel.B));
                                if (bmpA != null)
                                    bmpA.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : 255 - pixel.A, 255 - pixel.A, 255 - pixel.A, 255 - pixel.A));
                            }
                            else
                            {
                                if (bmpR != null)
                                    bmpR.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.R, pixel.R, pixel.R, pixel.R));
                                if (bmpG != null)
                                    bmpG.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.G, pixel.G, pixel.G, pixel.G));
                                if (bmpB != null)
                                    bmpB.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.B, pixel.B, pixel.B, pixel.B));
                                if (bmpA != null)
                                    bmpA.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.A, pixel.A, pixel.A, pixel.A));
                            }



                            //bmpR.SetPixel(x, y, Color.FromArgb(255, pixel.R, pixel.R, pixel.R));
                            //bmpG.SetPixel(x, y, Color.FromArgb(255, pixel.G, pixel.G, pixel.G));
                            //bmpB.SetPixel(x, y, Color.FromArgb(255, pixel.B, pixel.B, pixel.B));
                            //bmpA.SetPixel(x, y, Color.FromArgb(pixel.A, pixel.A, pixel.A, pixel.A));

                            if (cancel)
                            {
                                break;
                            }

                            p++;

                        }

                        report = !report;

                        if (report)
                        {
                            backgroundWorkerProcessaImagem.ReportProgress((p * 100) / total);
                        }

                        if (cancel)
                        {
                            break;
                        }
                    }
                }
                TimeSpan dur = DateTime.Now - start;
                string pause = ";";
            }
            e.Result = !cancel;
        }

        private void backgroundWorkerProcessaImagem_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            if (e.Error == null)
            {
                if ((bool)e.Result == true)
                {
                    if (ImageProcessComplete != null)
                        ImageProcessComplete(this, new EventArgs());
                }
                else
                {
                    Bitmap bmp = myImage == null ? null : new Bitmap(myImage);
                    backgroundWorkerProcessaImagem.RunWorkerAsync(bmp);
                }
            }
            else
            {
                MessageBox.Show(e.Error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorkerProcessaImagem_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void comboChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChannelChanged!=null)
            {
                ChannelChanged(this, new EventArgs());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (myImage !=null)
                CarregarImagem(null);
            
        }

        private void InputImage_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void InputImage_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void InputImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string arquivo = files[0];
                CarregarImagem(arquivo);
            }

        }

        private void InputImage_Resize(object sender, EventArgs e)
        {
            
        }

        private void checkBoxinvert_CheckedChanged(object sender, EventArgs e)
        {

            //Update image processing
            if (backgroundWorkerProcessaImagem.IsBusy)
            {
                backgroundWorkerProcessaImagem.CancelAsync();
                cancel = true;
            }
            else
            {
                Bitmap bmp = myImage == null ? null : new Bitmap(myImage);
                backgroundWorkerProcessaImagem.RunWorkerAsync(bmp);
            }
        }
    }
}
