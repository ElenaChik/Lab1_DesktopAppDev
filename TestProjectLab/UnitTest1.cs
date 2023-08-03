using Lab1_DesktopAppDev;

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
            BankCharges bc = new BankCharges(100, 10);

            double var = bc.getCheckFeeRate();

            Assert.That(var, Is.EqualTo(0.1));   
        }


        // ShippingCharge
        [Test]
        public void Test2_1CalcWeightRate()
        {
            ShippingCharge sc = new ShippingCharge();
            sc.setWeight(1.2);
            double var = sc.calcWeightRate();

            Assert.That(var, Is.EqualTo(1.1));
        }

        [Test]
        public void Test2_2CalcDistanceRate()
        {
            ShippingCharge sc = new ShippingCharge();
            sc.setDistance(1001);
            double var = sc.calcDistanceRate();

            Assert.That(var, Is.EqualTo(3));

        }


        // PopulationSize
        [Test]
        public void Test3_1NextDaySize()
        {
            PopulationSize ps = new PopulationSize();
            ps.setDailyIncrease(50);
            double var = ps.nextDaySize(100);


            Assert.That(var, Is.EqualTo(150));

        }
    }
}