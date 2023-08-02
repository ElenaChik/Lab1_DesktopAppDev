using NUnit.Framework;
//using NUnitTestingCheck;
using System.Globalization;

namespace TestProjectLab
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // BankCharges Testing
        [Test]
        public void Test1_1GetCheckFeeRate()
        {
            //Lab1_DesktopAppDev l1 = new Lab1_DesktopAppDev();
           

            BankCharges bc = new BankCharges { 100, 10 };

            double var = bc.GetCheckFeeRate();

            Assert.AreEqual(var, 0.1);
   
        }
       

        //  ShippingCharge
        [Test]
        public void Test2_1CalcWeightRate()
        {
            ShippingCharge sc = new ShippingCharge();
            sc.setWeight = 1.2;
            double var = sc.calcWeightRate();

            Assert.AreEqual(var, 1.1);
        }

        [Test]
        public void Test2_2CalcDistanceRate()
        {
            ShippingCharge sc = new ShippingCharge();
            sc.setDistance = 1000;
            double var = sc.calcDistanceRate();


            Assert.AreEqual(var, 2.2);

        }


        // PopulationSize
        [Test]
        public void Test3_1NextDaySize()
        {
            PopulationSize ps = new PopulationSize();
            int dailyIncrease = ps.setDailyIncrease(50);
            double var = ps.nextDaySize(100);


            Assert.AreEqual(var, 150);

        }
    }
}