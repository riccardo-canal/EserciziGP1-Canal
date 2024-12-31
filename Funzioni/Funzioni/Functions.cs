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
    }
}
