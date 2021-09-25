using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using SPP_2;
using System.Windows.Forms;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        const string TESTING_FILES_LOCATION = "TestImages\\";
        [TestMethod]
        public void TestOpeningAndSavingBmp()
        {
            Bitmap ethalonBitmap = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImage.bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSave.bmp");
            Bitmap savedBitmap = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSave.bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap, savedBitmap));
        }

        [TestMethod]
        public void TestOpeningAndSavingJpg()
        {
            Bitmap ethalonBitmap = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImage.jpg"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.jpg");
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSave.jpg");
            Bitmap savedBitmap = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSave.jpg"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap, savedBitmap));
        }

        [TestMethod]
        public void TestOpeningAndSavingPng()
        {
            Bitmap ethalonBitmap = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImage.png"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.png");
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSave.png");
            Bitmap savedBitmap = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSave.png"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap, savedBitmap));
        }

        [TestMethod]
        public void TestRotation()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImage90Right.bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImage30Left.bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.RotateImage(90);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSave90Right.bmp");
            controller.RotateImage(-120f);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSave30Left.bmp");
            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSave90Right.bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSave30Left.bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Rotation 90 degrees right is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Rotation 120 degrees left after 90 degrees right is incorrect!");
        }

        [TestMethod]
        public void TestReflection()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageReflectHor.bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageReflectCenter.bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.Reflect(RotateFlipType.RotateNoneFlipX);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveReflectHor.bmp");
            controller.Reflect(RotateFlipType.RotateNoneFlipY);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveReflectCenter.bmp");
            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveReflectHor.bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveReflectCenter.bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Horizontal reflection is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Verical reflection after horizontal is incorrect!");
        }

        [TestMethod]
        public void TestScaling()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageScale(1,5x0,5).bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageScale(3x1,75).bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.ScaleImage((1.5f, 0.5f));
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveScale(1,5x0,5).bmp");
            controller.ScaleImage((2f, 3.5f));
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveScale(3x1,75).bmp");
            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveScale(1,5x0,5).bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveScale(3x1,75).bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Scaling 1,5x0,5 is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Scaling 2x3,5 after 1,5x0,5 is incorrect!");
        }

        [TestMethod]
        public void TestResizing()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageResize(200x200).bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "newBlueImageResize(500x400).bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.Resize((200, 200));
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveResize(200x200).bmp");
            controller.NewImage(Color.Blue);
            controller.Resize((500, 400));
            controller.SaveImage(TESTING_FILES_LOCATION + "newBlueImageSaveResize(500x400).bmp");
            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveResize(200x200).bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "newBlueImageSaveResize(500x400).bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Resizing 200x200 is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Resizing 500x400 after creating new blue image is incorrect!");
        }

        [TestMethod]
        public void TestDrawing()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "drawnImage.bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageWithDrawing.bmp"));
            Controller controller = new Controller(null, null);
            controller.SetPenWidth(7);
            Drawing(controller);
            controller.SaveImage(TESTING_FILES_LOCATION + "saveDrawnImage.bmp");

            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.SetPenWidth(3);
            controller.ChangeColor(Color.Blue);
            Drawing(controller);

            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveWithDrawing.bmp");
            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "saveDrawnImage.bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveWithDrawing.bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Drawing is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Drawing on basicImage is incorrect!");
        }
        private void Drawing(Controller controller)
        {
            controller.MouseClicked = true;
            controller.LineToPoint(20, 20);
            controller.LineToPoint(30, 25);
            controller.LineToPoint(35, 25);
            controller.LineToPoint(35, 30);
            controller.LineToPoint(40, 32);
            controller.LineToPoint(40, 40);
            controller.ChangeColor(Color.Green);
            controller.LineToPoint(50, 60);
            controller.LineToPoint(60, 55);
            controller.LineToPoint(65, 65);
            controller.LineToPoint(70, 60);
            controller.MouseClicked = false;
        }

        [TestMethod]
        public void TestContrast()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageContrast(+50).bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageContrast(+50-50).bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.ChangeContrast(50f/128f);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveContrast(+50).bmp");
            controller.ChangeContrast(-50f / 128f);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveContrast(+50-50).bmp");

            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveContrast(+50).bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveContrast(+50-50).bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Increasing contrast is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Decreasing contrast after increasing is incorrect!");
        }

        [TestMethod]
        public void TestBrightness()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageBrightness(+75).bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageBrightness(+75-75).bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.ChangeBrightness((75f / 128f) + 1);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveBrightness(+75).bmp");
            controller.ChangeBrightness((-75f / 128f) + 1);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveBrightness(+75-75).bmp");

            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveBrightness(+75).bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveBrightness(+75-75).bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Increasing brightness is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Decreasing brightness after increasing is incorrect!");
        }

        [TestMethod]
        public void TestChromaticity()
        {
            Bitmap ethalonBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageChromaticity(+100).bmp"));
            Bitmap ethalonBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageChromaticity(+100-100).bmp"));
            Controller controller = new Controller(null, null);
            controller.OpenImage(TESTING_FILES_LOCATION + "basicImage.bmp");
            controller.ChangeChromaticity((100f / 128f) + 1);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveChromaticity(+100).bmp");
            controller.ChangeChromaticity((-100f / 128f) + 1);
            controller.SaveImage(TESTING_FILES_LOCATION + "basicImageSaveChromaticity(+100-100).bmp");

            Bitmap savedBitmap1 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveChromaticity(+100).bmp"));
            Bitmap savedBitmap2 = new Bitmap(Image.FromFile(TESTING_FILES_LOCATION + "basicImageSaveChromaticity(+100-100).bmp"));
            Assert.IsTrue(BitmapsEquals(ethalonBitmap1, savedBitmap1), "Increasing chromaticity is incorrect!");
            Assert.IsTrue(BitmapsEquals(ethalonBitmap2, savedBitmap2), "Decreasing chromaticity after increasing is incorrect!");
        }
        unsafe private bool BitmapsEquals(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1.Size != bmp2.Size)
                return false;
            BitmapData bmpd1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData bmpd2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            Boolean res = true;
            Int32* p1 = (Int32*)bmpd1.Scan0;
            Int32* p2 = (Int32*)bmpd2.Scan0;
            for (Int32 i = 0; i < bmpd1.Height; i++)
            {
                for (Int32 j = 0; j < bmpd2.Width; j++)
                {
                    if (*p1 != *p2)
                    {
                        res = false;
                        break;
                    }
                    p1++;
                    p2++;
                }
            }
            bmp1.UnlockBits(bmpd1);
            bmp2.UnlockBits(bmpd2);
            return res;
        }
    }
}
