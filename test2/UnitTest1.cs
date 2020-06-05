using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            unitTest_2.Person person = new unitTest_2.Person("Иван", "Петров", 25);
            unitTest_2.Person person2 = new unitTest_2.Person();
            unitTest_2.Person person3;



            //act

            string json = unitTest_2.Person.ToJson(person);
            person3 = unitTest_2.Person.FromJSON(json);





            //assert

            Assert.AreEqual(false, person2.Equals(person));
        }
    }
}
