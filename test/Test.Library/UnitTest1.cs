using NUnit.Framework;


namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDwarf()
        {
            Dwarf gimli = new Dwarf("Gimli");
            Dwarf Tomas = new Dwarf("Tomas");
            int expectedDamage = gimli.Health - Tomas.AttackValue - gimli.DefenseValue;
            gimli.ReceiveAttack(Tomas.AttackValue);
            
            Assert.Pass();
        }
    }
}