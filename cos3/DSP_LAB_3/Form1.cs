using CGALabs;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSP_Lab_3.Filters;

namespace DSP_LAB_3
{
    public partial class Form1 : Form
    {
        private FastBitmap _fastBitmap;
        private static int _windowSize;

        public Form1()
        {
            InitializeComponent();
            pbSourceImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFilteredImage.SizeMode = PictureBoxSizeMode.StretchImage;
            var styles = tableLayoutPanel1.ColumnStyles;

            foreach (ColumnStyle style in styles)
            {
                switch (style.SizeType)
                {
                    case SizeType.Absolute:
                        style.SizeType = SizeType.Percent;
                        break;
                    case SizeType.AutoSize:
                        style.SizeType = SizeType.Percent;
                        break;
                    case SizeType.Percent:
                        break;
                    default:
                        style.SizeType = SizeType.Percent;
                        break;
                }
                style.Width = 50;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            var bitmap = new Bitmap(openFileDialog.FileName);
            _fastBitmap?.Dispose();
            _fastBitmap = new FastBitmap(bitmap);
            bitmap.Dispose();
            pbSourceImage.Image = _fastBitmap.Bitmap;
            pbFilteredImage.Image?.Dispose();
            pbFilteredImage.Image = null;
        }
        private void btnGaussianFilter_Click(object sender, EventArgs e)
        {
            _windowSize = Convert.ToInt32(tbWindowSize.Text);
            var sigma = Convert.ToDouble(tbSigma.Text);
            pbFilteredImage.Image = GaussianFilter.Process(_fastBitmap, sigma);
        }

        private void btnSobelFilter_Click(object sender, EventArgs e)
        {
            pbFilteredImage.Image = SobelFilter2.Process(_fastBitmap.Bitmap);
            //pbFilteredImage.Image = SobelFilter.Process(_fastBitmap);
        }

        

        private void btnMedian_Click(object sender, EventArgs e)
        {
            _windowSize = Convert.ToInt32(tbWindowSize.Text);
            pbFilteredImage.Image = MedianFilter.Process(_fastBitmap.Bitmap, _windowSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _windowSize = Convert.ToInt32(tbWindowSize.Text);
            pbFilteredImage.Image = BoxBlurFilter.Process(_fastBitmap.Bitmap, _windowSize);

        }
    }
}