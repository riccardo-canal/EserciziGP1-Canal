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

            // Esercizio 2: Creare una funzione void che stampa un messaggio a console.
            Console.WriteLine("\nExercise 2:\n");
            Functions.PrintMessage("Hello, world!");

            // Esercizio 3: Scrivere una funzione che accetta un parametro string e restituisce la lunghezza della stringa.
            Console.WriteLine("\nExercise 3:\n");
            string myString = "Hello!";
            int stringLength = Functions.GetStringLength(myString);
            Console.WriteLine($"String length: {stringLength}");

            // Esercizio 4: Dichiarare una funzione con un parametro opzionale.
            Console.WriteLine("\nExercise 4:\n");
            Functions.GreetUser("Alice");
            Functions.GreetUser(); // Chiama la funzione con il parametro predefinito

            // Esercizio 5: Scrivere una funzione che accetta un array come parametro.
            Console.WriteLine("\nExercise 5:\n");
            int[] numbers = { 1, 2, 3, 4, 5 };
            Functions.PrintArray(numbers);
        }
    }
}
