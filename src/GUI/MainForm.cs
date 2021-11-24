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
            InitParameters();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="parameter"></param>
        private void GetValueFromTextBox(TextBox textBox, Parameters parameter)
        {
            textBox.BackColor = Color.White;

            if (textBox.Text == "")
                return;

            double value = Double.NaN;
            if (!double.TryParse(textBox.Text, out value))
            {
                textBox.BackColor = Color.DarkSalmon;
                return;
            }

            try
            {
                _parameter.SetValue(parameter, value);
            }
            catch (ArgumentException)
            {
                textBox.BackColor = Color.DarkSalmon;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitParameters()
        {
            GetValueFromTextBox(textBoxRodLenght, Parameters.RodLength);
            GetValueFromTextBox(textBoxHeadLenght, Parameters.HeadLength);
            GetValueFromTextBox(textBoxHoleRadius, Parameters.HoleRadius);
            GetValueFromTextBox(textBoxHoleDistance, Parameters.HoleDistance);
            GetValueFromTextBox(textBoxRodRadius, Parameters.RodRadius);
            GetValueFromTextBox(textBoxHeadRadius, Parameters.HeadRadius);
            GetValueFromTextBox(textBoxRodChamferDepth, Parameters.RodChamfetDepth);
            GetValueFromTextBox(textBoxHeadChamferDepth, Parameters.HeadChamferDepth);
            GetValueFromTextBox(textBoxRodAngleDepth, Parameters.RodAngleDepth);
            GetValueFromTextBox(textBoxHeadAngleDepth, Parameters.HeadAngleDepth);
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

        private void textBoxRodLenght_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodLenght, Parameters.RodLength);
            GetValueFromTextBox(textBoxHeadLenght, Parameters.HeadLength);
        }

        private void textBoxHeadLenght_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadLenght, Parameters.HeadLength);
        }

        private void textBoxHoleRadius_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHoleRadius, Parameters.HoleRadius);
        }

        private void textBoxHoleDistance_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHoleDistance, Parameters.HoleDistance);
        }

        private void textBoxRodRadius_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodRadius, Parameters.RodRadius);
        }

        private void textBoxHeadRadius_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadRadius, Parameters.HeadRadius);
        }

        private void textBoxRodChamferDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodChamferDepth, Parameters.RodChamfetDepth);
        }

        private void textBoxHeadChamferDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadChamferDepth, Parameters.HeadChamferDepth);
        }

        private void textBoxRodAngleDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodAngleDepth, Parameters.RodAngleDepth);
        }

        private void textBoxHeadAngleDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadAngleDepth, Parameters.HeadAngleDepth);
        }
    }
}
