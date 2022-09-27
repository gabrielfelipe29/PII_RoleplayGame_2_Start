
using NUnit.Framework;
using RoleplayGame;
using System;



namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDwarfDamage()
        {
            int expectedHealthAfterAttack = 100;
            Dwarf gimli = new Dwarf("Gimli");
            Dwarf tomas = new Dwarf("tomas");
            tomas.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            int expectedDamage = tomas.AttackValue;
            int expectedDefense = gimli.DefenseValue;
            if (gimli.DefenseValue < tomas.AttackValue)
            {
                expectedHealthAfterAttack = gimli.Health - tomas.AttackValue + gimli.DefenseValue;
                gimli.ReceiveAttack(tomas.AttackValue);
            }


            Assert.AreEqual(expectedDamage, tomas.AttackValue);
        }
        [Test]
        public void TestDwarfDefense()
        {
            int expectedHealthAfterAttack = 100;
            Dwarf gimli = new Dwarf("Gimli");
            Dwarf tomas = new Dwarf("tomas");
            tomas.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            int expectedDamage = tomas.AttackValue;
            int expectedDefense = gimli.DefenseValue;
            if (gimli.DefenseValue < tomas.AttackValue)
            {
                expectedHealthAfterAttack = gimli.Health - tomas.AttackValue + gimli.DefenseValue;
                gimli.ReceiveAttack(tomas.AttackValue);
            }
            Assert.AreEqual(expectedDefense, gimli.DefenseValue);
        }
        [Test]
        public void TestDwarfAttack()
        {
            int expectedHealthAfterAttack = 100;
            Dwarf gimli = new Dwarf("Gimli");
            Dwarf tomas = new Dwarf("tomas");
            tomas.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            int expectedDamage = tomas.AttackValue;
            int expectedDefense = gimli.DefenseValue;
            if (gimli.DefenseValue < tomas.AttackValue)
            {
                expectedHealthAfterAttack = gimli.Health - tomas.AttackValue + gimli.DefenseValue;
                gimli.ReceiveAttack(tomas.AttackValue);
            }
            Assert.AreEqual(expectedHealthAfterAttack, gimli.Health);
        }

        [Test]
        public void TestWizardWithSpell()
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
        public void TestWizardWithoutSpell()
        {
            Wizard wiz = new Wizard(null);
            SpellsBook book = new SpellsBook();
            Staff staff = new Staff();
            book.Spells = new Spell[] { };
            wiz.Staff = staff;
            wiz.SpellsBook = book;



            string expectedName = null;
            int expectedHealth = wiz.Health;
            int expectedAttackValue = wiz.SpellsBook.AttackValue + wiz.Staff.AttackValue;
            int expectedDefenseValue = wiz.SpellsBook.DefenseValue + wiz.Staff.DefenseValue;

            Assert.AreEqual(expectedName, wiz.Name);
            Assert.AreEqual(expectedHealth, wiz.Health);
            Assert.AreEqual(expectedAttackValue, wiz.AttackValue);
            Assert.AreEqual(expectedDefenseValue, wiz.DefenseValue);

        }


        [Test]
        public void TestWizardDefense()
        {
            int expectedHealthAfterAttack =100;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            Wizard gandalf = new Wizard("Gandalf");
            Dwarf Gimbli = new Dwarf("Gimbli");
            gandalf.SpellsBook = book;
            gandalf.Staff = new Staff();
            Gimbli.Axe = new Axe();
            if (gandalf.DefenseValue < Gimbli.AttackValue)
            {
                expectedHealthAfterAttack = (gandalf.Health + gandalf.DefenseValue)- Gimbli.AttackValue;
                gandalf.ReceiveAttack(Gimbli.AttackValue);
            }
            Assert.AreEqual(expectedHealthAfterAttack, gandalf.Health);
        }
        
        [Test]
        public void TestWizardAttack()
        {
            int expectedvidadelatacado=0;
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            gimli.ReceiveAttack(gandalf.AttackValue);
            if (gimli.DefenseValue < gandalf.AttackValue)
            {
                expectedvidadelatacado = (gimli.Health  + gimli.DefenseValue) - gandalf.AttackValue;
                if (expectedvidadelatacado< 0) 
                {
                    expectedvidadelatacado=0;
                }
                gimli.ReceiveAttack(gandalf.AttackValue);
            }
            Assert.AreEqual(expectedvidadelatacado, gimli.Health);
        }


        [Test]
        public void TestArcherAttack()
        {
            int expectedHealthAfterAttack = 100;
            Archer archer1 = new Archer("archer1");
            Archer archer2 = new Archer("archer2");
            archer1.Helmet = new Helmet();
            archer2.Bow = new Bow();
            int expectedDefense = archer1.DefenseValue;
            int expectedDamage = archer2.AttackValue;
            if (archer1.DefenseValue < archer2.AttackValue)
            {
                expectedHealthAfterAttack = archer1.Health - archer2.AttackValue + archer1.DefenseValue;
                archer1.ReceiveAttack(archer2.AttackValue);
            }
            Assert.AreEqual(expectedHealthAfterAttack, archer1.Health);
        }

        [Test]
        public void TestArcherDefense()
        {
            int expectedHealthAfterAttack = 100;
            Archer archer1 = new Archer("archer1");
            Archer archer2 = new Archer("archer2");
            archer1.Helmet = new Helmet();
            archer2.Bow = new Bow();
            int expectedDefense = archer1.DefenseValue;
            int expectedDamage = archer2.AttackValue;
            if (archer1.DefenseValue < archer2.AttackValue)
            {
                expectedHealthAfterAttack = archer1.Health - archer2.AttackValue + archer1.DefenseValue;
                archer1.ReceiveAttack(archer2.AttackValue);
            }
            Assert.AreEqual(expectedDefense, archer1.DefenseValue);
        }

        [Test]
        public void TestKnightDefense()
        {
            int expectedHealthAfterAttack = 100;
            Knight Arturo = new Knight("Arturo");
            Arturo.Shield = new Shield();
            Arturo.Armor = new Armor();
            Knight Pablo = new Knight("Pablo");
            Pablo.Sword = new Sword();
            int expectedDamage = Pablo.AttackValue;
            int expectedDefense = Arturo.DefenseValue;
            if (Arturo.DefenseValue < Pablo.AttackValue)
            {
                expectedHealthAfterAttack = Arturo.Health - Pablo.AttackValue + Arturo.DefenseValue;
                Arturo.ReceiveAttack(Pablo.AttackValue);
            }
            Assert.AreEqual(expectedHealthAfterAttack, Arturo.Health);
        }
        [Test]
        public void TestKnighAttack()
        {
            int expectedArcherHealth = 80;
            Knight Arturo = new Knight("Arturo");
            Arturo.Sword = new Sword();
            Archer Pablo = new Archer("Pablo");
            Pablo.Helmet = new Helmet();
            int expectedDamage = Pablo.AttackValue;
            int expectedDefense = Arturo.DefenseValue;
            if (Arturo.AttackValue > Pablo.DefenseValue)
            {
                Console.WriteLine("Pablo ha sido atacado");
                Pablo.ReceiveAttack(Arturo.AttackValue);
            }
            Assert.AreEqual(expectedArcherHealth, Pablo.Health);
        }
    }
}