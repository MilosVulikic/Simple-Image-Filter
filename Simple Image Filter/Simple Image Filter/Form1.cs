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

        public frmSimpleFilter()
        {
            InitializeComponent();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            newImage = getFile.OpenImage();
            pictureBox2.Image = newImage;            
        }













        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getFile.SaveImage(pictureBox2);
        }
    }
}
