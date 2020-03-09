using ORSAPR.model.Exceptions;
using System;
using ORSAPR.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORSAPR.model
{
    /// <summary>
    /// Класс для проверки ввода корректных значений полей
    /// </summary>
    class FormValidator
    {
        private int _minWidthBase = 100;

        private int _maxWidthBase = 200;

        private int _minLengthBase = 100;

        private int _maxLengthBase = 200;

        private int _minHieghtBase = 50;

        private int _maxHieghtBase = 150;

        private int _minWidthInnerBase = 50;

        private int _maxWidthInnerBase = 190;

        private int _minLengthInnerBase = 50;

        private int _maxLengthInnerBase = 190;

        private int _minHieghtInnerBase = 30;

        private int _maxHieghtInnerBase = 140;

        private int _minWidthCap = 100;

        private int _maxWidthCap = 230;

        private int _minLengthCap = 100;

        private int _maxLengthCap = 230;

        private int _minHieghtCap = 10;

        private int _maxHieghtCap = 30;
        /// <summary>
        /// Проверка полей на корректность ввода
        /// </summary>
        /// <param name="casket">Объект шкатулки</param>
        public void CheckWritedValues(Casket casket)
        {
            _maxWidthInnerBase = (casket.Box.Width > _maxWidthBase) ? _maxWidthBase : casket.Box.Width;
            _maxLengthInnerBase = ((casket.Box.Length > _maxLengthBase) ? _maxLengthBase : casket.Box.Length);
            _maxHieghtInnerBase = ((casket.Box.Height > _maxHieghtBase) ? _maxHieghtBase : casket.Box.Height);
            _minWidthCap = ((casket.Box.InnerWidth > _minWidthCap) ? casket.Box.InnerWidth : _minWidthCap);
            _minLengthCap = ((casket.Box.InnerLength > _minLengthCap) ? casket.Box.InnerLength : _minWidthCap);

            CheckRangeValue(casket.Box.Width, _minWidthBase, _maxWidthBase, "Ширина основания");
            CheckRangeValue(casket.Box.Length, _minLengthBase, _maxLengthBase, "Длина основания");
            CheckRangeValue(casket.Box.Height, _minHieghtBase, _maxHieghtBase, "Высота основания");

            CheckRangeValue(casket.Box.InnerWidth, _minWidthInnerBase, _maxWidthInnerBase, "Ширина внутренней части");
            CheckRangeValue(casket.Box.InnerLength, _minLengthInnerBase, _maxLengthInnerBase, "Длина внутренней части");
            CheckRangeValue(casket.Box.InnerHeight, _minHieghtInnerBase, _maxHieghtInnerBase, "Высота внутренней части");

            CheckRangeValue(casket.Cap.Width, _minWidthCap, _maxWidthCap, "Ширина крышки");
            CheckRangeValue(casket.Cap.Length, _minLengthCap, _maxLengthCap, "Длина крышки");
            CheckRangeValue(casket.Cap.Height, _minHieghtCap, _maxHieghtCap, "Высота крышки");
        }
        /// <summary>
        /// Проверка value в диапазоне (min-max) 
        /// </summary>
        /// <param name="value">Значение поля</param>
        /// <param name="min">Минимальная значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="textException">Текст при нарушении диапазона</param>
        private void CheckRangeValue(int value, int min, int max, string nameException)
        {
            if (value < min || value > max)
                throw new ValueOutOfRangeException(nameException,min,max);
        }
    }
}
