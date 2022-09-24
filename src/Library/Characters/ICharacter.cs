namespace RoleplayGame
{
    public interface ICharacter
    {
        public string Name { get; set; }

        public int Health { get; }
        
        public void Cure();

        public void ReceiveAttack(int power);

    }
}