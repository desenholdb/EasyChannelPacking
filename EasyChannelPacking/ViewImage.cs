using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace EasyChannelPacking
{
    public partial class ViewImage : UserControl
    {
        public ViewImage()
        {
            InitializeComponent();
        }

        public Image Image { get => pictureBox1.Image; set => pictureBox1.Image = value; }
        public PictureBox Pb { get => pictureBox1; set => pictureBox1 = value; }
        public string Caption { get => groupBox1.Text; set => groupBox1.Text = value; }
        public string ImageDescription { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                using (SaveFileDialog diag = new SaveFileDialog())
                {
                    diag.RestoreDirectory = true;
                    diag.Title = "Select save location";
                    diag.FileName = this.ImageDescription?.ToString() ?? "Image" + "_Extracted.png";
                    diag.Filter = "Png file|*.png";
                    if (diag.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(diag.FileName, ImageFormat.Png);
                    }
                }
            }
        }
    }
}
