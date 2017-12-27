using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media; 
using System.IO;

namespace Simple_Image_Filter
{
    class ImageManipulation
    {
        public void PlaySound()
        {
            SoundPlayer alarmSound = new SoundPlayer();            
            alarmSound.Stream = File.OpenRead(@"..\..\additionalFiles\Sounds\sound1.wav");
            alarmSound.LoadAsync();
            alarmSound.Play();
        }

        public void Manipulate(Bitmap bmp, string color)
        {
            Color currentClr = new Color();
            Random rnd = new Random();

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    currentClr = bmp.GetPixel(i, j);    // get color of each pixel
                    Color newClr = new Color();
                    switch (color)
                    {

                        case "Red":
                            newClr = Color.FromArgb(currentClr.R, 0, 0);
                            break;
                        case "Green":
                            newClr = Color.FromArgb(0, currentClr.G, 0);
                            break;
                        case "Blue":
                            newClr = Color.FromArgb(0, 0, currentClr.B);
                            break;
                        case "Purple":
                            newClr = Color.FromArgb(currentClr.R, 0, currentClr.B);
                            break;
                        case "Azure":
                            newClr = Color.FromArgb(0, currentClr.G, currentClr.B);
                            break;
                        case "Yellow":
                            newClr = Color.FromArgb(currentClr.R, currentClr.G, 0);
                            break;
                        case "No Filter":
                            newClr = Color.FromArgb(currentClr.R, currentClr.G, currentClr.B);
                            break;
                        case null:
                            newClr = Color.FromArgb(currentClr.R, currentClr.G, currentClr.B);
                            break;
                        case "Grayscale":
                            newClr = Color.FromArgb((currentClr.R + currentClr.G + currentClr.B) / 3, (currentClr.R + currentClr.G + currentClr.B) / 3, (currentClr.R + currentClr.G + currentClr.B) / 3);
                            break;
                        case "Invert":
                            newClr = Color.FromArgb(255 - currentClr.R, 255 - currentClr.G, 255 - currentClr.B);
                            break;

                        case "Crazy":
                            int r = (Convert.ToInt32(rnd.Next(1, 3) * (currentClr.R)));
                            int g = (Convert.ToInt32(rnd.Next(1, 3) * (currentClr.G)));
                            int b = (Convert.ToInt32(rnd.Next(1, 3) * (currentClr.B)));
                            if ((r > 0 && r < 255) && (g > 0 && g < 255) && (b > 0 && b < 255))
                            {
                                newClr = Color.FromArgb(r, g, b);

                            }

                            break;

                    }

                    bmp.SetPixel(i, j, newClr);
                }

            }
            PlaySound();
            OnImageFinished(bmp);   // Call the method to publish event

        }


        // Event Handler Delegate
        public event EventHandler<ImageEventArgs> ImageFinished;


        // Event Method
        protected virtual void OnImageFinished(Bitmap bitmap)
        {
            if (ImageFinished != null)
            {
                ImageFinished(this, new ImageEventArgs() { Bmap = bitmap, Info = "Finished. Sending to subscribers..." });
            }
        }
    }
}


// Custom args
public class ImageEventArgs : EventArgs     // we need custom event arguments for passing through our method
{
    public Bitmap Bmap { get; set; }
    public string Info { get; set; }
}