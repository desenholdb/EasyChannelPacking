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

        public InputImage()
        {
            InitializeComponent();
            myImage = pictureBox1.Image;
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

        public void CarregarImagem(string arquivo)
        {
            myImage = Image.FromFile(arquivo);
            pictureBox1.Image = myImage;
        }
        
    }
}
