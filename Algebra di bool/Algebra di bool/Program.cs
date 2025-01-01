namespace Algebra_di_bool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Boolean algebra");
            Console.WriteLine("======================");

            // Esercizio 1: Utilizzare un if-else per verificare se un numero è pari o dispari.
            Console.WriteLine("\nExercise 1\n");
            ConditionalFunctions.CheckEvenOdd(10);

            // Esercizio 2: Scrivere un programma che utilizza una serie di if-else per categorizzare un'età.
            Console.WriteLine("\nExercise 2:\n");
            ConditionalFunctions.CategorizeAge(5);
            ConditionalFunctions.CategorizeAge(16);
            ConditionalFunctions.CategorizeAge(30);
            ConditionalFunctions.CategorizeAge(70);

            // Esercizio 3: Creare un'espressione logica che combina più condizioni con &&.
            Console.WriteLine("\nExercise 3:\n");
            ConditionalFunctions.CheckConditions(6, 8);  // x > 5 && y < 10
            ConditionalFunctions.CheckConditions(3, 8);  // x > 5 && y < 10 (falsa)
        }
    }
}
