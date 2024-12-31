namespace Variabili
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Variables");
            Console.WriteLine("======================");

            // Esercizio 1: Dichiarare una variabile di tipo int e assegnarle un valore, quindi modificarlo.
            Console.WriteLine("\nExcercise 1:\n");
            int number = 10;
            Console.WriteLine("Initial value of number: " + number);
            number = 20;
            Console.WriteLine("Modified value of number: " + number);

            // Esercizio 2: Creare una variabile di tipo string e concatenarla con un'altra stringa.
            Console.WriteLine("\nExcercise 2:\n");
            string greeting = "Hello";
            string name = "Mario";
            string message = greeting + ", " + name + "!";
            Console.WriteLine(message);
        }
    }
}
