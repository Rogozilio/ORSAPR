using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using ORSAPR.model;
using System.Diagnostics;

namespace View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            NewKeyPressAllTextBox(Controls);
        }
        private List<TextBox> _listTextBox = new List<TextBox>();

        private Builder _draw = new Builder();

        /// <summary>
        /// изменяет событие keyPress всем textBox
        /// </summary>
        /// <param name="ctrl">Коллекция элемента управления</param>
        private void NewKeyPressAllTextBox(Control.ControlCollection ctrl)
        {
            foreach (Control control in ctrl)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.KeyPress += KeyPressOnlyDigit;
                    _listTextBox.Add((TextBox)control);
                } 
                if (control.GetType() == typeof(GroupBox))
                    NewKeyPressAllTextBox(control.Controls);
            }  
        }
        /// <summary>
        /// Событие для ввода только цифр
        /// </summary>
        private void KeyPressOnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Строит модель шкатулки в SolidWorks 2020
        /// </summary>
        private void ButtonBuild_Click(object sender, EventArgs e)
        {
            try
            {
                Casket casker = new Casket(_listTextBox);
                _draw.BuilModel(casker);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Присваивает значения объекту Casket из введенных данных
        /// </summary>
        private Casket CreateCasket()
        {
            try
            {
                Casket casket = new Casket(_listTextBox);
                //Casket casket = new Casket
                //{
                //    Box = new Box
                //    {
                //        Width = int.Parse(_textBoxWidth.Text),
                //        Length = int.Parse(_textBoxLength.Text),
                //        Height = int.Parse(_textBoxHeight.Text),
                //        InnerWidth = int.Parse(_textBoxInsideWidth.Text),
                //        InnerLength = int.Parse(_textBoxInsideLength.Text),
                //        InnerHeight = int.Parse(_textBoxInsideHeight.Text)
                //    },
                //    Cap = new Cap
                //    {
                //        Width = int.Parse(_textBoxCapWidth.Text),
                //        Length = int.Parse(_textBoxCapLength.Text),
                //        Height = int.Parse(_textBoxCapHeight.Text),
                //    },
                //};
                return casket;
            }
            catch
            {
                throw new Exception("Заполните все поля");
            }
        }
        /// <summary>
        /// Задает значение полей по умолчанию
        /// </summary>
        private void ButtonValueDefault_Click(object sender, EventArgs e)
        {
            Casket valueDefault = new Casket();
            _textBoxWidth.Text = valueDefault.Box.Width.ToString();
            _textBoxLength.Text = valueDefault.Box.Length.ToString();
            _textBoxHeight.Text = valueDefault.Box.Height.ToString();
            _textBoxInsideWidth.Text = valueDefault.Box.InnerWidth.ToString();
            _textBoxInsideLength.Text = valueDefault.Box.InnerLength.ToString();
            _textBoxInsideHeight.Text = valueDefault.Box.InnerHeight.ToString();
            _textBoxCapWidth.Text = valueDefault.Cap.Width.ToString();
            _textBoxCapLength.Text = valueDefault.Cap.Length.ToString();
            _textBoxCapHeight.Text = valueDefault.Cap.Height.ToString();
        }
    }
}
