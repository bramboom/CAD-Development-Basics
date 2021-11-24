using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    public partial class LinkPinsPlugin : Form
    {
        private LinkPinParameter _parameter = new LinkPinParameter();
        public LinkPinsPlugin()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            var path = Directory.GetCurrentDirectory();
            pictureBox.Image = Image.FromFile(path + "/img/img.JPG");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textbox"></param>
        private void ClearTextBox(TextBox textbox)
        {
            textbox.Text = "";
            textbox.BackColor = Color.White;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox(textBoxRodLenght);
            ClearTextBox(textBoxHeadLenght);
            ClearTextBox(textBoxHoleRadius);
            ClearTextBox(textBoxRodChamferDepth);
            ClearTextBox(textBoxHeadChamferDepth);
            ClearTextBox(textBoxRodAngleDepth);
            ClearTextBox(textBoxHeadAngleDepth);
            ClearTextBox(textBoxHoleDistance);
            ClearTextBox(textBoxRodRadius);
            ClearTextBox(textBoxHeadRadius);
            _parameter = new LinkPinParameter();
        }
    }
}
