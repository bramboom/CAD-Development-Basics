using System;
using Core;
using NUnit.Framework;

namespace TestCore
{
	/// <summary>
	/// Класс теста 
	/// </summary>
	[TestFixture]
	public class TestDetailParameters
	{
		/// <summary>
		/// Возвращает новый экземпляр класса
		/// </summary>
		private LinkPinParameter Parameters => new LinkPinParameter();

        [TestCase( TestName = "Проверка корректного возврата у свойства RodLength")]
        public void TestInnerRodLenght_CorrectGetInnerRodLenght()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 15.0;

            detailParameters.RodLenght = expected;

            var actual = detailParameters.RodLenght;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadLenght")]
        public void TestInnerHeadLenght_CorrectGetInnerHeadLenght()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.HeadLenght = expected;

            var actual = detailParameters.HeadLenght;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HoleRadius")]
        public void TestInnerHoleRadius_CorrectGetInnerHoleRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 2.0;

            detailParameters.HoleRadius = expected;

            var actual = detailParameters.HoleRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства RodChamferDepth")]
        public void TestInnerRodChamferDepth_CorrectGetInnerRodChamferDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 1.0;

            detailParameters.RodChamferDepth = expected;

            var actual = detailParameters.RodChamferDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadChamferDepth")]
        public void TestInnerHeadChamferDepth_CorrectGetInnerHeadChamferDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 1.0;

            detailParameters.HeadChamferDepth = expected;

            var actual = detailParameters.HeadChamferDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства RodAngleDepth")]
        public void TestInnerRodAngleDepth_CorrectGetInnerRodAngleDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.RodAngleDepth = expected;

            var actual = detailParameters.RodAngleDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadAngleDepth")]
        public void TestInnerHeadAngleDepth_CorrectGetInnerHeadAngleDepth()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.HeadAngleDepth = expected;

            var actual = detailParameters.HeadAngleDepth;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HoleDistance")]
        public void TestInnerHoleDistance_CorrectGetInnerHoleDistance()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.HoleDistance = expected;

            var actual = detailParameters.HoleDistance;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства RodRadius")]
        public void TestInnerRodRadius_CorrectGetInnerRodRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 4.0;

            detailParameters.RodRadius = expected;

            var actual = detailParameters.RodRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
        }

        [TestCase(TestName = "Проверка корректного возврата у свойства HeadRadius")]
        public void TestInnerHeadRadius_CorrectGetInnerHeadRadius()
        {
            var detailParameters = new LinkPinParameter();

            var expected = 10.0;

            detailParameters.HeadRadius = expected;

            var actual = detailParameters.HeadRadius;

            Assert.AreEqual(expected, actual, "Возвращенное значение не равно ожидаемому");
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

        [TestCase(Core.Parameters.RodLength, 15, TestName = "SetValue значение входящее в диапазон RodLength")]
        [TestCase(Core.Parameters.HeadLength, 10, TestName = "SetValue значение входящее в диапазон HeadLength")]
        [TestCase(Core.Parameters.HoleRadius, 2, TestName = "SetValue значение входящее в диапазон HoleRadius")]
        [TestCase(Core.Parameters.HeadRadius, 8, TestName = "SetValue значение входящее в диапазон HeadRadius")]
        [TestCase(Core.Parameters.RodRadius, 5, TestName = "SetValue значение входящее в диапазон RodRadius")]
        [TestCase(Core.Parameters.HoleDistance, 4, TestName = "SetValue значение входящее в диапазон HoleDistance")]
        [TestCase(Core.Parameters.RodChamfetDepth, 1, TestName = "SetValue значение входящее в диапазон RodChamfetDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 1, TestName = "SetValue значение входящее в диапазон HeadChamferDepth")]
        [TestCase(Core.Parameters.RodAngleDepth, 1, TestName = "SetValue значение входящее в диапазон RodAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, 1, TestName = "SetValue значение входящее в диапазон HeadAngleDepth")]
        public void TestValaue_CorrectSetValue(Core.Parameters parameter, double value)
        {
            var linkPinParameter = new LinkPinParameter();

            Assert.DoesNotThrow(() => linkPinParameter.SetValue(parameter, value), "Не входящее в диапазон значение присвоилось " + parameter.ToString());
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
        public void TestValaue_IncorrectSetValue(Core.Parameters parameter, double value)
        {
            var linkPinParameter = new LinkPinParameter();

            Assert.Throws<ArgumentException>(() => linkPinParameter.SetValue(parameter, value), "Не входящее в диапазон значение присвоилось " + parameter.ToString());
        }
	}
}