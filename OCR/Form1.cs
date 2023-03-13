using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IronTesseract iron_ocr = new IronTesseract();
            var rslt = iron_ocr.Read("C:\\Users\\piriy\\OneDrive\\Desktop\\e.bmp");
            richTextBox1.Text = rslt.Text;
            pictureBox1.Image = new Bitmap("C:\\Users\\piriy\\OneDrive\\Desktop\\e.bmp");
        }
    }
}
