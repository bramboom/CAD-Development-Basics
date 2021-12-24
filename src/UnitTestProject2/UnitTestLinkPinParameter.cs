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

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству RodLength")]
        public void TestRodLength_CorrectSetRodLength()
        {
            var expected = 20.0;

            Assert.DoesNotThrow(
                () => Parameters.RodLength = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству HeadLength")]
        public void TestHeadLength_CorrectSetHeadLength()
        {
            var expected = 4.0;

            Assert.DoesNotThrow(
                () => Parameters.HeadLength = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству HoleRadius")]
        public void TestHoleRadius_CorrectSetHoleRadius()
        {
            var expected = 1.0;

            Assert.DoesNotThrow(
                () => Parameters.HoleRadius = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству RodChamferDepth")]
        public void TestRodChamferDepth_CorrectSetRodChamferDepth()
        {
            var expected = 0.5;

            Assert.DoesNotThrow(
                () => Parameters.RodChamferDepth = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству HeadChamferDepth")]
        public void TestHeadChamferDepth_CorrectSetHeadChamferDepth()
        {
            var expected = 0.5;

            Assert.DoesNotThrow(
                () => Parameters.HeadChamferDepth = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству RodAngleDepth")]
        public void TestRodAngleDepth_CorrectsetRodAngleDepth()
        {
            var expected = 15;

            Assert.DoesNotThrow(
                () => Parameters.RodAngleDepth = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству HeadAngleDepth")]
        public void TestHeadAngleDepth_CorrectSetHeadAngleDepth()
        {
            var expected = 15;

            Assert.DoesNotThrow(
                () => Parameters.HeadAngleDepth = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству HoleDistance")]
        public void TestHoleDistance_CorrectSetHoleDistance()
        {
            var expected = 4.0;

            Assert.DoesNotThrow(
                () => Parameters.HoleDistance = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству RodRadius")]
        public void TestRodRadius_CorrectSetRodRadius()
        {
            var expected = 4.0;

            Assert.DoesNotThrow(
                () => Parameters.RodRadius = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного "
            + "присвоения свойству HeadRadius")]
        public void TestHeadRadius_CorrectSetHeadRadius()
        {
            var expected = 5.0;

            Assert.DoesNotThrow(
                () => Parameters.HeadRadius = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства RodLength при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства RodLength при "
            + "значении больше максимального")]
        public void TestRodLength_IncorrectSetRodLength(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.RodLength = value,
                "Не входящее в диапазон "
                + "значение присвоилось RodLength");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HeadLength при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HeadLength при "
            + "значении больше максимального")]
        public void TestHeadLength_IncorrectSetHeadLength(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.HeadLength = value,
                "Не входящее в диапазон "
                + "значение присвоилось HeadLength");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HoleRadius при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HoleRadius при "
            + "значении больше максимального")]
        public void TestHoleRadius_IncorrectSetHoleRadius(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.HoleRadius = value,
                "Не входящее в диапазон "
                + "значение присвоилось HoleRadius");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства RodChamferDepth при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства RodChamferDepth при "
            + "значении больше максимального")]
        public void TestRodChamferDepth_IncorrectSetRodChamferDepth(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.RodChamferDepth = value,
                "Не входящее в диапазон "
                + "значение присвоилось RodChamferDepth");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HeadChamferDepth при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HeadChamferDepth при "
            + "значении больше максимального")]
        public void TestHeadChamferDepth_IncorrectSetHeadChamferDepth(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.HeadChamferDepth = value,
                "Не входящее в диапазон "
                + "значение присвоилось HeadChamferDepth");
        }

        [TestCase(-1, TestName = "Проверка некорректного ввода "
            + "у свойства RodAngleDepth при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства RodAngleDepth при "
            + "значении больше максимального")]
        public void TestRodAngleDepth_IncorrectSetRodAngleDepth(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.RodAngleDepth = value,
                "Не входящее в диапазон "
                + "значение присвоилось RodAngleDepth");
        }

        [TestCase(-1, TestName = "Проверка некорректного ввода "
            + "у свойства HeadAngleDepth при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HeadAngleDepth при "
            + "значении больше максимального")]
        public void TestHeadAngleDepth_IncorrectSetHeadAngleDepth(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.HeadAngleDepth = value,
                "Не входящее в диапазон "
                + "значение присвоилось HeadAngleDepth");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HoleDistance при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HoleDistance при "
            + "значении больше максимального")]
        public void TestHoleDistance_IncorrectSetHoleDistance(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.HoleDistance = value,
                "Не входящее в диапазон "
                + "значение присвоилось HoleDistance");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода "
            + "у свойства RodRadius при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства RodRadius при "
            + "значении больше максимального")]
        public void TestRodRadius_IncorrectSetRodRadius(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.RodRadius = value,
                "Не входящее в диапазон "
                + "значение присвоилось RodRadius");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода "
            + "у свойства HeadRadius при "
            + "значении меньше минимального")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HeadRadius при "
            + "значении больше максимального")]
        public void TestHeadRadius_IncorrectSetHeadRadius(double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.HeadRadius = value,
                "Не входящее в диапазон "
                + "значение присвоилось HeadRadius");
        }

        [TestCase( TestName = "Проверка корректного "
            + "возврата у свойства RodLength")]
        public void TestRodLength_CorrectGetRodLength()
        {
            var parameters = Parameters;
            var expected = 20.0;

            parameters.RodLength = expected;
            var actual = parameters.RodLength;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства HeadLength")]
        public void TestHeadLength_CorrectGetHeadLength()
        {
            var parameters = Parameters;
            var expected = 4.0;

            parameters.HeadLength = expected;
            var actual = parameters.HeadLength;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства HoleRadius")]
        public void TestHoleRadius_CorrectGetHoleRadius()
        {
            var parameters = Parameters;
            var expected = 1.0;

            parameters.HoleRadius = expected;
            var actual = parameters.HoleRadius;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства RodChamferDepth")]
        public void TestRodChamferDepth_CorrectGetRodChamferDepth()
        {
            var parameters = Parameters;
            var expected = 0.5;

            parameters.RodChamferDepth = expected;
            var actual = parameters.RodChamferDepth;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства HeadChamferDepth")]
        public void TestHeadChamferDepth_CorrectGetHeadChamferDepth()
        {
            var parameters = Parameters;
            var expected = 0.5;

            parameters.HeadChamferDepth = expected;
            var actual = parameters.HeadChamferDepth;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства RodAngleDepth")]
        public void TestRodAngleDepth_CorrectGetRodAngleDepth()
        {
            var parameters = Parameters;
            var expected = 15;

            parameters.RodAngleDepth = expected;
            var actual = parameters.RodAngleDepth;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства HeadAngleDepth")]
        public void TestHeadAngleDepth_CorrectGetHeadAngleDepth()
        {
            var parameters = Parameters;
            var expected = 15;

            parameters.HeadAngleDepth = expected;
            var actual = parameters.HeadAngleDepth;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства HoleDistance")]
        public void TestHoleDistance_CorrectGetHoleDistance()
        {
            var parameters = Parameters;
            var expected = 4.0;

            parameters.HoleDistance = expected;
            var actual = parameters.HoleDistance;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства RodRadius")]
        public void TestRodRadius_CorrectGetRodRadius()
        {
            var parameters = Parameters;
            var expected = 4.0;

            parameters.RodRadius = expected;
            var actual = parameters.RodRadius;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного "
            + "возврата у свойства HeadRadius")]
        public void TestHeadRadius_CorrectGetHeadRadius()
        {
            var parameters = Parameters;
            var expected = 5.0;

            parameters.HeadRadius = expected;
            var actual = parameters.HeadRadius;

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного присвоения "
            + "свойству RodLength при веденном HeadLength")]
        public void TestRodLength_CorrectSetRodLength_OtherValidation()
        {
            var parameters = Parameters;
            parameters.HeadLength = 4.0;

            var expected = 20.0;

            Assert.DoesNotThrow(
                () => parameters.RodLength = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного присвоения "
            + "свойству HeadLength при введенном RodLength")]
        public void TestHeadLength_CorrectSetHeadLength_OtherValidation()
        {
            var parameters = Parameters;
            parameters.RodLength = 20.0;

            var expected = 4.0;

            Assert.DoesNotThrow(
                () => parameters.HeadLength = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного присвоения "
            + "свойству HoleRadius при введенном HoleDistance")]
        public void TestHoleRadius_CorrectSetHoleRadius_OtherValidation()
        {
            var parameters = Parameters;
            parameters.HoleDistance = 4.0;

            var expected = 1.0;

            Assert.DoesNotThrow(
                () => parameters.HoleRadius = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного присвоения "
            + "свойству HoleDistance при введенном HoleRadius")]
        public void TestHoleDistance_CorrectSetHoleDistance_OtherValidation()
        {
            var parameters = Parameters;
            parameters.HoleRadius = 1.0;

            var expected = 4.0;

            Assert.DoesNotThrow(
                () => parameters.HoleDistance = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного присвоения "
            + "свойству RodRadius при введенном HeadRadius")]
        public void TestRodRadius_CorrectSetRodRadius_OtherValidation()
        {
            var parameters = Parameters;
            parameters.HeadRadius = 5.0;

            var expected = 4.0;

            Assert.DoesNotThrow(
                () => parameters.RodRadius = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(TestName = "Проверка корректного присвоения "
            + "свойству HeadRadius при введенном RodRadius")]
        public void TestHeadRadius_CorrectSetHeadRadius_OtherValidation()
        {
            var parameters = Parameters;
            parameters.RodRadius = 4.0;

            var expected = 5.0;

            Assert.DoesNotThrow(
                () => parameters.HeadRadius = expected,
                "значение выходит за пределы диапазона");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства RodLength при значении меньше "
            + "минимального и при веденном HeadLength")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства RodLength при значении больше "
            + "максимального и  при веденном HeadLength")]
        public void TestRodLength_IncorrectSetRodLength_OtherValidation(double value)
        {
            var parameters = Parameters;
            parameters.HeadLength = 4.0;

            Assert.Throws<ArgumentException>(
                () => parameters.RodLength = value,
                "Не входящее в диапазон значение "
                + "присвоилось RodLength");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HeadLength при значении меньше "
            + "минимального и при введенном RodLength")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HeadLength при значении больше "
            + "максимального и при введенном RodLength")]
        public void TestHeadLength_IncorrectSetHeadLength_OtherValidation(double value)
        {
            var parameters = Parameters;
            parameters.RodLength = 20.0;

            Assert.Throws<ArgumentException>(
                () => parameters.HeadLength = value,
                "Не входящее в диапазон значение "
                + "присвоилось HeadLength");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HoleRadius при значении меньше "
            + "минимального и при введенном HoleDistance")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HoleRadius при значении больше "
            + "максимального и при введенном HoleDistance")]
        public void TestHoleRadius_IncorrectSetHoleRadius_OtherValidation(double value)
        {
            var parameters = Parameters;
            parameters.HoleDistance = 4.0;

            Assert.Throws<ArgumentException>(
                () => parameters.HoleRadius = value,
                "Не входящее в диапазон значение "
                + "присвоилось HoleRadius");
        }

        [TestCase(0, TestName = "Проверка некорректного ввода "
            + "у свойства HoleDistance при значении меньше "
            + "минимального и при введенном HoleRadius")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HoleDistance при значении больше "
            + "максимального и при введенном HoleRadius")]
        public void TestHoleDistance_IncorrectSetHoleDistance_OtherValidation(double value)
        {
            var parameters = Parameters;
            parameters.HoleRadius = 1.0;

            Assert.Throws<ArgumentException>(
                () => parameters.HoleDistance = value,
                "Не входящее в диапазон значение "
                + "присвоилось HoleDistance");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода "
            + "у свойства RodRadius при значении меньше "
            + "минимального и при введенном HeadRadius")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства RodRadius при значении больше "
            + "максимального и при введенном HeadRadius")]
        public void TestRodRadius_IncorrectSetRodRadius_OtherValidation(double value)
        {
            var parameters = Parameters;
            parameters.HeadRadius = 5.0;

            Assert.Throws<ArgumentException>(
                () => parameters.RodRadius = value,
                "Не входящее в диапазон значение "
                + "присвоилось RodRadius");
        }

        [TestCase(1, TestName = "Проверка некорректного ввода "
            + "у свойства HeadRadius при значении меньше "
            + "минимального и при введенном RodRadius")]
        [TestCase(100, TestName = "Проверка некорректного ввода "
            + "у свойства HeadRadius при значении больше "
            + "максимального и при введенном RodRadius")]
        public void TestHeadRadius_IncorrectSetHeadRadius_OtherValidation(double value)
        {
            var parameters = Parameters;
            parameters.RodRadius = 4.0;

            Assert.Throws<ArgumentException>(
                () => parameters.HeadRadius = value,
                "Не входящее в диапазон значение "
                + "присвоилось HeadRadius");
        }

        [TestCase(1.5, true, 
            TestName = "Validator проверка "
                + "корректного значения")]
        [TestCase(2.1, false, 
            TestName = "Validator проверка "
                + "значения, больше максимального")]
        [TestCase(0.9, false, 
            TestName = "Validator проверка "
                + "значения, меньше минимального")]
        public void TestValue_CorrectValidator(double value, bool expected)
        {
            var minValue = 1.0;
            var maxValue = 2.0;

            var actual = 
                LinkPinParameter.Validator(value, minValue, maxValue);

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение "
                + "не равно актуальному");
        }

        [TestCase(Core.Parameters.RodLength, 20, 
            TestName = "SetValue значение "
                + "входящее в диапазон RodLength")]
        [TestCase(Core.Parameters.HeadLength, 4, 
            TestName = "SetValue значение "
                + "входящее в диапазон HeadLength")]
        [TestCase(Core.Parameters.HoleRadius, 1, 
            TestName = "SetValue значение "
                + "входящее в диапазон HoleRadius")]
        [TestCase(Core.Parameters.HeadRadius, 5, 
            TestName = "SetValue значение "
                + "входящее в диапазон HeadRadius")]
        [TestCase(Core.Parameters.RodRadius, 4, 
            TestName = "SetValue значение "
                + "входящее в диапазон RodRadius")]
        [TestCase(Core.Parameters.HoleDistance, 4, 
            TestName = "SetValue значение "
                + "входящее в диапазон HoleDistance")]
        [TestCase(Core.Parameters.RodChamfetDepth, 0.5, 
            TestName = "SetValue значение "
                + "входящее в диапазон RodChamfetDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 0.5, 
            TestName = "SetValue значение "
                + "входящее в диапазон HeadChamferDepth")]
        [TestCase(Core.Parameters.RodAngleDepth, 15, 
            TestName = "SetValue значение "
                + "входящее в диапазон RodAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, 15, 
            TestName = "SetValue значение "
                + "входящее в диапазон HeadAngleDepth")]
        public void TestValue_CorrectSetValue(Parameters parameter, double value)
        {
            Assert.DoesNotThrow(
                () => Parameters.SetValue(parameter, value), 
                "Входящее в диапазон значение присвоилось " 
                + parameter.ToString());
        }

        [TestCase(Core.Parameters.RodLength, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для RodLength")]
        [TestCase(Core.Parameters.RodLength, 100, 
            TestName = "SetValue значение больше "
                + "максимального для RodLength")]
        [TestCase(Core.Parameters.HeadLength, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для HeadLength")]
        [TestCase(Core.Parameters.HeadLength, 100, 
            TestName = "SetValue значение больше "
                + "максимального для HeadLength")]
        [TestCase(Core.Parameters.HoleDistance, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для HoleDistance")]
        [TestCase(Core.Parameters.HoleDistance, 100, 
            TestName = "SetValue значение больше "
                + "максимального для HoleDistance")]
        [TestCase(Core.Parameters.HoleRadius, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для HoleRadius")]
        [TestCase(Core.Parameters.HoleRadius, 100, 
            TestName = "SetValue значение больше "
                + "максимального для HoleRadius")]
        [TestCase(Core.Parameters.HeadRadius, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для HeadRadius")]
        [TestCase(Core.Parameters.HeadRadius, 100, 
            TestName = "SetValue значение больше "
                + "максимального для HeadRadius")]
        [TestCase(Core.Parameters.RodRadius, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для RodRadius")]
        [TestCase(Core.Parameters.RodRadius, 100, 
            TestName = "SetValue значение больше "
                + "максимального для RodRadius")]
        [TestCase(Core.Parameters.RodAngleDepth, -1, 
            TestName = "SetValue значение меньше "
                + "минимального для RodAngleDepth")]
        [TestCase(Core.Parameters.RodAngleDepth, 100, 
            TestName = "SetValue значение больше "
                + "максимального для RodAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, -1, 
            TestName = "SetValue значение меньше "
                + "минимального для HeadAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, 100, 
            TestName = "SetValue значение больше "
                + "максимального для HeadAngleDepth")]
        [TestCase(Core.Parameters.RodChamfetDepth, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для RodChamfetDepth")]
        [TestCase(Core.Parameters.RodChamfetDepth, 100, 
            TestName = "SetValue значение больше "
                + "максимального для RodChamfetDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для HeadChamferDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 100, 
            TestName = "SetValue значение больше "
                + "максимального для HeadChamferDepth")]
        public void TestValue_IncorrectSetValue(Parameters parameter, double value)
        {
            Assert.Throws<ArgumentException>(
                () => Parameters.SetValue(parameter, value), 
                "Не входящее в диапазон значение присвоилось " 
                + parameter.ToString());
        }

        [TestCase(TestName = "SetValue передача параметра "
                    + "не входящего в группу Parameters")]
        public void TestValue_DefaultSetValue()
        {
            Parameters parameter = Core.Parameters.HeadRadius + 1;

            Assert.DoesNotThrow(
                () => Parameters.SetValue(parameter, -1), 
                "Значение пыталось присвоиться полю");
        }
	}
}