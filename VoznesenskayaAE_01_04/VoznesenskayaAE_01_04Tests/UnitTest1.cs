using NUnit.Framework;
using VoznesenskayaAE_01_04;

namespace VoznesenskayaAE_01_04Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void TestPrintOne ()
        {
            Computer computer = new Computer("Intel", 3.2, 2048);
            computer.Calculate();
            Assert.AreEqual(computer.Print(), "Название: Intel Тактовая частота процессора (МГц): 3,2 Объем оперативной памяти (Мб): 2048 Q: 2048,96");

        }

        [Test]
        public void TestPrintTwo ()
        {
            ChildClass computer = new ChildClass("AMD", 3.1, 4096, 500);
            computer.Calculate();
            Assert.AreEqual(computer.Print(), "Название: AMD Тактовая частота процессора (МГц): 3,1 Объем оперативной памяти (Мб): 4096 Q: 4096,93Qp: 4346,93");
        }

        [Test]
        public void TestCalculateOne ()
        {
            Computer computer = new Computer("Intel", 3.8, 8192);
            Assert.AreEqual(computer.Calculate(), 8193.14);
        }

        [Test]
        public void TestCalculateTwo ()
        {
            ChildClass computer = new ChildClass("Intel", 3.2, 2048, 1000);
            Assert.AreEqual(computer.Calculate(), 2548.96);
        }

        [Test]
        public void TestCalculateThird ()
        {
            ChildClass computer = new ChildClass("Test", 4.6, 1000, 1000);
            Assert.AreEqual(computer.Calculate(), 1501.38);
        }
         [Test]
         public void TestCalculateFour ()
        {
            Computer computer = new Computer("Test", 4.3, 10000);
            Assert.AreEqual(computer.Calculate(), 10001.29);
        }
    }
}