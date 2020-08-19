using System;
using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// 단위 테스트
namespace CaculatorApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd5and23()
        {
            // 5 + 23 = 28
            double a = 5.0;
            double b = 23.0;
            double expected = 28.0; // 기대한 값

            Calculator calc = new Calculator(); // 참조 - 솔루션 Calculator 추가
            double actual = calc.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // 꼭 넣어줘야 함
        public void TestMulple4and5()
        {
            // 4 * 5 = 20
            double a = 4.0;
            double b = 5.0;
            double expected = 20.0; // 기대한 값

            Calculator calc = new Calculator(); // 참조 - 솔루션 Calculator 추가
            double actual = calc.Multiple(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivied10and2()
        {
            // 10 / 2 = 5
            double a = 10.0;
            double b = 2.0;
            double expected = 5.0; // 기대한 값

            Calculator calc = new Calculator(); // 참조 - 솔루션 Calculator 추가
            double actual = calc.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
