namespace RoleplayGame
{
    public class Archer : ICharacter, IAttackItem, IDefenseItem
    {
        private int health = 100;
        private bool firstTimeInDefense = true;
        private int defenseValue;
        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Bow.AttackValue;
            }


        }

        public int DefenseValue
        {

            get
            {
                if (this.firstTimeInDefense)
                {
                    //solo por primera vez, setea el defenseValue como la suma de los items de defensa
                    this.firstTimeInDefense = false;
                    this.defenseValue = Helmet.DefenseValue;
                    return this.defenseValue;
                }
                else
                {
                    return this.defenseValue;
                }
            }
            private set
            {

                this.defenseValue = value < 0 ? 0 : value;

            }


        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                //si la defensa es menor que el poder, restarle la diferencia a la vida y setear defensevalue en 0
                this.Health -= power - this.DefenseValue;
                this.DefenseValue = 0;
            }
            else
            {
                // si la defensa es mayor al poder, restare a la defensa el poder
                this.DefenseValue -= power;

            }

        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}