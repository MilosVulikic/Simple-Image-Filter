using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Image_Filter
{
    class FileOperation
    {
        Bitmap newImage;

        public Bitmap OpenImage()
        {
            OpenFileDialog openFD = new OpenFileDialog();                        
            openFD.InitialDirectory = @"..\..\additionalFiles\Images";
            openFD.Filter = "images| *.jpg; *.png; *.bmp";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                newImage = new Bitmap(Image.FromFile(openFD.FileName));
            }
            return newImage;
        }


        public void SaveImage(PictureBox pictureBox)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "images| *.jpg; *.png; *.bmp";
            saveFD.FileName = "NewPhoto.bmp";
            saveFD.InitialDirectory = @"..\..\additionalFiles\Images";
            saveFD.RestoreDirectory = true;
            if (saveFD.ShowDialog() == DialogResult.OK) 
            {
                pictureBox.Image.Save(saveFD.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }            
        }
    }

}