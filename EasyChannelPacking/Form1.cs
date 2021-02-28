using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;



namespace EasyChannelPacking
{
    public partial class FormEasyChannelPacking : Form
    {
        struct Pack
        {
           public Bitmap bmpR;
           public Bitmap bmpG;
           public Bitmap bmpB;
           public Bitmap bmpA;
           public Bitmap bmpPack;
            public bool Sucess;
        }

        Pack pack;

        public FormEasyChannelPacking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //myStringR = inputImageR.Channel; //inputChannelR.GetItemText(inputChannelR.SelectedItem);
            //myStringG = inputImageG.Channel; //inputChannelG.GetItemText(inputChannelG.SelectedItem);
            //myStringB = inputImageB.Channel; //inputChannelB.GetItemText(inputChannelB.SelectedItem);
            //myStringA = inputImageA.Channel; //inputChannelA.GetItemText(inputChannelA.SelectedItem);

            //invertR = inputImageR.Invert;
            //invertG = inputImageG.Invert;
            //invertB = inputImageB.Invert;
            //invertA = inputImageA.Invert;

            timerProcessa.Enabled = false;
            timerProcessa.Enabled = true;
        }

       

        Bitmap bmpUnpack;
        Bitmap bmpUnpackR;
        Bitmap bmpUnpackG;
        Bitmap bmpUnpackB;
        Bitmap bmpUnpackA;
        bool cancelWork = false;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            cancelWork = false;
            Pack p = (Pack)e.Argument;

            Bitmap bmpRef = pack.bmpR ?? pack.bmpG ?? pack.bmpB ?? pack.bmpA;

            if (bmpRef != null)
            {
                int progress = 0;
                int totalprogress = bmpRef.Width * bmpRef.Height;
                int percent;
                bool report = true;
                Color rX;
                Color gX;
                Color bX;
                Color aX;

                for (int i = 0; i < bmpRef.Width; i++)
                {
                    for (int j = 0; j < bmpRef.Height; j++)
                    {
                        rX = p.bmpR != null && p.bmpR.Width > i && p.bmpR.Height > j ? p.bmpR?.GetPixel(i, j) ?? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 0, 0, 0);
                        gX = p.bmpG != null && p.bmpG.Width > i && p.bmpG.Height > j ? p.bmpG?.GetPixel(i, j) ?? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 0, 0, 0);
                        bX = p.bmpB != null && p.bmpB.Width > i && p.bmpB.Height > j ? p.bmpB?.GetPixel(i, j) ?? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 0, 0, 0);
                        aX = p.bmpA != null && p.bmpA.Width > i && p.bmpA.Height > j ? p.bmpA?.GetPixel(i, j) ?? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 0, 0, 0);

                        p.bmpPack.SetPixel(i, j, Color.FromArgb(aX.A, rX.R, gX.G, bX.B));

                        progress++;


                        if (e.Cancel || cancelWork)
                            break;
                    }

                    report = !report;
                    if (report)
                    {
                        percent = (progress * 100) / totalprogress;
                        backgroundWorker1.ReportProgress(percent);
                    }

                    if (e.Cancel || cancelWork)
                        break;
                }

                p.Sucess = !(e.Cancel || cancelWork);

                
            }
            else
            {
                p.Sucess = true;
                
            }
            e.Result = p;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;

            if (e.Error == null)
            {
                pack = (Pack)e.Result;

                if (pack.Sucess)
                {
                    outBox.Image = pack.bmpPack;
                    SaveButton.Visible = true;
                }
                else
                {
                    
                    timerProcessa.Enabled = false;
                    timerProcessa.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(e.Error.Message, "Erro ao processar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog diag = new SaveFileDialog())
            {
                diag.RestoreDirectory = true;
                diag.Title = "Select save location";
                diag.FileName = "packed.png";
                if(diag.ShowDialog() == DialogResult.OK)
                {
                   pack.bmpPack.Save(diag.FileName, ImageFormat.Png);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //OutPutImage.Image = inputImageR.myImage;
            bmpUnpack = (Bitmap)inputImageUnpack.myImage;
            bmpUnpackR = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);
            bmpUnpackG = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);
            bmpUnpackB = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);
            bmpUnpackA = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);

            //myStringR = inputImageR.Channel;//inputChannelR.GetItemText(inputChannelR.SelectedItem);
            //myStringG = inputImageG.Channel;//inputChannelG.GetItemText(inputChannelG.SelectedItem);
            //myStringB = inputImageB.Channel;//inputChannelB.GetItemText(inputChannelB.SelectedItem);
            //myStringA = inputImageA.Channel;// inputChannelA.GetItemText(inputChannelA.SelectedItem);

            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }



        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int progressUnpack = 0;
            int totalprogressUnpack = bmpUnpack.Width * bmpUnpack.Height;
            int percentUnpack;

            Color uX;

            for (int i = 0; i < bmpUnpack.Width; i++)
            {
                for (int j = 0; j < bmpUnpack.Height; j++)
                {
                    uX = bmpUnpack.GetPixel(i, j);
                    
                    bmpUnpackR.SetPixel(i, j, Color.FromArgb(255, uX.R, uX.R, uX.R));
                    bmpUnpackG.SetPixel(i, j, Color.FromArgb(255, uX.G, uX.G, uX.G));
                    bmpUnpackB.SetPixel(i, j, Color.FromArgb(255, uX.B, uX.B, uX.B));
                    bmpUnpackA.SetPixel(i, j, Color.FromArgb(255, uX.A, uX.A, uX.A));

                    progressUnpack++;
                    percentUnpack = (progressUnpack * 100) / totalprogressUnpack;
                    backgroundWorker2.ReportProgress(percentUnpack);
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar2.Value = 0;
            unpackOutR.Image = bmpUnpackR;
            unpackOutG.Image = bmpUnpackG;
            unpackOutB.Image = bmpUnpackB;
            unpackOutA.Image = bmpUnpackA;
            
            saveR.Visible = true;
            saveG.Visible = true;
            saveB.Visible = true;
            saveA.Visible = true;
        }

        private void saveR_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog diag = new SaveFileDialog())
            {
                diag.RestoreDirectory = true;
                diag.Title = "Select save location";
                diag.FileName = "R_Channel_Extracted.png";
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    bmpUnpackR.Save(diag.FileName, ImageFormat.Png);
                }
            }
        }

        private void saveG_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog diag = new SaveFileDialog())
            {
                diag.RestoreDirectory = true;
                diag.Title = "Select save location";
                diag.FileName = "G_Channel_Extracted.png";
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    bmpUnpackG.Save(diag.FileName, ImageFormat.Png);
                }
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog diag = new SaveFileDialog())
            {
                diag.RestoreDirectory = true;
                diag.Title = "Select save location";
                diag.FileName = "B_Channel_Extracted.png";
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    bmpUnpackB.Save(diag.FileName, ImageFormat.Png);
                }
            }
        }

        private void saveA_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog diag = new SaveFileDialog())
            {
                diag.RestoreDirectory = true;
                diag.Title = "Select save location";
                diag.FileName = "A_Channel_Extracted.png";
                if (diag.ShowDialog() == DialogResult.OK)
                {
                    bmpUnpackA.Save(diag.FileName, ImageFormat.Png);
                }
            }
        }


        private void inputImageR_ImageProcessComplete(object sender, EventArgs e)
        {
            
            timerProcessa.Enabled = false;
            timerProcessa.Enabled = true;
            
        }

        private void inputImageR_ChannelChanged(object sender, EventArgs e)
        {
            timerProcessa.Enabled = false;
            timerProcessa.Enabled = true;
        }

        private void comboBoxImageMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxImageMode.SelectedIndex == 1)
            {
                outBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBoxImageMode.SelectedIndex == 2)
            {
                outBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (comboBoxImageMode.SelectedIndex == 3)
            {
                outBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                outBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void timerProcessa_Tick(object sender, EventArgs e)
        {
            timerProcessa.Enabled = false;
            if (!backgroundWorker1.IsBusy)
            {
                pack = new Pack();

                pack.bmpR = (Bitmap)inputImageR.GetImage;
                pack.bmpG = (Bitmap)inputImageG.GetImage;
                pack.bmpB = (Bitmap)inputImageB.GetImage;
                pack.bmpA = (Bitmap)inputImageA.GetImage;


                Bitmap bmpRef = pack.bmpR ?? pack.bmpG ?? pack.bmpB ?? pack.bmpA;

                if (bmpRef != null)
                {
                    pack.bmpPack = new Bitmap(bmpRef.Width, bmpRef.Height);
                    backgroundWorker1.RunWorkerAsync(pack);
                }
            }
            else
            {
                cancelWork = true;
                backgroundWorker1.CancelAsync();
                timerProcessa.Enabled = false;
                timerProcessa.Enabled = true;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/rovann-linhalis-1124aa118/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/matheusdalla/");
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            int newW = flowLayoutPanel1.Width / 4 - 15;
            inputImageA.Width =
                inputImageB.Width =
                inputImageG.Width =
                inputImageR.Width = newW;

            inputImageA.Height  =
                inputImageB.Height =
                inputImageG.Height =
                inputImageR.Height = flowLayoutPanel1.Height - 15;



            //if (flowLayoutPanel1.Width < inputImageA.Width * 4)
            //{
            //    flowLayoutPanel1.Height = inputImageA.Height * 2 + 15;
            //}
            //else
            //{

            //    flowLayoutPanel1.Height = inputImageA.Height + 15;
            //}

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
