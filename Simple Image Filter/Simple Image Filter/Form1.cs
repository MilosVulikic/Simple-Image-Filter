using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Image_Filter
{
    public partial class frmSimpleFilter : Form
    {
        Bitmap newImage;

        FileOperation getFile = new FileOperation();
        ImageManipulation editImage = new ImageManipulation();

        public frmSimpleFilter()
        {
            InitializeComponent();

            editImage.ImageFinished += OnImageFinished;
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            newImage = getFile.OpenImage();
            pictureBox2.Image = newImage;            
        }


        public void OnImageFinished(object sender, ImageEventArgs e)
        {
            pictureBox2.Image = e.Bmap;
        }





        string GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio.Text;
                }
            }
            return null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getFile.SaveImage(pictureBox2);
        }

        private void btnApplyFilter_Click_1(object sender, EventArgs e)
        {
            string filter = GetCheckedRadio(groupBoxFilters);

            Bitmap currentImage = new Bitmap(newImage);
            editImage.Manipulate(currentImage, filter);
        }
    }
}
