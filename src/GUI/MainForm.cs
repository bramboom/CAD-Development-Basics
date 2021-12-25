using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Core;
using Kompas;

namespace GUI
{
    /// <summary>
    /// Главная форма плагина
    /// </summary>
    public partial class LinkPinPlugin : Form
    {
        /// <summary>
        /// Поле, хранящее параметры детали
        /// </summary>
        private LinkPinParameter _parameter = new LinkPinParameter();

        /// <summary>
        /// Поле, хранящее объект потключения к компасу
        /// </summary>
        private Connecter _connecter = new Connecter();
 
        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public LinkPinPlugin()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            var path = Directory.GetCurrentDirectory();
            pictureBox.Image = Image.FromFile(path + "/img/img.JPG");
            InitParameters();
        }

        /// <summary>
        /// Отчищает содержимое всех TextBox
        /// </summary>
        /// <param name="textbox">TextBox</param>
        private void ClearTextBox(TextBox textbox)
        {
            textbox.Text = "";
            textbox.BackColor = Color.White;
        }

        /// <summary>
        /// Помещаяет параметр из TextBox
        /// </summary>
        /// <param name="textBox">TextBox</param>
        /// <param name="parameter">параметр</param>
        private void GetValueFromTextBox(TextBox textBox, Parameters parameter)
        {
            textBox.BackColor = Color.White;

            if (textBox.Text == "") return;
            double value ;
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
        /// Инициализирует дефолтные параметры
        /// </summary>
        private void InitParameters()
        {
            GetValueFromTextBox(textBoxRodLength, 
                Parameters.RodLength);
            GetValueFromTextBox(textBoxHeadLength, 
                Parameters.HeadLength);
            GetValueFromTextBox(textBoxHoleRadius, 
                Parameters.HoleRadius);
            GetValueFromTextBox(textBoxHoleDistance, 
                Parameters.HoleDistance);
            GetValueFromTextBox(textBoxRodRadius, 
                Parameters.RodRadius);
            GetValueFromTextBox(textBoxHeadRadius, 
                Parameters.HeadRadius);
            GetValueFromTextBox(textBoxRodChamferDepth, 
                Parameters.RodChamfetDepth);
            GetValueFromTextBox(textBoxHeadChamferDepth, 
                Parameters.HeadChamferDepth);
            GetValueFromTextBox(textBoxRodAngleDepth, 
                Parameters.RodAngleDepth);
            GetValueFromTextBox(textBoxHeadAngleDepth, 
                Parameters.HeadAngleDepth);
        }

        /// <summary>
        /// Добавляет наименование параметра к описанию ошибки
        /// </summary>
        /// <param name="error">описание ошибки</param>
        /// <param name="textBox">текстовое поле</param>
        /// <param name="errorName">наименование параметра</param>
        private void AddError(ref string error, TextBox textBox, string errorName)
        {
            if (textBox.BackColor == Color.DarkSalmon ||
                textBox.Text == "")
                error += errorName;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox(textBoxRodLength);
            ClearTextBox(textBoxHeadLength);
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

        private void textBoxRodLength_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodLength, 
                Parameters.RodLength);
            InitParameters();
        }

        private void textBoxHeadLength_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadLength, 
                Parameters.HeadLength);
            InitParameters();
        }

        private void textBoxHoleRadius_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHoleRadius, 
                Parameters.HoleRadius);
            InitParameters();
        }

        private void textBoxHoleDistance_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHoleDistance, 
                Parameters.HoleDistance);
            InitParameters();
        }

        private void textBoxRodRadius_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodRadius, 
                Parameters.RodRadius);
            InitParameters();
        }

        private void textBoxHeadRadius_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadRadius, 
                Parameters.HeadRadius);
            InitParameters();
        }

        private void textBoxRodChamferDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodChamferDepth, 
                Parameters.RodChamfetDepth);
            InitParameters();
        }

        private void textBoxHeadChamferDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadChamferDepth, 
                Parameters.HeadChamferDepth);
            InitParameters();
        }

        private void textBoxRodAngleDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxRodAngleDepth, 
                Parameters.RodAngleDepth);
            InitParameters();
        }

        private void textBoxHeadAngleDepth_TextChanged(object sender, EventArgs e)
        {
            GetValueFromTextBox(textBoxHeadAngleDepth, 
                Parameters.HeadAngleDepth);
            InitParameters();
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            string error = "Параметры введены неверно:";
            AddError(ref error, textBoxRodLength, 
                "\nДлина стержня");
            AddError(ref error, textBoxHeadLength, 
                "\nДлина шляпки");
            AddError(ref error, textBoxHoleRadius, 
                "\nРадиус отверстия");
            AddError(ref error, textBoxHoleDistance, 
                "\nРастояние отверстия");
            AddError(ref error, textBoxRodRadius, 
                "\nРадиус стержня");
            AddError(ref error, textBoxHeadRadius, 
                "\nРадиус шляпки");
            AddError(ref error, textBoxRodChamferDepth, 
                "\nДлина фаски на стержне");
            AddError(ref error, textBoxHeadChamferDepth, 
                "\nДлина фаски на шляпке");
            AddError(ref error, textBoxRodAngleDepth, 
                "\nУгол фаски на стержне");
            AddError(ref error, textBoxHeadAngleDepth, 
                "\nУгол фаски на шляпке");

            if (error != "Параметры введены неверно:")
            {
                MessageBox.Show(error, @"Warning");
                return;
            }

            _connecter.RunKompas();

            Builder builder = new Builder();

            builder.Build(_connecter.KompasObject, _parameter);
        }
    }
}
