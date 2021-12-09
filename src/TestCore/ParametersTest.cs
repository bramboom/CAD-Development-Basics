using NUnit.Framework;

namespace TestCore
{
    public class Tests
    {
       
using System;
using Core;
using NUnit.Framework;

namespace TestCore
	{
		/// <summary>
		/// ����� ����� <see cref="Core.DetailParameters"/>
		/// </summary>
		[TestFixture]
		public class TestDetailParameters
		{
			/// <summary>
			/// ���������� ����� ��������� ������ <see cref="Core.DetailParameters"/>
			/// </summary>
			private DetailParameters DetailParameters => new DetailParameters();

			//TODO: ������ ������������ ������ ����� TestCase-s
			[TestCase(TestName = "�������� ����������� �������� � �������� InnerRingDiameter")]
			public void TestInnerRingDiameter_CorrectGetInnerRingDiameter()
			{
				var detailParameters = DetailParameters;

				var expected = 4.0;

				detailParameters.InnerRingDiameter = expected;

				var actual = detailParameters.InnerRingDiameter;

				Assert.AreEqual(expected, actual, "������������ �������� �� ����� ����������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� InnerRingDiameter")]
			public void TestInnerRingDiameter_CorrectSet()
			{
				var detailParameters = DetailParameters;

				var value = 4.0;

				Assert.DoesNotThrow(() => detailParameters.InnerRingDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(1.0, TestName = "�������� ���������� �������� ������ ������������ �������� InnerRingDiameter")]
			[TestCase(100.0, TestName = "�������� ���������� �������� ������ ������������� �������� InnerRingDiameter")]
			public void TestInnerRingDiameter_ThrowExceptionSet(double value)
			{
				var detailParameters = DetailParameters;

				Assert.Throws<ArgumentException>(() => detailParameters.InnerRingDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� InnerRingDiameter" +
								 " ��� ������������� �������� OuterRingDiameter")]
			public void TestInnerRingDiameter_CorrectSetWithOuterRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 4.0;
				var outerRingDiameterValue = 5.0;
				detailParameters.OuterRingDiameter = outerRingDiameterValue;

				Assert.DoesNotThrow(() => detailParameters.InnerRingDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ���������� �������� �������� InnerRingDiameter �������� ��� ������ ��," +
								 " ��� ��� ������������� �������� OuterRingDiameter")]
			public void TestInnerRingDiameter_ThrowExceptionSetWithOuterRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 5.0;
				var outerRingDiameterValue = 5.0;
				detailParameters.OuterRingDiameter = outerRingDiameterValue;

				Assert.Throws<ArgumentException>(() => detailParameters.InnerRingDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� �������� � �������� OuterRingDiameter")]
			public void TestOuterRingDiameter_CorrectGet()
			{
				var detailParameters = DetailParameters;

				var expected = 5.0;

				detailParameters.OuterRingDiameter = expected;

                var actual = detailParameters.OuterRingDiameter;

				Assert.AreEqual(expected, actual, "������������ �������� �� ����� ����������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� OuterRingDiameter")]
			public void TestOuterRingDiameter_CorrectSet()
			{
				var detailParameters = DetailParameters;

				var value = 5.0;

				Assert.DoesNotThrow(() => detailParameters.OuterRingDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(1.0, TestName = "�������� ���������� �������� ������ ������������ �������� OuterRingDiameter")]
			[TestCase(100.0, TestName = "�������� ���������� �������� ������ ������������� �������� OuterRingDiameter")]
			public void TestOuterRingDiameter_ThrowExceptionSet(double value)
			{
				var detailParameters = DetailParameters;

				Assert.Throws<ArgumentException>(() => detailParameters.OuterRingDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� OuterRingDiameter" +
								 " ��� ������������� �������� InnerRingDiameter")]
			public void TestOuterRingDiameter_CorrectSetWithInnerRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 6.0;
				var innerRingDiameterValue = 5.0;
				detailParameters.InnerRingDiameter = innerRingDiameterValue;

				Assert.DoesNotThrow(() => detailParameters.OuterRingDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ���������� �������� �������� OuterRingDiameter" +
								 " ������ ��� ������ ��, ��� ��� ������������� �������� InnerRingDiameter")]
			public void TestOuterRingDiameter_ThrowExceptionSetWithInnerRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 5.0;
				var innerRingDiameterValue = 5.0;
				detailParameters.InnerRingDiameter = innerRingDiameterValue;

				Assert.Throws<ArgumentException>(() => detailParameters.OuterRingDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� �������� � �������� ThreadDiameter")]
			public void TestThreadDiameter_CorrectGet()
			{
				var detailParameters = DetailParameters;

				var expected = 4.0;

				detailParameters.ThreadDiameter = expected;

				var actual = detailParameters.ThreadDiameter;

				Assert.AreEqual(expected, actual, "������������ �������� �� ����� ����������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� ThreadDiameter")]
			public void TestThreadDiameter_CorrectSet()
			{
				var detailParameters = DetailParameters;

				var value = 4.0;

				Assert.DoesNotThrow(() => detailParameters.ThreadDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(1.0, TestName = "�������� ���������� �������� ������ ������������ �������� ThreadDiameter")]
			[TestCase(100.0, TestName = "�������� ���������� �������� ������ ������������� �������� ThreadDiameter")]
			public void TestThreadDiameter_ThrowExceptionSet(double value)
			{
				var detailParameters = DetailParameters;

				Assert.Throws<ArgumentException>(() => detailParameters.ThreadDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� OuterRingDiameter" +
								 " ��� ������������� �������� InnerRingDiameter")]
			public void TestThreadDiameter_CorrectSetWithInnerRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 5.9;
				var innerRingDiameterValue = 6.0;
				detailParameters.InnerRingDiameter = innerRingDiameterValue;

				Assert.DoesNotThrow(() => detailParameters.ThreadDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ���������� �������� �������� ThreadDiameter �������� " +
								 "��� ������ ��, ��� ��� ������������� �������� InnerRingDiameter")]
			public void TestThreadDiameter_ThrowExceptionSetWithInnerRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 4.0;
				var innerRingDiameterValue = 4.0;
				detailParameters.InnerRingDiameter = innerRingDiameterValue;

				Assert.Throws<ArgumentException>(() => detailParameters.ThreadDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� �������� � �������� BoltHeadHeight")]
			public void TestBoltHeadHeight_CorrectGet()
			{
				var detailParameters = DetailParameters;

				var expected = 2.0;

				detailParameters.BoltHeadHeight = expected;

				var actual = detailParameters.BoltHeadHeight;

				Assert.AreEqual(expected, actual, "������������ �������� �� ����� ����������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� BoltHeadHeight")]
			public void TestBoltHeadHeight_CorrectSet()
			{
				var detailParameters = DetailParameters;

				var value = 2.0;

				Assert.DoesNotThrow(() => detailParameters.BoltHeadHeight = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(1.0, TestName = "�������� ���������� �������� ������ ������������ �������� BoltHeadHeight")]
			[TestCase(100.0, TestName = "�������� ���������� �������� ������ ������������� �������� BoltHeadHeight")]
			public void TestBoltHeadHeight_ThrowExceptionSet(double value)
			{
				var detailParameters = DetailParameters;

				Assert.Throws<ArgumentException>(() => detailParameters.BoltHeadHeight = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� �������� � �������� BoltHeight")]
			public void TestBoltHeight_CorrectGet()
			{
				var detailParameters = DetailParameters;

				var expected = 10.0;

				detailParameters.BoltBodyHeight = expected;

				var actual = detailParameters.BoltBodyHeight;

				Assert.AreEqual(expected, actual, "������������ �������� �� ����� ����������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� BoltHeight")]
			public void TestBoltHeight_CorrectSet()
			{
				var detailParameters = DetailParameters;

				var value = 10.0;

				Assert.DoesNotThrow(() => detailParameters.BoltBodyHeight = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(1.0, TestName = "�������� ���������� �������� ������ ������������ �������� BoltHeight")]
			[TestCase(100.0, TestName = "�������� ���������� �������� ������ ������������� �������� BoltHeight")]
			public void TestBoltHeight_ThrowExceptionSet(double value)
			{
				var detailParameters = DetailParameters;

				Assert.Throws<ArgumentException>(() => detailParameters.BoltBodyHeight = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� �������� � �������� HeadDiameter")]
			public void TestHeadDiameter_CorrectGet()
			{
				var detailParameters = DetailParameters;

				var expected = 10.0;

				detailParameters.HeadDiameter = expected;

				var actual = detailParameters.HeadDiameter;

				Assert.AreEqual(expected, actual, "������������ �������� �� ����� ����������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� HeadDiameter")]
			public void TestHeadDiameter_CorrectSet()
			{
				var detailParameters = DetailParameters;

				var value = 10.0;

				Assert.DoesNotThrow(() => detailParameters.HeadDiameter = value,
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(1.0, TestName = "�������� ���������� �������� ������ ������������ �������� HeadDiameter")]
			[TestCase(100.0, TestName = "�������� ���������� �������� ������ ������������� �������� HeadDiameter")]
			public void TestHeadDiameter_ThrowExceptionSet(double value)
			{
				var detailParameters = DetailParameters;

				Assert.Throws<ArgumentException>(() => detailParameters.HeadDiameter = value,
					"����������� �������� �� �������� � ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� ����������� ��������")]
			public void TestSetMinValue_CorrectSet()
			{
				var detailParameters = DetailParameters;

				Assert.DoesNotThrow(() => detailParameters.SetMinValue(),
					"�� ������� ��������� ���������� ����������� ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� BoltBodyHeight ����� ����� SetValue")]
			public void TestSetValue_CorrectSetBoltBodyHeight()
			{
				var detailParameters = DetailParameters;

				var value = 10.0;

				Assert.DoesNotThrow(() => detailParameters.SetValue(Parameters.BoltBodyHeight, value),
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� HeadDiameter ����� ����� SetValue")]
			public void TestSetValue_CorrectSetHeadDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 10.0;

				Assert.DoesNotThrow(() => detailParameters.SetValue(Parameters.HeadDiameter, value),
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� BoltHeadHeight ����� ����� SetValue")]
			public void TestSetValue_CorrectSetBoltHeadHeight()
			{
				var detailParameters = DetailParameters;

				var value = 2.0;

				Assert.DoesNotThrow(() => detailParameters.SetValue(Parameters.BoltHeadHeight, value),
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� InnerRingDiameter ����� ����� SetValue")]
			public void TestSetValue_CorrectSetInnerRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 4.0;

				Assert.DoesNotThrow(() => detailParameters.SetValue(Parameters.InnerRingDiameter, value),
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� OuterRingDiameter ����� ����� SetValue")]
			public void TestSetValue_CorrectSetOuterRingDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 5.0;

				Assert.DoesNotThrow(() => detailParameters.SetValue(Parameters.OuterRingDiameter, value),
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ����������� ���������� �������� �������� ThreadDiameter ����� ����� SetValue")]
			public void TestSetValue_CorrectSetThreadDiameter()
			{
				var detailParameters = DetailParameters;

				var value = 3.0;

				Assert.DoesNotThrow(() => detailParameters.SetValue(Parameters.ThreadDiameter, value),
					"�� ������� ��������� ���������� ��������");
			}

			[TestCase(TestName = "�������� ���������� �������� ������������ �������� ������������")]
			public void TestSetValue_UnkownEnumerate()
			{
				var detailParameters = DetailParameters;

				var value = 3.0;

				Assert.Throws<ArgumentOutOfRangeException>(() => detailParameters.SetValue((Parameters)15, value),
					"������� ����� ������� ������������!");
			}

			[TestCase(TestName = "�������� ������ DependencyParameterChanged")]
			public void TestDependencyParameterChanged_InvokeCorrect()
			{
				var detailParameters = DetailParameters;

				var flag = false;

				detailParameters.DependencyParameterChanged += (sender, args) => flag = true;

				detailParameters.SetValue(Parameters.OuterRingDiameter, 5.0);

				Assert.IsTrue(flag, $"�� ��������� ������� {nameof(detailParameters.DependencyParameterChanged)}");
			}

			[TestCase(TestName = "�������� ������ DefaultParameter")]
			public void TestDefaultParameter_InvokeCorrect()
			{
				var detailParameters = DetailParameters;

				var flag = false;

				detailParameters.DefaultParameter += (sender, args) => flag = true;

				detailParameters.SetMinValue();

				Assert.IsTrue(flag, $"�� ��������� ������� {nameof(detailParameters.DefaultParameter)}");
			}
		}
	}
}
}