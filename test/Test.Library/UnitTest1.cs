
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
            int expectedHealthAfterAttack=100;
           Dwarf gimli = new Dwarf("Gimli");
           Dwarf tomas = new Dwarf("tomas");
            tomas.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            int expectedDamage = tomas.AttackValue;
            int expectedDefense = gimli.DefenseValue;
            if (gimli.DefenseValue < tomas.AttackValue)
            {
                 expectedHealthAfterAttack = gimli.Health-tomas.AttackValue+gimli.DefenseValue;
                 gimli.ReceiveAttack(tomas.AttackValue);
            }
            
            
            Assert.AreEqual(expectedDamage,tomas.AttackValue);
        }
        public void TestDwarfDefense()
        {
            int expectedHealthAfterAttack=100;
           Dwarf gimli = new Dwarf("Gimli");
           Dwarf tomas = new Dwarf("tomas");
            tomas.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            int expectedDamage = tomas.AttackValue;
            int expectedDefense = gimli.DefenseValue;
            if (gimli.DefenseValue < tomas.AttackValue)
            {
                 expectedHealthAfterAttack = gimli.Health-tomas.AttackValue+gimli.DefenseValue;
                 gimli.ReceiveAttack(tomas.AttackValue);
            }
            Assert.AreEqual(expectedDefense,gimli.DefenseValue);
        }
        public void TestDwarfAttack()
        {
            int expectedHealthAfterAttack=100;
           Dwarf gimli = new Dwarf("Gimli");
           Dwarf tomas = new Dwarf("tomas");
            tomas.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            int expectedDamage = tomas.AttackValue;
            int expectedDefense = gimli.DefenseValue;
            if (gimli.DefenseValue < tomas.AttackValue)
            {
                 expectedHealthAfterAttack = gimli.Health-tomas.AttackValue+gimli.DefenseValue;
                 gimli.ReceiveAttack(tomas.AttackValue);
            }     
            Assert.AreEqual(expectedHealthAfterAttack,gimli.Health);
        }
    }
}