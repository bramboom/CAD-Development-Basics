using System;
using Core;
using NUnit.Framework;

namespace TestCore
{
	/// <summary>
	/// Класс теста <see cref="Core.DetailParameters"/>
	/// </summary>
	[TestFixture]
	public class TestDetailParameters
	{
		/// <summary>
		/// Возвращает новый экземпляр класса <see cref="Core.DetailParameters"/>
		/// </summary>
		private LinkPinParameter DetailParameters => new LinkPinParameter();

        [TestCase(TestName = "Проверка корректного возврата у свойства RodLength")]
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

            var expected = 4.0;

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
	}
}