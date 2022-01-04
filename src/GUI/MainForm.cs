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
        private Connecter _connecter = new Connecter();

        /// <summary>
        /// Константа, хранящая цвет ошибки
        /// </summary>
        private readonly Color _errorColor = Color.DarkSalmon;

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<TextBox, KeyValuePair<Parameters, string>> _dictionary;

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
                {textBoxRodLength, new KeyValuePair<Parameters, string>(Parameters.RodLength, "\nДлина стержня")},
                {textBoxHeadLength, new KeyValuePair<Parameters, string>(Parameters.HeadLength, "\nДлина шляпки")},
                {textBoxHoleRadius, new KeyValuePair<Parameters, string>(Parameters.HoleRadius, "\nРадиус отверстия")},
                {textBoxRodChamferDepth, new KeyValuePair<Parameters, string>(Parameters.RodChamfetDepth, "\nРастояние отверстия")},
                {textBoxHeadChamferDepth, new KeyValuePair<Parameters, string>(Parameters.HeadChamferDepth, "\nРадиус стержня")},
                {textBoxRodAngleDepth, new KeyValuePair<Parameters, string>(Parameters.RodAngleDepth, "\nРадиус шляпки")},
                {textBoxHeadAngleDepth, new KeyValuePair<Parameters, string>(Parameters.HeadAngleDepth, "\nДлина фаски на стержне")},
                {textBoxHoleDistance, new KeyValuePair<Parameters, string>(Parameters.HoleDistance, "\nДлина фаски на шляпке")},
                {textBoxRodRadius, new KeyValuePair<Parameters, string>(Parameters.RodRadius, "\nУгол фаски на стержне")},
                {textBoxHeadRadius, new KeyValuePair<Parameters, string>(Parameters.HeadRadius, "\nУгол фаски на шляпке")}
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

            double value ;
            
            if (!double.TryParse(textBox.Text, out value))
            {
                //TODO: to const +
                textBox.BackColor = _errorColor;
                return;
            }

            try
            {
                _parameter.SetValue(parameter, value);
            }
            catch (ArgumentException)
            {
                //TODO: to const +
                textBox.BackColor = _errorColor;
            }
        }

        /// <summary>
        /// Инициализирует дефолтные параметры
        /// </summary>
        private void InitParameters()
        {
            //TODO: Убрать дублирование +
            foreach (var pair in _dictionary)
            {
                GetValueFromTextBox(pair.Key, pair.Value.Key);
            }
        }

        /// <summary>
        /// Добавляет наименование параметра к описанию ошибки
        /// </summary>
        /// <param name="error">описание ошибки</param>
        /// <param name="textBox">текстовое поле</param>
        /// <param name="errorName">наименование параметра</param>
        private void AddError(ref string error, TextBox textBox, string errorName)
        {
            //TODO: to const +
            if (textBox.BackColor == _errorColor ||
                textBox.Text == "")
            {
                error += errorName;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //TODO: Убрать дублирование +
            foreach (var pair in _dictionary)
            {
                ClearTextBox(pair.Key);
            }
            _parameter = new LinkPinParameter();
        }


        //TODO: XML + устранить дублирование
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
            //TODO: Убрать дублирование +
            foreach (var pair in _dictionary)
            {
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
    }
}
