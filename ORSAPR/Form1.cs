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

namespace ORSAPR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            NewKeypressAllTextBox(Controls);

        }

        Draw draw = new Draw();

        FormValidator validator = new FormValidator();

        /// <summary>
        /// изменяет событие keyPress всем textBox
        /// </summary>
        /// <param name="ctrl">Коллекция элемента управления</param>
        private void NewKeypressAllTextBox(Control.ControlCollection ctrl)
        {
            foreach (Control control in ctrl)
            {
                if (control.GetType() == typeof(TextBox))
                    control.KeyPress += KeyPressOnlyDigit;
                if (control.GetType() == typeof(GroupBox))
                    NewKeypressAllTextBox(control.Controls);
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
                Casket casker = CreateCasket();
                validator.CheckWritedValues(casker);
                draw.BuilModel(casker);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                MessageBox.Show(outOfRange.Message);
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
                Casket casket = new Casket
                            {
                                Box = new Box
                                {
                                    Width = int.Parse(_textBoxWidth.Text),
                                    Length = int.Parse(_textBoxLength.Text),
                                    Height = int.Parse(_textBoxHeight.Text),
                                    InnerWidth = int.Parse(_textBoxInsideWidth.Text),
                                    InnerLength = int.Parse(_textBoxInsideLength.Text),
                                    InnerHeight = int.Parse(_textBoxInsideHeight.Text)
                                },
                                Cap = new Cap
                                {
                                    Width = int.Parse(_textBoxCapWidth.Text),
                                    Length = int.Parse(_textBoxCapLength.Text),
                                    Height = int.Parse(_textBoxCapHeight.Text),
                                },
                            };
                return casket;
            }
            catch
            {
                throw new Exception("Заполните все поля");
            }
        }
    }
}
