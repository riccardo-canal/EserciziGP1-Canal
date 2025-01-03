namespace Classi
{
    public class Animale
    {
        public string Name { get; set; }

        public Animale(string name)
        {
            Name = name;
        }

        public void Sound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
