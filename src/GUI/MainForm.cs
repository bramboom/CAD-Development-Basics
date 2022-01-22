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

        //TODO: 
        /// <summary>
        /// 
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
        /// Добавляет наименование параметра к описанию ошибки
        /// </summary>
        /// <param name="error">описание ошибки</param>
        /// <param name="textBox">текстовое поле</param>
        /// <param name="errorName">наименование параметра</param>
        private void AddError(ref string error, TextBox textBox, string errorName)
        {
            if (textBox.BackColor == _errorColor ||
                textBox.Text == "")
            {
                error += errorName;
            }
        }

        /// <summary>
        /// Собыие при нажатии кнопки очистки
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Данные события</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (var pair in _dictionary)
            {
                ClearTextBox(pair.Key);
            }
            _parameter = new LinkPinParameter();
        }
        
        /// <summary>
        /// Событие при изменении содержимого TextBox
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Данные события</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            GetValueFromTextBox(textBox, _dictionary[textBox].Key);
            InitParameters();
        }

        //TODO: RSDN
        /// <summary>
        /// Событие при надатии кнопки построения
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Данные события</param>
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            // todo: const
            string error = "Параметры введены неверно:";
            foreach (var pair in _dictionary)
            {
                //TODO: вынести из метода
                AddError(ref error, pair.Key, pair.Value.Value);
            }

            if (error != "Параметры введены неверно:")
            {
                MessageBox.Show(error, @"Warning");
                return;
            }

            _connecter.RunKompas();

            Builder builder = new Builder();

            builder.Build(_connecter.KompasObject, _parameter);
        }

        //TODO: RSDN
        /// <summary>
        /// Событие при изменении состояния чекбокса
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Данные события</param>
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _parameter.Cutting = checkBox.Checked;
        }
    }
}
