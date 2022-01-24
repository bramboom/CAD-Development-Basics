using System;
using System.Collections.Generic;
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
        private readonly Connecter _connecter = new Connecter();

        /// <summary>
        /// Константа, хранящая цвет ошибки
        /// </summary>
        private readonly Color _errorColor = Color.DarkSalmon;
        
        /// <summary>
        /// Словарь связывающий текстовое поле с парой параметр - сообщение об ошибке
        /// </summary>
        private readonly Dictionary<TextBox, KeyValuePair<Parameters, string>> _dictionary;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public LinkPinPlugin()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            var path = Directory.GetCurrentDirectory();
            pictureBox.Image = Image.FromFile(path + "/img/img.JPG");

            _dictionary = new Dictionary<TextBox, KeyValuePair<Parameters, string>>
            {
                {textBoxRodLength, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.RodLength, "\nДлина стержня")},
                {textBoxHeadLength, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.HeadLength, "\nДлина шляпки")},
                {textBoxHoleRadius, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.HoleRadius, "\nРадиус отверстия")},
                {textBoxRodChamferDepth, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.RodChamferDepth, "\nРастояние отверстия")},
                {textBoxHeadChamferDepth, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.HeadChamferDepth, "\nРадиус стержня")},
                {textBoxRodAngleDepth, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.RodAngleDepth, "\nРадиус шляпки")},
                {textBoxHeadAngleDepth, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.HeadAngleDepth, "\nДлина фаски на стержне")},
                {textBoxHoleDistance, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.HoleDistance, "\nДлина фаски на шляпке")},
                {textBoxRodRadius, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.RodRadius, "\nУгол фаски на стержне")},
                {textBoxHeadRadius, 
                    new KeyValuePair<Parameters, string>
                        (Parameters.HeadRadius, "\nУгол фаски на шляпке")}
            };

            toolTip.SetToolTip(
                textBoxRodLength, "Параметр A (длина стержня) "
                + "не должен быть меньше 5  параметров B (длины шляпки)");
            toolTip.SetToolTip(
                textBoxHeadLength, "Параметр B (длина шляпки) "
                + "не должен превышать 0.2 параметра A (длина стержня).");
            toolTip.SetToolTip(
                textBoxHoleRadius, "Параметр C (радиус отверстия) "
                + "не должен превышать параметр F (расстояние до отверстия) - максимальное значение.");
            toolTip.SetToolTip(
                textBoxHoleDistance, "Параметр F (расстояние до отверстия) "
                + "не должен быть меньше параметра C (радиус отверстия) + минимальное значение.");
            toolTip.SetToolTip(
                textBoxRodRadius, "Параметр I (радиус стержня) "
                + "не должен превышать 0,8 параметра J (радиус шляпки).");
            toolTip.SetToolTip(
                textBoxHeadRadius, "Параметр I (радиус стержня) "
                + "не должен превышать 0,8 параметра J (радиус шляпки).");

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

            if (textBox.Text == "")
            {
                return;
            }

            double value;
            
            if (!double.TryParse(textBox.Text, out value))
            {
                textBox.BackColor = _errorColor;
                return;
            }

            try
            {
                _parameter.SetValue(parameter, value);
            }
            catch (ArgumentException)
            {
                textBox.BackColor = _errorColor;
            }
        }

        /// <summary>
        /// Инициализирует дефолтные параметры
        /// </summary>
        private void InitParameters()
        {
            foreach (var pair in _dictionary)
            {
                GetValueFromTextBox(pair.Key, pair.Value.Key);
            }
            _parameter.Cutting = false;
        }

        /// <summary>
        /// Собыие для <see cref="buttonClear"/> при нажатии на нее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (var pair in _dictionary)
            {
                ClearTextBox(pair.Key);
            }
            _parameter = new LinkPinParameter();
        }
        
        /// <summary>
        /// Событие для <see cref="TextBox"/> при изменении текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            GetValueFromTextBox(textBox, _dictionary[textBox].Key);
            InitParameters();
        }

        //TODO: RSDN
        /// <summary>
        /// Событие для <see cref="buttonBuild"/> при нажатии на нее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            bool isAnError = false;
            string errorMessage = "Параметры введены неверно:";
            foreach (var pair in _dictionary)
            {
                if (pair.Key.BackColor == _errorColor ||
                    pair.Key.Text == "")
                {
                    errorMessage += pair.Value.Value;
                    isAnError = true;
                }
            }

            if (isAnError)
            {
                MessageBox.Show(errorMessage, @"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _connecter.RunKompas();

            Builder builder = new Builder();

            builder.Build(_connecter.KompasObject, _parameter);
        }

        //TODO: RSDN
        /// <summary>
        /// Событие для <see cref="checkBox"/> при изменении его состояния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _parameter.Cutting = checkBox.Checked;
        }
    }
}
