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
        private LinkPinParameter _parameter;

        private Dictionary<LinkPinParameter, TextBox> _textBoxesParameters;
        public LinkPinsPlugin()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            var path = Directory.GetCurrentDirectory();
            pictureBox.Image = Image.FromFile(path + "/img/img.JPG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Один или несколько параметров введены неверно:\nДлина стержня (А)", "Warning");
        }
    }
}
