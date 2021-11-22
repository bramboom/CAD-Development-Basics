using System;

namespace Core
{
    /// <summary>
    /// Параметры пальца
    /// </summary>
    public class LinkPinParameter
    {
        /// <summary>
        /// Длина стержня
        /// </summary>
        private double _rodLenght = double.NaN;
        
        /// <summary>
        /// Длина шляпки
        /// </summary>
        private double _headLenght = double.NaN;
        
        /// <summary>
        /// Радиус отверстия
        /// </summary>
        private double _holeRadius = double.NaN;
        
        /// <summary>
        /// Глубина фаски на стержне
        /// </summary>
        private double _rodChamferDepth = double.NaN;
        
        /// <summary>
        /// Глубина фаски на шляпки
        /// </summary>
        private double _headChamferDepth = double.NaN;
        
        /// <summary>
        /// Расстояние отверстия от кона стержня
        /// </summary>
        private double _holeDistance = double.NaN;
        
        /// <summary>
        /// Угол фаски на стержне
        /// </summary>
        private double _rodAngleDepth = double.NaN;
        
        /// <summary>
        /// Угол фаски на шляпке
        /// </summary>
        private double _headAngleDepth = double.NaN;
        
        /// <summary>
        /// Радиус стержня
        /// </summary>
        private double _rodRadius = double.NaN;
        
        /// <summary>
        /// Радиус шляпки
        /// </summary>
        private double _headRadius = double.NaN;

        /// <summary>
        /// Возвращает или задает значение длины стержня
        /// </summary>
        public double RodLenght
        {
            get => _rodLenght;
            set
            {
                const double minValue = 11.6;
                const double maxValue = 60.0;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _rodLenght = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение длины шляпки
        /// </summary>
        public double HeadLenght
        {
            get => _headLenght;
            set
            {
                const double minValue = 1.0;
                double maxValue = 8.0;

                if (!double.IsNaN(RodLenght))
                    maxValue = RodLenght * 2 / 5;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _headLenght = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение радиуса отверстия
        /// </summary>
        public double HoleRadius
        {
            get => _holeRadius;
            set
            {
                const double minValue = 0.4;
                double maxValue = 4.0;

                if (!double.IsNaN(RodRadius))
                    maxValue = RodLenght / 2;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _holeRadius = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение глубины фаски на стержне
        /// </summary>
        public double RodChamferDepth
        {
            get => _rodChamferDepth;
            set
            {
                const double minValue = 0.2;
                double maxValue = 5.0;

                if (!double.IsNaN(RodLenght))
                    maxValue = RodLenght / 2;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _rodChamferDepth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение глубины фаски на шляпке
        /// </summary>
        public double HeadChamferDepth
        {
            get => _headChamferDepth;
            set
            {
                const double minValue = 0.1; 
                double maxValue = 2.5;

                if (!double.IsNaN(HoleRadius))
                    maxValue = HoleRadius / 2;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _headChamferDepth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение расстояния от отверстия до конца стержня
        /// </summary>
        public double HoleDistance
        {
            get => _holeDistance;
            set
            {
                double minValue = 1.6;
                double maxValue = 10.0;

                if (!double.IsNaN(HoleRadius))
                {
                    if (!double.IsNaN(RodChamferDepth))
                        minValue = HoleRadius / 2 + RodChamferDepth;

                    if (!double.IsNaN(RodLenght))
                        maxValue = RodLenght - HoleRadius * 3 / 2;
                }

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _holeDistance = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение угла фаски на стержне
        /// </summary>
        public double RodAngleDepth
        {
            get => _rodAngleDepth;
            set
            {
                const double minValue = 0.0;
                const double maxValue = 30.0;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _rodAngleDepth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение угла фаски на шляпке
        /// </summary>
        public double HeadAngleDepth
        {
            get => _headAngleDepth;
            set
            {
                const double minValue = 0.0;
                const double maxValue = 45.0;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _headAngleDepth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение радиуса стержня 
        /// </summary>
        public double RodRadius
        {
            get => _rodRadius;
            set
            {
                const double minValue = 4.0;
                double maxValue = 40.0;

                if (!double.IsNaN(HeadRadius))
                    maxValue = HeadRadius * 3 / 4;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _rodRadius = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение радиуса шляпки
        /// </summary>
        public double HeadRadius
        {
            get => _headRadius;
            set
            {
                const double minValue = 5.0;
                const double maxValue = 50.0;

                if (Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _headRadius = value;
            }
        }

        /// <summary>
        /// Проверяет, входит ли значение параметра в нужный интервал
        /// </summary>
        /// <param name="value">значение параметра</param>
        /// <param name="minValue">минимальное значение</param>
        /// <param name="maxValue">максимальное значение</param>
        /// <returns>корректное значение или нет</returns>
        private bool Validator(double value, double minValue, double maxValue)
        {
            if (value < minValue)
                return false;
            
            if (value > maxValue)
                return false;

            return true;
        }
    }
}
