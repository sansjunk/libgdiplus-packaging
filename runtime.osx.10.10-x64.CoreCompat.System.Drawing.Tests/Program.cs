using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CoreCompat.System.Drawing.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var bitmap = new Bitmap(512, 512))
            {
                bitmap.Save("test.bmp", ImageFormat.Bmp);
                bitmap.Save("test.jpg", ImageFormat.Jpeg);
                bitmap.Save("test.gif", ImageFormat.Gif);
                bitmap.Save("test.ico", ImageFormat.Icon);
                bitmap.Save("test.png", ImageFormat.Png);;
                bitmap.Save("test.tiff", ImageFormat.Tiff);
                bitmap.Save("test.wmf", ImageFormat.Wmf);
            }
        }
    }
}
