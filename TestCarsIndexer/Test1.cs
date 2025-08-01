using prjICETask2;

namespace TestCarsIndexer
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestCarBrand()
        {
            Cars car = new Cars("Toyota", "Corolla", "Red", 2020, 20000.0);
            Assert.AreEqual("Toyota", car[0]);
        }

        [TestMethod]
        public void TestCarModel()
        {
            Cars car = new Cars("Toyota", "Corolla", "Red", 2020, 20000.0);
            Assert.AreEqual("Corolla", car["carModel"]);
        }

        [TestMethod]
        public void TestCarColor()
        {
            Cars car = new Cars("Toyota", "Corolla", "Red", 2020, 20000.0);
            Assert.AreEqual("Red", car[2]);
        }

        [TestMethod]
        public void TestUpdateCarYear()
        {
            Cars car = new Cars("Toyota", "Corolla", "Red", 2020, 20000.0);
            car[3] = 2021;
            Assert.AreEqual(2021, car[3]);
        }

        [TestMethod]
        public void TestUpdateCarPrice()
        {
            Cars car = new Cars("Toyota", "Corolla", "Red", 2020, 20000.0);
            car[4] = 21000.0;
            Assert.AreEqual(21000.0, car[4]);
        }
    }
}
