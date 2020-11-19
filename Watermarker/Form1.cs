using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Imaging;

namespace Watermarker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG files |*.jpg";
            openFileDialog1.Title = "Select source image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textSource.Text = openFileDialog1.FileName;
            }
            CheckValid();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            try
            {
                //Immagine
                Bitmap myBitmap = new Bitmap(textSource.Text);
                Graphics g = Graphics.FromImage(myBitmap);
                g.CompositingQuality = CompositingQuality.HighQuality;

                //Nome file destinazione
                string destinationDirectory = Path.GetDirectoryName(textSource.Text);
                string destinationFile = Path.GetFileNameWithoutExtension(textSource.Text);
                string destinationExtension = Path.GetExtension(textSource.Text);
                string suffix = "_watermark";
                if (textSuffix.Text != string.Empty)    suffix = textSuffix.Text;
                string destination = destinationDirectory + "\\" + destinationFile + suffix + destinationExtension;

                //Se testo
                if (radioText.Checked)
                {
                    //Posizione
                    StringFormat strFormat = new StringFormat();
                    strFormat.Alignment = StringAlignment.Center;
                    strFormat.LineAlignment = StringAlignment.Center;
                    if (checkAlign1.Checked) { strFormat.Alignment = StringAlignment.Near; strFormat.LineAlignment = StringAlignment.Near; }
                    if (checkAlign2.Checked) { strFormat.Alignment = StringAlignment.Center; strFormat.LineAlignment = StringAlignment.Near; }
                    if (checkAlign3.Checked) { strFormat.Alignment = StringAlignment.Far; strFormat.LineAlignment = StringAlignment.Near; }
                    if (checkAlign4.Checked) { strFormat.Alignment = StringAlignment.Near; strFormat.LineAlignment = StringAlignment.Center; }
                    if (checkAlign5.Checked) { strFormat.Alignment = StringAlignment.Center; strFormat.LineAlignment = StringAlignment.Center; }
                    if (checkAlign6.Checked) { strFormat.Alignment = StringAlignment.Far; strFormat.LineAlignment = StringAlignment.Center; }
                    if (checkAlign7.Checked) { strFormat.Alignment = StringAlignment.Near; strFormat.LineAlignment = StringAlignment.Far; }
                    if (checkAlign8.Checked) { strFormat.Alignment = StringAlignment.Center; strFormat.LineAlignment = StringAlignment.Far; }
                    if (checkAlign9.Checked) { strFormat.Alignment = StringAlignment.Far; strFormat.LineAlignment = StringAlignment.Far; }

                    //Colore
                    Color newColor = Color.FromArgb(trackAlpha.Value, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);

                    //Stringa
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    if (checkShadow.Checked)
                    {
                        g.DrawString(textWatermark.Text, fontDialog1.Font, Brushes.Black, new RectangleF(0, 0, Convert.ToSingle(g.VisibleClipBounds.Width) + Convert.ToInt32(textOffsetX.Text) + 2, Convert.ToSingle(g.VisibleClipBounds.Height) + Convert.ToInt32(textOffsetY.Text) + 2), strFormat);
                    }
                    g.DrawString(textWatermark.Text, fontDialog1.Font, new SolidBrush(newColor), new RectangleF(0, 0, Convert.ToSingle(g.VisibleClipBounds.Width) + Convert.ToInt32(textOffsetX.Text), Convert.ToSingle(g.VisibleClipBounds.Height) + Convert.ToInt32(textOffsetY.Text)), strFormat);
                }

                //Se Immagine
                if (radioImage.Checked)
                {
                    Bitmap logoBitmap = new Bitmap(textImage.Text);
                    int logoHeight = logoBitmap.Size.Height;
                    int logoWidth = logoBitmap.Size.Width;
                    int myHeight = myBitmap.Size.Height;
                    int myWidth = myBitmap.Size.Width;
                    int posX = 0;
                    int posY = 0;

                    if (checkAlign1.Checked) { posX = 0; posY = 0; }
                    if (checkAlign2.Checked) { posX = (myWidth / 2) - (logoWidth / 2); posY = 0; }
                    if (checkAlign3.Checked) { posX = myWidth - logoWidth; posY = 0; }

                    if (checkAlign4.Checked) { posX = 0; posY = (myHeight / 2) - (logoHeight / 2); }
                    if (checkAlign5.Checked) { posX = (myWidth / 2) - (logoWidth / 2); posY = (myHeight / 2) - (logoHeight / 2); }
                    if (checkAlign6.Checked) { posX = myWidth - logoWidth; posY = posY = (myHeight / 2) - (logoHeight / 2); }

                    if (checkAlign7.Checked) { posX = 0; posY = myHeight - logoHeight; }
                    if (checkAlign8.Checked) { posX = (myWidth / 2) - (logoWidth / 2); posY = myHeight - logoHeight; }
                    if (checkAlign9.Checked) { posX = myWidth - logoWidth; posY = myHeight - logoHeight; }


                    float [][] items = new float[][] {
	                    new float[] {Convert.ToSingle(Convert.ToSingle( colorDialog1.Color.R) / 255.0f), 0, 0, 0, 0},
	                    new float[] {0, Convert.ToSingle(Convert.ToSingle( colorDialog1.Color.G) / 255.0f), 0, 0, 0},
	                    new float[] {0, 0, Convert.ToSingle(Convert.ToSingle( colorDialog1.Color.B) / 255.0f), 0, 0},
	                    new float[] {0, 0, 0, Convert.ToSingle(Convert.ToSingle(trackAlpha.Value) / 255.0f) , 0},
	                    new float[] {0, 0, 0, 0, 1}
                      };

                    System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(items);
                    System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
                    ia.SetColorMatrix(colorMatrix);

                    g.DrawImage(logoBitmap, new Rectangle(posX + Convert.ToInt32(textOffsetX.Text), posY + Convert.ToInt32(textOffsetY.Text), logoWidth, logoHeight), 0, 0, logoWidth, logoHeight, GraphicsUnit.Pixel, ia, null, new System.IntPtr());
                }

                //Resize
                if (checkResize.Checked)
                {
                    Bitmap newBitmap = ResizeImage((Image)myBitmap, new Size(Convert.ToInt32(textWidth.Text), Convert.ToInt32(textHeight.Text)), InterpolationMode.HighQualityBicubic);
                    Graphics gNew = Graphics.FromImage(newBitmap);
                    newBitmap.Save(destination);
                    newBitmap.Dispose();
                    gNew.Dispose();
                }
                else
                {
                    //Salvataggio
                    myBitmap.Save(destination);
                    myBitmap.Dispose();
                    g.Dispose();
                }

                Cursor = Cursors.Arrow;
                if (MessageBox.Show(@"Image watermarked successfully. Open destination directory?", "Watermarker", MessageBoxButtons.YesNo, MessageBoxIcon.Information ) == DialogResult.Yes)
                {
                    Process.Start("explorer", destinationDirectory);
                }
            }
            catch
            {
                Cursor = Cursors.Arrow;
                MessageBox.Show("Error during process image", "Watermarker", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.SolidColorOnly = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = colorDialog1.Color;
        }

        private void CheckValid()
        {
            if (File.Exists(textSource.Text))
            {
                if ((radioImage.Checked) && (File.Exists(textImage.Text)))
                    buttonStart.Enabled = true;
                else if ((radioImage.Checked) && (!File.Exists(textImage.Text)))
                    buttonStart.Enabled = false;
                else
                    buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private static Bitmap ResizeImage(Image imgToResize, Size size, InterpolationMode interpolationMode)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = interpolationMode;
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return b;
        }

        private void checkResize_CheckedChanged(object sender, EventArgs e)
        {
            textWidth.Enabled = checkResize.Checked;
            textHeight.Enabled = checkResize.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Font = fontDialog1.Font;
            Properties.Settings.Default.Color = colorDialog1.Color;
            Properties.Settings.Default.Save();
        }

        private void textSource_TextChanged(object sender, EventArgs e)
        {
            CheckValid();
        }

        private void checkShadow_CheckedChanged(object sender, EventArgs e)
        {
            textShadowOffset.Enabled = checkShadow.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Assembly.GetExecutingAssembly().GetName(false).Name.ToString() + " " + Assembly.GetExecutingAssembly().GetName(false).Version.ToString();
            labelAlpha.Text = Properties.Settings.Default.Alpha.ToString();
            radioImage.Checked = Properties.Settings.Default.WatermarkImage;
        }

        private void trackAlpha_Scroll(object sender, EventArgs e)
        {
            labelAlpha.Text = trackAlpha.Value.ToString();
        }

        private void buttonFont_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG files|*.png|GIF files |*.gif|JPEG files|*.jpg";
            openFileDialog1.Title = "Select watermark image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textImage.Text = openFileDialog1.FileName;
            }
            CheckValid();
        }

        private void radioImage_CheckedChanged(object sender, EventArgs e)
        {
            textImage.Enabled = radioImage.Checked;
            buttonImage.Enabled = radioImage.Checked;
            CheckValid();
        }

        private void radioText_CheckedChanged(object sender, EventArgs e)
        {
            textWatermark.Enabled = radioText.Checked;
            buttonFont.Enabled = radioText.Checked;
            CheckValid();
        }

        public bool SaveToJpeg(Image img, string filename, int quality)
        {
            try
            {
                if (quality > 0 || quality < 100)
                {
                    EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                    ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
                    EncoderParameters encoderParams = new EncoderParameters(1);
                    encoderParams.Param[0] = qualityParam;

                    img.Save(filename, jpegCodec, encoderParams);

                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.White;
            buttonColor.BackColor = Color.White;
        }
    }
}
