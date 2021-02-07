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
        public FormEasyChannelPacking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bmpR = (Bitmap)inputImageR.myImage;
            bmpG = (Bitmap)inputImageG.myImage;
            bmpB = (Bitmap)inputImageB.myImage;
            bmpA = (Bitmap)inputImageA.myImage;
            bmpPack = new Bitmap(bmpR.Width, bmpR.Height);

            myStringR = inputChannelR.GetItemText(inputChannelR.SelectedItem);
            myStringG = inputChannelG.GetItemText(inputChannelG.SelectedItem);
            myStringB = inputChannelB.GetItemText(inputChannelB.SelectedItem);
            myStringA = inputChannelA.GetItemText(inputChannelA.SelectedItem);

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        Bitmap bmpR;
        Bitmap bmpG;
        Bitmap bmpB;
        Bitmap bmpA;
        Bitmap bmpPack;

        Bitmap bmpUnpack;
        Bitmap bmpUnpackR;
        Bitmap bmpUnpackG;
        Bitmap bmpUnpackB;
        Bitmap bmpUnpackA;

        string myStringR;
        string myStringG;
        string myStringB;
        string myStringA;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;
            int totalprogress = bmpR.Width* bmpR.Height;
            int percent;

            Color rX;
            Color gX;
            Color bX;
            Color aX;
            Byte rC;
            Byte gC;
            Byte bC;
            Byte aC;


            for (int i = 0; i < bmpR.Width; i++)
            {
                for (int j = 0; j < bmpR.Height; j++)
                {
                    rX = bmpR.GetPixel(i, j);
                    gX = bmpG.GetPixel(i, j);
                    bX = bmpB.GetPixel(i, j);
                    aX = bmpA.GetPixel(i, j);

                    //SELECT CHANNEL FROM IMAGE R
                    if (myStringR == "G")
                    {
                        rC = rX.G;
                    }
                    else if (myStringR == "B")
                    {
                        rC = rX.B;
                    }
                    else if (myStringR == "A")
                    {
                        rC = rX.A;
                    }
                    else
                    {
                        rC = rX.R;
                    }
                    //END
                    //SELECT CHANNEL FROM IMAGE G
                    if (myStringG == "G")
                    {
                        gC = gX.G;
                    }
                    else if (myStringG == "B")
                    {
                        gC = gX.B;
                    }
                    else if (myStringG == "A")
                    {
                        gC = gX.A;
                    }
                    else
                    {
                        gC = gX.R;
                    }
                    //END
                    //SELECT CHANNEL FROM IMAGE B
                    if (myStringB == "G")
                    {
                        bC = bX.G;
                    }
                    else if (myStringB == "B")
                    {
                        bC = bX.B;
                    }
                    else if (myStringB == "A")
                    {
                        bC = bX.A;
                    }
                    else
                    {
                        bC = bX.R;
                    }
                    //END
                    //SELECT CHANNEL FROM IMAGE A
                    if (myStringA == "G")
                    {
                        aC = aX.G;
                    }
                    else if (myStringA == "B")
                    {
                        aC = aX.B;
                    }
                    else if (myStringA == "A")
                    {
                        aC = aX.A;
                    }
                    else
                    {
                        aC = aX.R;
                    }
                    //END
                    //CHECK IS INVERTED
                    if (invertR.Checked)
                    {
                        rC = (byte)(255 - (int)rC);
                    }
                    if (invertG.Checked)
                    {
                        gC = (byte)(255 - (int)gC);
                    }
                    if (invertB.Checked)
                    {
                        bC = (byte)(255 - (int)bC);
                    }
                    if (invertA.Checked)
                    {
                        aC = (byte)(255 - (int)aC);
                    }

                    bmpPack.SetPixel(i, j, Color.FromArgb(aC, rC, gC, bC));

                    progress++;
                    percent = (progress*100)/ totalprogress;
                    backgroundWorker1.ReportProgress(percent);
                }
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            outBox.Image = bmpPack;
            outBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SaveButton.Visible = true;
            //Image a = outBox.Image.RedimensionarImagem()
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
                    bmpPack.Save(diag.FileName, ImageFormat.Png);
                }
            }
        }

        private void invertG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inputImageR_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //OutPutImage.Image = inputImageR.myImage;
            bmpUnpack = (Bitmap)inputImageUnpack.myImage;
            bmpUnpackR = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);
            bmpUnpackG = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);
            bmpUnpackB = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);
            bmpUnpackA = new Bitmap(bmpUnpack.Width, bmpUnpack.Height);

            myStringR = inputChannelR.GetItemText(inputChannelR.SelectedItem);
            myStringG = inputChannelG.GetItemText(inputChannelG.SelectedItem);
            myStringB = inputChannelB.GetItemText(inputChannelB.SelectedItem);
            myStringA = inputChannelA.GetItemText(inputChannelA.SelectedItem);

            if (!backgroundWorker2.IsBusy)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/rovann-linhalis-1124aa118/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/matheusdalla/");
        }
    }
}
