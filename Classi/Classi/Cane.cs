namespace Classi
{
    public class Cane : Animale
    {
        public Cane(string name) : base(name) { }

        // Esercizio 4: Creare una classe che eredita da un'altra.
        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
