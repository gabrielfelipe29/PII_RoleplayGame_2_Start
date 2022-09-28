namespace RoleplayGame
{
    //Interfaz que define el tipo personaje/Character
    public interface ICharacter
    {
        //Nombre del personaje
        public string Name { get; set; }
        //Vida del personaje
        public int Health { get; }
        //metodo para curar al personaje
        public void Cure();
        //metodo para atacar de los personajes (en realidad es para recibir un ataque, todos deben tener este método para poder ser atacados)
        public void ReceiveAttack(int power);

    }
}