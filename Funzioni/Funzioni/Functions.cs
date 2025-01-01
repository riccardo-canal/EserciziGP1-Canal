namespace Funzioni
{
    internal class Functions
    {
        // Esercizio 1: Dichiarare una funzione che restituisce un valore di tipo int e accetta due parametri.
        internal static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Esercizio 2: Creare una funzione void che stampa un messaggio a console.
        internal static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Esercizio 3: Scrivere una funzione che accetta un parametro string e restituisce la lunghezza della stringa.
        internal static int GetStringLength(string input)
        {
            return input.Length;
        }

        // Esercizio 4: Dichiarare una funzione con un parametro opzionale.
        internal static void GreetUser(string name = "Guest")
        {
            Console.WriteLine($"Hello, {name}");
        }

        // Esercizio 5: Scrivere una funzione che accetta un array come parametro.
        internal static void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }

        // Esercizio 6: Scrivere una funzione che calcola il fattoriale di un numero.
        internal static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        // Esercizio 7: Dichiarare una funzione che restituisce un valore di tipo bool basato su una condizione.
        internal static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Esercizio 8: Creare una funzione che utilizza un'eccezione per gestire input non validi. (try - catch)
        internal static void TryParseNumber(string input)
        {
            try
            {
                int result = int.Parse(input);
                Console.WriteLine($"Parsed number: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
        }

        // Esercizio 9: Dichiarare una funzione che restituisce una lista di numeri.
        internal static List<int> GetNumberList()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }
    }
}
