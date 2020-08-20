using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul3Oblig1;

namespace Modul3Oblig1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            
            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [TestMethod]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [TestMethod]
        public void TestSomeFields()
        {
            var p = new Person
            {
                Id = 99,
                LastName = "SirCatsalot",
                BirthYear = 1200,
                Mother = new Person() { Id = 43, FirstName = "Miss Mjau" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "SirCatsalot (Id=99) Født: 1200 Mor: Miss Mjau (Id=43)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}
