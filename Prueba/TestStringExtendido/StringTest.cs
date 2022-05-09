using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;
using System;

namespace TestStringExtendido
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor3_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 3;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();
            
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor5_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 5;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoEsDivisiblePor3y5_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = numero.FizzBuzz();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuandoNoEsDivisiblePor3o5_DeberiaRetornarElNumero()
        {
            //Arrange
            int numero = 2;
            string expected = "2";

            //Act
            string actual = numero.FizzBuzz();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
