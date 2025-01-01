namespace Funzioni
{
    // Classe custom per l'Esercizio 10
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }
}
