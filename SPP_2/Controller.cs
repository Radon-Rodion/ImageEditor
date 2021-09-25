using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP_2
{ 
    public class Controller
    {
        internal int instrument;
        bool mouseClicked;
        public bool MouseClicked
        {
            private get
            {
                return mouseClicked;
            }

            set
            {
                if (!value)
                    pointsArray.Reset();
                mouseClicked = value;
            }
        }

        PictureBox picture;
        Button colorController;
        Button penColor;

        PointsArray pointsArray;
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;

        public Controller(PictureBox picture, Button penColor)
        {
            this.picture = picture;
            this.colorController = this.penColor = penColor;

            pointsArray = new PointsArray(2);
            MouseClicked = false;
            this.pen = new Pen(Color.Black, 1f);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            ClearArea(Screen.PrimaryScreen.Bounds);
        }

        //Points for drawing:
        private class PointsArray
        {
            private int index = 0;
            private Point[] points;

            public PointsArray(int size)
            {
                if (size < 2) size = 2;
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if (index >= points.Length) Reset();
                points[index++] = new Point(x, y);
            }

            public void Reset()
            {
                index = 0;
            }

            public int GetPointsCount()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }
        }

        //Drawing:
        public void LineToPoint(int x, int y) 
        {
            if (!MouseClicked || instrument < 0) return;
            pointsArray.SetPoint(x, y);
            if (pointsArray.GetPointsCount() >= 2)
            {
                graphics.DrawLines(pen, pointsArray.GetPoints());
                if(picture!= null)
                    picture.Image = bitmap;
                pointsArray.SetPoint(x, y);
            }
        }
        private void ClearArea(Rectangle rect, Color color = default(Color))
        {
            bitmap = new Bitmap(rect.Width, rect.Height);
            using (var g = Graphics.FromImage(bitmap))
                g.Clear(color);
            UpdateBitmap(bitmap);
        }

        private void ResizeImage(Bitmap map, Size size)
        {
            bitmap = new Bitmap(map, size);
            UpdateBitmap(bitmap);
        }

        internal void UpdateBitmap(Bitmap map)
        {
            bitmap = map;
            graphics = Graphics.FromImage(map);
            if(picture!=null)
                picture.Image = map;
        }

        //Common Methods:

        public void SetPenWidth(int width)
        {
            pen.Width = width;
        }

        public void TrackChangesTextBox(TrackBar track, TextBox box)
        {
            box.Text = $"{track.Value}";
        }

        public void TextBoxChangesTrack(TrackBar track, TextBox box)
        {
            try
            {
                if (!box.Text.Equals(""))
                    track.Value = System.Convert.ToInt32(box.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid value!");
            }
        }

        public void ChangeColor(Color newColor)
        {
            if(colorController != null)
            {
                if (colorController == penColor) pen.Color = newColor;
                colorController.BackColor = newColor;
            } else
                pen.Color = newColor;
        }

        public void SetColorControl(Button colorControlButton)
        {
            if (colorController != colorControlButton)
            {
                colorController.FlatStyle = FlatStyle.Popup;
                colorControlButton.FlatStyle = FlatStyle.Standard;
                colorController = colorControlButton;
            }
        }

        public void Reflect(RotateFlipType type)
        {
            //bitmap = new Bitmap(picture.Image);        ??????????????????????????????????????????????????????????????????????
            bitmap.RotateFlip(type);
            UpdateBitmap(bitmap);
        }

        public void ChangeBrightness(float brightnessFactor)
        {
            float[][] colorMatrixElements = {
                                                new float[] { brightnessFactor, 0, 0, 0, 0},
                                                new float[] {0, brightnessFactor, 0, 0, 0},
                                                new float[] {0, 0, brightnessFactor, 0, 0},
                                                new float[] {0, 0, 0, 1, 0},
                                                new float[] {0, 0, 0, 0, 1}
                                            };
            ColorMatrixImageChanging(colorMatrixElements);
        }

        public void ChangeChromaticity(float chromaticityFactor)
        {
            float rwgt = 0.3086f;
            float gwgt = 0.6094f;
            float bwgt = 0.0820f;

            rwgt *= 1 - chromaticityFactor;
            gwgt *= 1 - chromaticityFactor;
            bwgt *= 1 - chromaticityFactor;

            float[][] colorMatrixElements = {
                                                new float[] { rwgt + chromaticityFactor, rwgt, rwgt, 0, 0},
                                                new float[] { gwgt, gwgt + chromaticityFactor, gwgt, 0, 0},
                                                new float[] { bwgt, bwgt, bwgt + chromaticityFactor, 0, 0},
                                                new float[] { 0, 0, 0, 1, 0},
                                                new float[] {0, 0, 0, 0, 1}
                                            };
            ColorMatrixImageChanging(colorMatrixElements);
        }

        public void ChangeContrast(float cotrastFactor)
        {
            float[][] colorMatrixElements = {
                                                new float[] { 1 / (1- cotrastFactor), 0, 0, 0, 0},
                                                new float[] { 0, 1 / (1 - cotrastFactor), 0, 0, 0},
                                                new float[] { 0, 0, 1 / (1 - cotrastFactor), 0, 0},
                                                new float[] { 0, 0, 0, 1, 0},
                                                new float[] {- 0.75f * cotrastFactor / (1 - cotrastFactor), -0.75f * cotrastFactor / (1 - cotrastFactor), -0.75f *  cotrastFactor / (1 - cotrastFactor), 0, 1}
                                            };
            ColorMatrixImageChanging(colorMatrixElements);
        }

        public void ColorMatrixImageChanging(float[][] colorMatrixElements)
        {

            Bitmap tempBitmap = new Bitmap(bitmap);
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = tempBitmap.Width;
            int height = tempBitmap.Height;



            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(tempBitmap);
            graphics.DrawImage(tempBitmap, new Rectangle(0, 0, width, height), 0, 0, width,
                               height,
                               GraphicsUnit.Pixel,
                               imageAttributes);

            if(picture!=null)
                picture.Image = tempBitmap;
            else
                UpdateBitmap(tempBitmap);
        }

        public void RotateImage(float angle)
        {
            Size newSize = CoveringRectSize(bitmap.Width, bitmap.Height, angle);
            Bitmap tempBitmap = new Bitmap(newSize.Width, newSize.Height);
            Graphics graphics = Graphics.FromImage(tempBitmap);

            graphics.TranslateTransform((float)newSize.Width / 2, (float)newSize.Height / 2);
            graphics.RotateTransform(angle);
            graphics.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);

            graphics.DrawImage(bitmap, new Point(0,0));
            UpdateBitmap(tempBitmap);
        }

        private Size CoveringRectSize(int width, int height, float angle)
        {
            angle /= 180 / 3.14159265f;
            //angle = Math.Abs(angle);
            double x = width * Math.Abs(Math.Cos(angle)) + height * Math.Abs(Math.Sin(angle));
            double y = width * Math.Abs(Math.Sin(angle)) + height * Math.Abs(Math.Cos(angle));
            return new Size(System.Convert.ToInt32(x), System.Convert.ToInt32(y));
        }

        public void ScaleImage((float widthScale, float heightScale) scale)
        {
            ResizeImage(bitmap, new Size(System.Convert.ToInt32(bitmap.Width * scale.widthScale), System.Convert.ToInt32(bitmap.Height * scale.heightScale)));
        }

        public void Resize((int width, int height) newSize)
        {
            ResizeImage(bitmap, new Size(newSize.width, newSize.height));
        }

        public void NewImage(Color color)
        {
            ClearArea(Screen.PrimaryScreen.Bounds, color);
        }

        //Other windows working:
        public float GetRotationAngle(Form parentForm)
        {
            RotationForm angleSetter = new RotationForm();
            angleSetter.ShowDialog(parentForm);
            float angle = angleSetter.Rotation;
            angleSetter.Dispose();
            return angle;
        }

        public (float widthScale, float heightScale) GetScale(Form parentForm)
        {
            ScaleForm scaleSetter = new ScaleForm();
            scaleSetter.ShowDialog(parentForm);
            float widthScale = scaleSetter.WidthScale;
            float heightScale = scaleSetter.HeightScale;
            scaleSetter.Dispose();
            return (widthScale, heightScale);
        }

        public (int width, int height) GetNewSize(Form parentForm)
        {
            ResizeForm resizeSetter = new ResizeForm(bitmap.Width, bitmap.Height);
            resizeSetter.ShowDialog(parentForm);
            (int width, int height) newSize = resizeSetter.NewSize;
            resizeSetter.Dispose();
            return newSize;
        }

        public void OpenImage(string filename)
        {
            bitmap = new Bitmap(Image.FromFile(filename));
            UpdateBitmap(bitmap);
        }

        public void SaveImage(string saveAddr)
        {
            bitmap.Save(saveAddr);
        }
    }
}
