using System;
using Core;
using NUnit.Framework;

namespace UnitTestProject2
{
	/// <summary>
	/// Класс теста 
	/// </summary>
	[TestFixture]
	public class UnitTestLinkPinParameter
    {
		/// <summary>
		/// Возвращает новый экземпляр класса
		/// </summary>
		private LinkPinParameter Parameters => new LinkPinParameter();

        [TestCase( TestName = "Проверка корректного возврата у свойства RodLength")]
        public void TestInnerRodLenght_CorrectGetInnerRodLenght()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 20.0;

            var actual = detailParameters.RodLenght;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadLenght")]
        public void TestInnerHeadLenght_CorrectGetInnerHeadLenght()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            var actual = detailParameters.HeadLenght;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HoleRadius")]
        public void TestInnerHoleRadius_CorrectGetInnerHoleRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 1.0;

            var actual = detailParameters.HoleRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства RodChamferDepth")]
        public void TestInnerRodChamferDepth_CorrectGetInnerRodChamferDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 0.5;

            var actual = detailParameters.RodChamferDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadChamferDepth")]
        public void TestInnerHeadChamferDepth_CorrectGetInnerHeadChamferDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 0.5;

            var actual = detailParameters.HeadChamferDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства RodAngleDepth")]
        public void TestInnerRodAngleDepth_CorrectGetInnerRodAngleDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 15;

            var actual = detailParameters.RodAngleDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadAngleDepth")]
        public void TestInnerHeadAngleDepth_CorrectGetInnerHeadAngleDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 15;

            var actual = detailParameters.HeadAngleDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HoleDistance")]
        public void TestInnerHoleDistance_CorrectGetInnerHoleDistance()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            var actual = detailParameters.HoleDistance;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства RodRadius")]
        public void TestInnerRodRadius_CorrectGetInnerRodRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            var actual = detailParameters.RodRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadRadius")]
        public void TestInnerHeadRadius_CorrectGetInnerHeadRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 5.0;

            var actual = detailParameters.HeadRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству RodLength")]
        public void TestInnerRodLenght_CorrectSetInnerRodLenght()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 20.0;

            detailParameters.HeadRadius = expected;

            var actual = detailParameters.HeadRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству HeadLenght")]
        public void TestInnerHeadLenght_CorrectSetInnerHeadLenght()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.HeadLenght = expected;

            var actual = detailParameters.HeadLenght;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству HoleRadius")]
        public void TestInnerHoleRadius_CorrectSetInnerHoleRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 1.0;

            detailParameters.HoleRadius = expected;

            var actual = detailParameters.HoleRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству RodChamferDepth")]
        public void TestInnerRodChamferDepth_CorrectSetInnerRodChamferDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 0.5;

            detailParameters.RodChamferDepth = expected;

            var actual = detailParameters.RodChamferDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству HeadChamferDepth")]
        public void TestInnerHeadChamferDepth_CorrectSetInnerHeadChamferDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 0.5;

            detailParameters.HeadChamferDepth = expected;

            var actual = detailParameters.HeadChamferDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству RodAngleDepth")]
        public void TestInnerRodAngleDepth_CorrectsetInnerRodAngleDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 15;

            detailParameters.RodAngleDepth = expected;

            var actual = detailParameters.RodAngleDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству HeadAngleDepth")]
        public void TestInnerHeadAngleDepth_CorrectSetInnerHeadAngleDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 15;

            detailParameters.HeadAngleDepth = expected;

            var actual = detailParameters.HeadAngleDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству HoleDistance")]
        public void TestInnerHoleDistance_CorrectSetInnerHoleDistance()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.HoleDistance = expected;

            var actual = detailParameters.HoleDistance;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству RodRadius")]
        public void TestInnerRodRadius_CorrectSetInnerRodRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.RodRadius = expected;

            var actual = detailParameters.RodRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения свойству HeadRadius")]
        public void TestInnerHeadRadius_CorrectSetInnerHeadRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 5.0;

            detailParameters.HeadRadius = expected;

            var actual = detailParameters.HeadRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода у свойства RodLength при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства RodLength при значении больше максимального")]
        public void TestInnerRodLenght_IncorrectSetInnerRodLenght(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.RodLenght = value,
                "Не входящее в диапазон значение присвоилось RodLength");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода у свойства HeadLenght при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства HeadLenght при значении больше максимального")]
        public void TestInnerHeadLenght_IncorrectSetInnerHeadLenght(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.HeadLenght = value,
                "Не входящее в диапазон значение присвоилось HeadLenght");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода у свойства HoleRadius при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства HoleRadius при значении больше максимального")]
        public void TestInnerHoleRadius_IncorrectSetInnerHoleRadius(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.HoleRadius = value,
                "Не входящее в диапазон значение присвоилось HoleRadius");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода у свойства RodChamferDepth при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства RodChamferDepth при значении больше максимального")]
        public void TestInnerRodChamferDepth_IncorrectSetInnerRodChamferDepth(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.RodChamferDepth = value,
                "Не входящее в диапазон значение присвоилось RodChamferDepth");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода у свойства HeadChamferDepth при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства HeadChamferDepth при значении больше максимального")]
        public void TestInnerHeadChamferDepth_IncorrectSetInnerHeadChamferDepth(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.HeadChamferDepth = value,
                "Не входящее в диапазон значение присвоилось HeadChamferDepth");
        }

        [TestCase(-1, TestName = "Проверка некорректного ввода у свойства RodAngleDepth при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства RodAngleDepth при значении больше максимального")]
        public void TestInnerRodAngleDepth_IncorrectSetInnerRodAngleDepth(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.RodAngleDepth = value,
                "Не входящее в диапазон значение присвоилось RodAngleDepth");
        }

        [TestCase(-1, TestName = "Проверка некорректного ввода у свойства HeadAngleDepth при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства HeadAngleDepth при значении больше максимального")]
        public void TestInnerHeadAngleDepth_IncorrectSetInnerHeadAngleDepth(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.HeadAngleDepth = value,
                "Не входящее в диапазон значение присвоилось HeadAngleDepth");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода у свойства HoleDistance при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства HoleDistance при значении больше максимального")]
        public void TestInnerHoleDistance_IncorrectSetInnerHoleDistance(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.HoleDistance = value,
                "Не входящее в диапазон значение присвоилось HoleDistance");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода у свойства RodRadius при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства RodRadius при значении больше максимального")]
        public void TestInnerRodRadius_IncorrectSetInnerRodRadius(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.RodRadius = value,
                "Не входящее в диапазон значение присвоилось RodRadius");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода у свойства HeadRadius при значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода у свойства HeadRadius при значении больше максимального")]
        public void TestInnerHeadRadius_IncorrectSetInnerHeadRadius(double value)
        {
            var detailParameters = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => detailParameters.HeadRadius = value,
                "Не входящее в диапазон значение присвоилось HeadRadius");
        }

        [TestCase(1.5, true, TestName = "Validator проверка корректного значения")]
        [TestCase(2.1, false, TestName = "Validator проверка значения, больше максимального")]
        [TestCase(0.9, false, TestName = "Validator проверка значения, меньше минимального")]
        public void TestValue_CorrectValidator(double value, bool expected)
        {
            var minValue = 1.0;
            var maxValue = 2.0;

            var actual = LinkPinParameter.Validator(value, minValue, maxValue);

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно актуальному");
        }

        [TestCase(Core.Parameters.RodLength, 20, TestName = "SetValue значение входящее в диапазон RodLength")]
        [TestCase(Core.Parameters.HeadLength, 4, TestName = "SetValue значение входящее в диапазон HeadLength")]
        [TestCase(Core.Parameters.HoleRadius, 1, TestName = "SetValue значение входящее в диапазон HoleRadius")]
        [TestCase(Core.Parameters.HeadRadius, 5, TestName = "SetValue значение входящее в диапазон HeadRadius")]
        [TestCase(Core.Parameters.RodRadius, 4, TestName = "SetValue значение входящее в диапазон RodRadius")]
        [TestCase(Core.Parameters.HoleDistance, 4, TestName = "SetValue значение входящее в диапазон HoleDistance")]
        [TestCase(Core.Parameters.RodChamfetDepth, 0.5, TestName = "SetValue значение входящее в диапазон RodChamfetDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 0.5, TestName = "SetValue значение входящее в диапазон HeadChamferDepth")]
        [TestCase(Core.Parameters.RodAngleDepth, 15, TestName = "SetValue значение входящее в диапазон RodAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, 15, TestName = "SetValue значение входящее в диапазон HeadAngleDepth")]
        public void TestValue_CorrectSetValue(Core.Parameters parameter, double value)
        {
            var linkPinParameter = new LinkPinParameter();

            Assert.DoesNotThrow(() => linkPinParameter.SetValue(parameter, value), "Входящее в диапазон значение присвоилось " + parameter.ToString());
        }

        [TestCase(Core.Parameters.RodLength, 0, TestName = "SetValue значение меньше минимального для RodLength")]
        [TestCase(Core.Parameters.RodLength, 100, TestName = "SetValue значение больше максимального для RodLength")]
        [TestCase(Core.Parameters.HeadLength, 0, TestName = "SetValue значение меньше минимального для HeadLength")]
        [TestCase(Core.Parameters.HeadLength, 100, TestName = "SetValue значение больше максимального для HeadLength")]
        [TestCase(Core.Parameters.HoleDistance, 0, TestName = "SetValue значение меньше минимального для HoleDistance")]
        [TestCase(Core.Parameters.HoleDistance, 100, TestName = "SetValue значение больше максимального для HoleDistance")]
        [TestCase(Core.Parameters.HoleRadius, 0, TestName = "SetValue значение меньше минимального для HoleRadius")]
        [TestCase(Core.Parameters.HoleRadius, 100, TestName = "SetValue значение больше максимального для HoleRadius")]
        [TestCase(Core.Parameters.HeadRadius, 0, TestName = "SetValue значение меньше минимального для HeadRadius")]
        [TestCase(Core.Parameters.HeadRadius, 100, TestName = "SetValue значение больше максимального для HeadRadius")]
        [TestCase(Core.Parameters.RodRadius, 0, TestName = "SetValue значение меньше минимального для RodRadius")]
        [TestCase(Core.Parameters.RodRadius, 100, TestName = "SetValue значение больше максимального для RodRadius")]
        [TestCase(Core.Parameters.RodAngleDepth, -1, TestName = "SetValue значение меньше минимального для RodAngleDepth")]
        [TestCase(Core.Parameters.RodAngleDepth, 100, TestName = "SetValue значение больше максимального для RodAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, -1, TestName = "SetValue значение меньше минимального для HeadAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, 100, TestName = "SetValue значение больше максимального для HeadAngleDepth")]
        [TestCase(Core.Parameters.RodChamfetDepth, 0, TestName = "SetValue значение меньше минимального для RodChamfetDepth")]
        [TestCase(Core.Parameters.RodChamfetDepth, 100, TestName = "SetValue значение больше максимального для RodChamfetDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 0, TestName = "SetValue значение меньше минимального для HeadChamferDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 100, TestName = "SetValue значение больше максимального для HeadChamferDepth")]
        public void TestValue_IncorrectSetValue(Core.Parameters parameter, double value)
        {
            var linkPinParameter = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => linkPinParameter.SetValue(parameter, value), "Не входящее в диапазон значение присвоилось " + parameter.ToString());
        }

        [TestCase(TestName = "SetValue передача параметра не входящего в группу Parameters")]
        public void TestValue_DefaultSetValue()
        {
            var linkPinParameter = new LinkPinParameter();
            Parameters parameter = Core.Parameters.HeadRadius + 1;

            Assert.DoesNotThrow(() => linkPinParameter.SetValue(parameter, -1), "Значение пыталось присвоиться полю");
        }
	}
}