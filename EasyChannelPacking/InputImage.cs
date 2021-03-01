﻿using System;
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

        [Editor]
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
            cancel = false;
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

                        if (bmpR != null)
                            bmpR.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.R, pixel.R, pixel.R, pixel.R));
                        if (bmpG != null)
                            bmpG.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.G, pixel.G, pixel.G, pixel.G));
                        if (bmpB != null)
                            bmpB.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.B, pixel.B, pixel.B, pixel.B));
                        if (bmpA != null)
                            bmpA.SetPixel(x, y, Color.FromArgb(this.ForceAlpha100 ? 255 : pixel.A, pixel.A, pixel.A, pixel.A));


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
    }
}
