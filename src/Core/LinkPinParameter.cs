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
        private double _rodLength = 20.0;
        
        /// <summary>
        /// Длина шляпки
        /// </summary>
        private double _headLength = 4.0;
        
        /// <summary>
        /// Радиус отверстия
        /// </summary>
        private double _holeRadius = 1.0;
        
        /// <summary>
        /// Глубина фаски на стержне
        /// </summary>
        private double _rodChamferDepth = 0.5;
        
        /// <summary>
        /// Глубина фаски на шляпки
        /// </summary>
        private double _headChamferDepth = 0.5;
        
        /// <summary>
        /// Расстояние отверстия от кона стержня
        /// </summary>
        private double _holeDistance = 4.0;
        
        /// <summary>
        /// Угол фаски на стержне
        /// </summary>
        private double _rodAngleDepth = 15;
        
        /// <summary>
        /// Угол фаски на шляпке
        /// </summary>
        private double _headAngleDepth = 15;
        
        /// <summary>
        /// Радиус стержня
        /// </summary>
        private double _rodRadius = 4;
        
        /// <summary>
        /// Радиус шляпки
        /// </summary>
        private double _headRadius = 5;

        /// <summary>
        /// Возвращает или задает значение длины стержня
        /// </summary>
        public double RodLength
        {
            get => _rodLength;
            set
            {
                double minValue = 12.0; 
                const double maxValue = 60.0;

                if (!double.IsNaN(HeadLength))
                    minValue = HeadLength * 5;



                if (!Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _rodLength = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение длины шляпки
        /// </summary>
        public double HeadLength
        {
            get => _headLength;
            set
            {
                const double minValue = 2.4;
                double maxValue = 12.0;

                if (!double.IsNaN(RodLength))
                    maxValue = RodLength * 0.2;

                if (!Validator(value, minValue, maxValue))
                    throw new ArgumentException("incorrect value");

                _headLength = value;
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
                double minValue = 1.0;
                double maxValue = 3.0;

                if (!double.IsNaN(HoleDistance))
                    maxValue = HoleDistance - maxValue;

                if (!Validator(value, minValue, maxValue))
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
                const double maxValue = 2.0;

                if (!Validator(value, minValue, maxValue))
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
                const double maxValue = 1.2;

                if (!Validator(value, minValue, maxValue))
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
                double minValue = 3.0;
                const double maxValue = 9.0;

                minValue = minValue + HoleRadius;

                if (!Validator(value, minValue, maxValue))
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

                if (!Validator(value, minValue, maxValue))
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

                if (!Validator(value, minValue, maxValue))
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
                double minValue = 4.0;
                double maxValue = 20.0;

                if (!double.IsNaN(HeadRadius))
                    maxValue = HeadRadius * 0.8;

                if (!Validator(value, minValue, maxValue))
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
                double minValue = 5.0; 
                const double maxValue = 25.0;

                if (!double.IsNaN(RodRadius))
                    minValue = RodRadius * 5 / 4;

                if (!Validator(value, minValue, maxValue))
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
        public static bool Validator(double value, double minValue, double maxValue)
        {
            if (value < minValue)
                return false;
            
            if (value > maxValue)
                return false;

            return true;
        }

        public void SetValue(Parameters parameter, double value)
        {
            switch (parameter)
            {
                case Parameters.RodLength:
                {
                    RodLength = value;
                    break;
                }
                case Parameters.HeadLength:
                {
                    HeadLength = value;
                    break;
                }
                case Parameters.HoleRadius:
                {
                    HoleRadius = value;
                    break;
                }
                case Parameters.RodChamfetDepth:
                {
                    RodChamferDepth = value;
                    break;
                }
                case Parameters.HeadChamferDepth:
                {
                    HeadChamferDepth = value;
                    break;
                }
                case Parameters.RodAngleDepth:
                {
                    RodAngleDepth = value;
                    break;
                }
                case Parameters.HeadAngleDepth:
                {
                    HeadAngleDepth = value;
                    break;
                }
                case Parameters.HoleDistance:
                {
                    HoleDistance = value;
                    break;
                }
                case Parameters.RodRadius:
                {
                    RodRadius = value;
                    break;
                }
                case Parameters.HeadRadius:
                {
                    HeadRadius = value;
                    break;
                }
            }
        }
    }
}
