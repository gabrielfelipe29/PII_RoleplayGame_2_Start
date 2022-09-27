using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");

            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");

            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");

            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");

            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");
            gandalf.ReceiveAttack(gimli.AttackValue);
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");


            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            gandalf.Cure();
            gimli.Cure();




            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");

        }
    }
}
