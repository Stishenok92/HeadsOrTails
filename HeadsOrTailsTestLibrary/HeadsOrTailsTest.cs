using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static HeadsOrTailsLibrary.HeadsOrTails;

namespace HeadsOrTailsTestLibrary
{
    [TestClass]
    public class HeadsOrTailsTest
    {
        [TestMethod]
        public void ValidationNumberThrow_7_ReturnedTrue()
        {
            //arrange
            int numberThrow = 7;
            bool expected = true;

            //act
            bool actual = ValidationNumberThrow(numberThrow);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidationNumberThrow_Minus5_ReturnedTrue()
        {
            //arrange
            int numberThrow = -5;
            bool expected = false;

            //act
            bool actual = ValidationNumberThrow(numberThrow);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDropOneSide_7_ReturnedFrom0To7()
        {
            //arrange
            int numberThrow = 7;
            int minExpected = 0;
            int maxExpected = 7;

            //act
            int actual = CalculateDropOneSide(numberThrow);

            //assert
            if (actual < minExpected || actual > maxExpected)
            {
                Fail();
            }
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void CalculateDropOneSide_Minus5_ValidationException()
        {
            //arrange
            int numberThrow = -5;
            
            //act + assert
            CalculateDropOneSide(numberThrow);
        }
        
        
    }
}