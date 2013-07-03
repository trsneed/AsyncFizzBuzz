using AsyncFizzBuzz.Wpf;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFizzBuzz.Test
{
    [TestFixture]
    public class AsyncTest
    {
        [Test]
        public async void TestTheFizzBuzzer()
        {
            var fizzBuzz0 = await FizzBuzzer.ReturnTheFizzBuzzValue(0, 0);
            var fizzBuzz1 = await FizzBuzzer.ReturnTheFizzBuzzValue(1, 0);
            var fizzBuzz2 = await FizzBuzzer.ReturnTheFizzBuzzValue(2, 0);
            var fizzBuzz3 = await FizzBuzzer.ReturnTheFizzBuzzValue(3, 0);
            var fizzBuzz4 = await FizzBuzzer.ReturnTheFizzBuzzValue(4, 0);
            var fizzBuzz5 = await FizzBuzzer.ReturnTheFizzBuzzValue(5, 0);
            var fizzBuzz6 = await FizzBuzzer.ReturnTheFizzBuzzValue(6, 0);
            var fizzBuzz10 = await FizzBuzzer.ReturnTheFizzBuzzValue(10, 0);
            var fizzBuzz15 = await FizzBuzzer.ReturnTheFizzBuzzValue(15, 0);

            Assert.AreEqual("0", fizzBuzz0);
            Assert.AreEqual("1", fizzBuzz1);
            Assert.AreEqual("2", fizzBuzz2);
            Assert.AreEqual("fizz", fizzBuzz3);
            Assert.AreEqual("4", fizzBuzz4);
            Assert.AreEqual("buzz", fizzBuzz5);
            Assert.AreEqual("fizz", fizzBuzz6);
            Assert.AreEqual("buzz", fizzBuzz10);
            Assert.AreEqual("fizzbuzz", fizzBuzz15);
        }
    }
}
