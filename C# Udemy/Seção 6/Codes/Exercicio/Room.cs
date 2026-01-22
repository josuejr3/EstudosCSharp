
namespace Exercicio
{
    public class Room{

        public string Name { get; set; }
        public string Email { get; set; }


        public Room(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }


    }
}