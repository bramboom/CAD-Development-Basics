using System;
using Core;
using NUnit.Framework;

namespace UnitTest
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

        //TODO: Убрать дубли +
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
        [TestCase(Core.Parameters.RodChamferDepth, 0.5, 
            TestName = "SetValue значение "
                + "входящее в диапазон RodChamferDepth")]
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
                $"Входящее в диапазон значение присвоилось {parameter}");
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
        [TestCase(Core.Parameters.RodChamferDepth, 0, 
            TestName = "SetValue значение меньше "
                + "минимального для RodChamferDepth")]
        [TestCase(Core.Parameters.RodChamferDepth, 100, 
            TestName = "SetValue значение больше "
                + "максимального для RodChamferDepth")]
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
                $"Не входящее в диапазон значение присвоилось {parameter}");
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

        [TestCase(Core.Parameters.RodLength, 20,
            TestName = "GetValue возвращение "
                       + "значения из свойства RodLength")]
        [TestCase(Core.Parameters.HeadLength, 4,
            TestName = "GetValue возвращение "
                       + "значения из свойства HeadLength")]
        [TestCase(Core.Parameters.HoleRadius, 1,
            TestName = "GetValue возвращение "
                       + "значения из свойства HoleRadius")]
        [TestCase(Core.Parameters.RodChamferDepth, 0.5,
            TestName = "GetValue возвращение "
                       + "значения из свойства RodChamferDepth")]
        [TestCase(Core.Parameters.HeadChamferDepth, 0.5,
            TestName = "GetValue возвращение "
                       + "значения из свойства HeadChamferDepth")]
        [TestCase(Core.Parameters.RodAngleDepth, 15,
            TestName = "GetValue возвращение "
                       + "значения из свойства RodAngleDepth")]
        [TestCase(Core.Parameters.HeadAngleDepth, 15,
            TestName = "GetValue возвращение "
                       + "значения из свойства HeadAngleDepth")]
        [TestCase(Core.Parameters.HoleDistance, 4,
            TestName = "GetValue возвращение "
                       + "значения из свойства HoleDistance")]
        [TestCase(Core.Parameters.RodRadius, 4,
            TestName = "GetValue возвращение "
                       + "значения из свойства RodRadius")]
        [TestCase(Core.Parameters.HeadRadius, 5,
            TestName = "GetValue возвращение "
                       + "значения из свойства HeadRadius")]
        public void TestValue_GetValue(Parameters parameter, double expected)
        {
            var parameters = Parameters;
            parameters.SetValue(parameter, expected);

            var actual = parameters.GetValue(parameter);

            Assert.AreEqual(expected, actual, 
                "Возвращенное значение не "
                + "соответствует ожидаемому "
                + $"(свойство {parameter})");
        }

        [TestCase(11, 
            TestName = "GetValue возвращение "
                       + "значения по дефолту")]
        public void TestValue_GetValue(Parameters parameter)
        {
            var expected = double.NaN;

            var actual = Parameters.GetValue(parameter);

            Assert.AreEqual(expected, actual,
                "Возвращенное значение не "
                + "соответствует ожидаемому ");
        }

        [TestCase(Core.Parameters.RodLength, 
            Core.Parameters.HeadLength, 20, 4, 
            TestName = "SetValue значения в свойство " 
            + "RodLength при введенном значении HeadLength")]
        [TestCase(Core.Parameters.HeadLength, 
            Core.Parameters.RodLength, 4, 20, 
            TestName = "SetValue значения в свойство "
            + "HeadLength при введенном значении RodLength")]
        [TestCase(Core.Parameters.HoleDistance, 
            Core.Parameters.HoleRadius, 4, 1, 
            TestName = "SetValue значения в свойство "
            + "HoleDistance при введенном значении HoleRadius")]
        [TestCase(Core.Parameters.HoleRadius, 
            Core.Parameters.HoleDistance, 1, 4, 
            TestName = "SetValue значения в свойство "
            + "HoleRadius при введенном значении HoleDistance")]
        [TestCase(Core.Parameters.RodRadius, 
            Core.Parameters.HeadRadius, 4, 5, 
            TestName = "SetValue значения в свойство "
            + "RodRadius при введенном значении HeadRadius")]
        [TestCase(Core.Parameters.HeadRadius, 
            Core.Parameters.RodRadius, 5, 4, 
            TestName = "SetValue значения в свойство "
            + "HeadRadius при введенном значении RodRadius")]
        public void TestValue_SetValueWithDependentParameter(
            Parameters firstParameter, Parameters secondParameter,
            double firstValue, double secondValue)
        {
            var parameters = Parameters;
            parameters.SetValue(secondParameter, secondValue);

            Assert.DoesNotThrow(
                () => parameters.SetValue(firstParameter, firstValue), 
                $"Значение не присвоилось свойству {firstParameter}");
        }

        [TestCase(TestName = "SetValue для свойства Cutting")]
        public void SetValue_Cutting()
        {
            Assert.DoesNotThrow(
                () => Parameters.Cutting = true, 
                "Ошибка при попытке присвоения значения");
        }

        [TestCase(TestName = "GetValue из свойства Cutting")]
        public void GetValue_Cutting()
        {
            var parameters = Parameters;

            parameters.Cutting = true;
            var actual = parameters.Cutting;

            Assert.AreEqual(true, actual, 
                "Возвращенное значение не соответствует начальному");
        }
    }
}