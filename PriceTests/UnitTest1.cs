using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKata;

namespace PriceTests
{
    [TestClass]
    public class UnitTest1
    {
        //set all the prices to 10 for easier verification of calculations for discounts


        [TestMethod]
        public void Test_TotalPriceA()
        {
            //Multiply quantity by price
            decimal res = PriceCalculations.TotalPriceA(10, 10);
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void Test_TotalPriceB()
        {
            //Multiply quantity by price
            decimal res = PriceCalculations.TotalPriceB(10, 10);
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void Test_TotalPriceBDiscount()
        {
            //Apply discounts on multiples of 3
            decimal res = PriceCalculations.TotalPriceB(10, 3);
            Assert.AreEqual(res, 40);
        }

        [TestMethod]
        public void Test_TotalPriceC()
        {
            //Multiply quantity by price
            decimal res = PriceCalculations.TotalPriceC(10, 10);
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void Test_TotalPriceDEven()
        {
            //Apply discount for even numbers
            decimal res = PriceCalculations.TotalPriceD(10, 2);
            Assert.AreEqual(res, 15);
        }

        [TestMethod]
        public void Test_TotalPriceDOdd()
        {
            //Apply discount for the pair(s) but not the single
            decimal res = PriceCalculations.TotalPriceD(10, 3);
            Assert.AreEqual(res, 25);
        }

        [TestMethod]
        public void Test_TotalPrice()
        {
            decimal res = PriceCalculations.TotalPrice(10, 10, 10, 10);
            Assert.AreEqual(res, 40);
        }
    }
}