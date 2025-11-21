using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imageUploadDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.Filter = "Image only | *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            DialogResult dr = openFd.ShowDialog();

            imgPictureBox.Image = Image.FromFile(openFd.FileName);

            imgpathLabel1.Text = openFd.FileName;
        }
    }
}
