
using NUnit.Framework;
using RoleplayGame;
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
            Assert.AreEqual(expectedDamage, gimli.ReceiveAttack(Tomas.AttackValue));
        }

        [Test]
        public void TestWizardOk()
        {
            Wizard wiz = new Wizard("Wiz");
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };
            wiz.Staff = new Staff();
            wiz.SpellsBook = book;

            const string expectedName = "Wiz";
            int expectedHealth = wiz.Health;
            int expectedAttackValue = book.AttackValue + wiz.Staff.AttackValue;
            int expectedDefenseValue = book.DefenseValue + wiz.Staff.DefenseValue;


            Assert.AreEqual(expectedName, wiz.Name);
            Assert.AreEqual(expectedHealth, wiz.Health);
            Assert.AreEqual(expectedAttackValue, wiz.AttackValue);
            Assert.AreEqual(expectedDefenseValue, wiz.DefenseValue);

        }

        [Test]
        public void TestWizardNotOk()
        {
            Wizard wiz = new Wizard(null);
            SpellsBook book = new SpellsBook();
            Staff staff = new Staff();
            book.Spells = new Spell[] { };
            wiz.Staff = staff;
            wiz.SpellsBook = book;


            string expectedName = null;
            int expectedAttackValue = wiz.SpellsBook.AttackValue + wiz.Staff.AttackValue;
            int expectedDefenseValue = wiz.SpellsBook.DefenseValue + wiz.Staff.DefenseValue;

            Assert.AreEqual(expectedName, wiz.Name);
            Assert.AreEqual(expectedAttackValue, wiz.AttackValue);
            Assert.AreEqual(expectedDefenseValue, wiz.DefenseValue);

        }

    }
}