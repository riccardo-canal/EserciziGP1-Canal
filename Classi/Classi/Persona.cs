namespace Classi
{
    public class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Lavoro Job { get; set; }

        public Persona(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Persona(string name, Lavoro job)
        {
            Name = name;
            Job = job;
        }

        // Esercizio 5: Aggiungere diversi metodi public all'interno della classe 'Persona'
        public void Greet()
        {
            Console.WriteLine($"Hello, I am {Name} and I am {Age} years old.");
        }

        public void Birthday()
        {
            Age++;
            Console.WriteLine($"Happy Birthday! Now you are {Age} years old.");
        }
    }
}
