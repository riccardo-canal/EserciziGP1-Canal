namespace Funzioni
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Functions");
            Console.WriteLine("======================");

            // Esercizio 1: Dichiarare una funzione che restituisce un valore di tipo int e accetta due parametri.
            Console.WriteLine("\nExercise 1:\n");
            int sumResult = Functions.AddNumbers(10, 5);
            Console.WriteLine($"Sum: {sumResult}");
        }
    }
}
