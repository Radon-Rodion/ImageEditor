using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SPP_2
{
    public partial class Form1 : Form
    {
        const string FILE_CHOOSER_FILTER = "Bitmap images(*.bmp)|*.bmp|JPEG images(*.jpg)|*.jpg|All files(*.*)|*.*";

        Controller controller;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = FILE_CHOOSER_FILTER;
            saveFileDialog1.Filter = FILE_CHOOSER_FILTER;
            controller = new Controller(picture, penColor);
            Instrument = 1;
        }

        private int Instrument
        {
            set
            {
                if (controller.instrument != value)
                {
                    controller.instrument = value;
                    if (picture?.Image != null)
                    {
                        controller.UpdateBitmap(new Bitmap(picture.Image));
                    }
                    TracksToZero();
                }
            }
        }

        private void TracksToZero()
        {
            chromaticityTrack.Value = 0;
            brightnessTrack.Value = 0;
            contrastTrack.Value = 0;
        }

        private void lineWidthTrack_ValueChanged(object sender, EventArgs e)
        {
            controller.TrackChangesTextBox(lineWidthTrack, lineWidthBox);
            controller.SetPenWidth(lineWidthTrack.Value);
        }

        private void lineWidthBox_TextChanged(object sender, EventArgs e)
        {
            controller.TextBoxChangesTrack(lineWidthTrack, lineWidthBox);
            controller.SetPenWidth(lineWidthTrack.Value);
        }

        private void chromaticityTrack_ValueChanged(object sender, EventArgs e)
        {
            controller.TrackChangesTextBox(chromaticityTrack, chromaticityBox);
            Instrument = -1;
            controller.ChangeChromaticity((chromaticityTrack.Value / 128f)+1);
        }

        private void chromaticityBox_TextChanged(object sender, EventArgs e)
        {
            controller.TextBoxChangesTrack(chromaticityTrack, chromaticityBox);
        }

        private void brightnessBox_TextChanged(object sender, EventArgs e)
        {
            controller.TextBoxChangesTrack(brightnessTrack, brightnessBox);
        }

        private void brightnessTrack_ValueChanged(object sender, EventArgs e)
        {
            controller.TrackChangesTextBox(brightnessTrack, brightnessBox);
            Instrument = -2;
            controller.ChangeBrightness((brightnessTrack.Value/128f)+1);
        }

        private void contrastBox_TextChanged(object sender, EventArgs e)
        {
            controller.TextBoxChangesTrack(contrastTrack, contrastBox);
        }

        private void contrastTrack_ValueChanged(object sender, EventArgs e)
        {
            controller.TrackChangesTextBox(contrastTrack, contrastBox);
            Instrument = -3;
            controller.ChangeContrast((contrastTrack.Value / 128f));
        }
        

        //Color Buttons:
        private void whiteBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(whiteBtn.BackColor);
        }

        private void lgreyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(lgreyBtn.BackColor);
        }

        private void greyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(greyBtn.BackColor);
        }

        private void dgreyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(dgreyBtn.BackColor);
        }

        private void blackBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(blackBtn.BackColor);
        }

        private void redBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(redBtn.BackColor);
        }

        private void vineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(vineBtn.BackColor);
        }

        private void pinkBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(pinkBtn.BackColor);
        }

        private void purpleBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(purpleBtn.BackColor);
        }

        private void blueBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(blueBtn.BackColor);
        }

        private void yellowBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(yellowBtn.BackColor);
        }

        private void orangeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(orangeBtn.BackColor);
        }

        private void greenBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(greenBtn.BackColor);
        }

        private void limeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(limeBtn.BackColor);
        }

        private void skyBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.ChangeColor(skyBtn.BackColor);
        }

        //Color control buttons:
        private void penColor_MouseClick(object sender, MouseEventArgs e)
        {
            controller.SetColorControl(penColor);
        }

        private void brushColor_MouseClick(object sender, MouseEventArgs e)
        {
            controller.SetColorControl(brushColor);
        }

        //instrument buttons:
        private void penBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Instrument = 1;
        }

        private void reflectHorBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.Reflect(RotateFlipType.RotateNoneFlipX);
        }

        private void reflectVertBtn_MouseClick(object sender, MouseEventArgs e)
        {
            controller.Reflect(RotateFlipType.RotateNoneFlipY);
        }

        private void rotateBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                controller.RotateImage(controller.GetRotationAngle(this));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input param for rotation!");
            }
        }

        private void resizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                controller.Resize(controller.GetNewSize(this));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input params for resizing!");
            }
            
        }

        private void scaleBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                controller.ScaleImage(controller.GetScale(this));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input params for scaling!");
            }
        }

        //Menu buttons:
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.NewImage(brushColor.BackColor);
            Instrument = 1;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            controller.OpenImage(filename);
            Instrument = 1;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Instrument = 1;
            // сохраняем в  выбранный файл
            string saveAddr = saveFileDialog1.FileName;
            controller.SaveImage(saveAddr);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Image Editor v 1.0\n(c) Pavel Rafeyev (aka Rafael Pavlov)", "About program");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drawing:

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            controller.MouseClicked = true;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            controller.LineToPoint(e.X, e.Y);
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            controller.MouseClicked = false;
        }
    }
}
