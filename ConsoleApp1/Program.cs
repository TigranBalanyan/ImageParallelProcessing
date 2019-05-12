using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringPath = @"C:\Users\tbala\source\repos\ConsoleApp1\ConsoleApp1\Resources\images\";
            string[] fileNames = Directory.GetFiles(stringPath);
            
            Parallel.ForEach(fileNames, (fileName) =>
            {
                
                string path = Path.GetFullPath(fileName); 
                var image = new Bitmap(path);
                image.RotateFlip(RotateFlipType.Rotate180FlipY);
                image.Save(Path.Combine(@"C:\Users\tbala\source\repos\ConsoleApp1\ConsoleApp1\Resources", fileName));
            });


        }

    }
}
