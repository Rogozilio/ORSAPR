using System;
using System.Windows.Forms;
using ORSAPR.model;
using ORSAPR.model.Interfaces;

namespace View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// API Команды к программе SOLIDWORKS
        /// </summary>
        private ISolidWorkCommander _commander = new SolidWorksCommander();
        /// <summary>
        /// Построитель шкатулки в SOLIDWORKS
        /// </summary>
        private Builder _build = new Builder();
        /// <summary>
        /// Заполнение параметров шкатулки
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        /// <returns>Объект шкатулки</returns>
        private Casket FillCasket(Casket casket)
        {
            try
            {
                casket.BoxWidth.Value = int.Parse(_textBoxWidth.Text);
                casket.BoxHeight.Value = int.Parse(_textBoxHeight.Text);
                casket.BoxLength.Value = int.Parse(_textBoxLength.Text);
                casket.BoxInnerWidth.Value = int.Parse(_textBoxInsideWidth.Text);
                casket.BoxInnerHeight.Value = int.Parse(_textBoxInsideHeight.Text);
                casket.BoxInnerLength.Value = int.Parse(_textBoxInsideLength.Text);
                casket.CapWidth.Value = int.Parse(_textBoxCapWidth.Text);
                casket.CapHeight.Value = int.Parse(_textBoxCapHeight.Text);
                casket.CapLength.Value = int.Parse(_textBoxCapLength.Text);
                return casket;
            }
            catch
            {
                throw new Exception("Заполните все поля");
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
                Casket casket = new Casket();
                casket = FillCasket(casket);
                casket.CheckWritedValues();
                _build.BuilModel(casket,_commander);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
        /// <summary>
        /// Задает значение полей по умолчанию
        /// </summary>
        private void ButtonValueDefault_Click(object sender, EventArgs e)
        {
            Casket valueDefault = new Casket(true);
            _textBoxWidth.Text = valueDefault.BoxWidth.Value.ToString();
            _textBoxLength.Text = valueDefault.BoxLength.Value.ToString();
            _textBoxHeight.Text = valueDefault.BoxHeight.Value.ToString();
            _textBoxInsideWidth.Text = valueDefault.BoxInnerWidth.Value.ToString();
            _textBoxInsideLength.Text = valueDefault.BoxInnerLength.Value.ToString();
            _textBoxInsideHeight.Text = valueDefault.BoxInnerHeight.Value.ToString();
            _textBoxCapWidth.Text = valueDefault.CapWidth.Value.ToString();
            _textBoxCapLength.Text = valueDefault.CapLength.Value.ToString();
            _textBoxCapHeight.Text = valueDefault.CapHeight.Value.ToString();
        }
    }
}
