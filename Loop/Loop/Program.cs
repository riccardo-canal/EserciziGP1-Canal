namespace Loop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Loop");
            Console.WriteLine("======================");

            // Esercizio 1: Scrivere un ciclo for che stampa numeri da 1 a 10.
            Console.WriteLine("\nExercise 1\n");
            LoopFunctions.PrintNumbers();

            // Esercizio 2: Creare un ciclo while che continua finché un valore è minore di 100.
            Console.WriteLine("\nExercise 2\n");
            LoopFunctions.WhileLessThan100();

            // Esercizio 3: Utilizzare un ciclo do-while per chiedere all'utente di inserire un valore valido.
            Console.WriteLine("\nExercise 3\n");
            LoopFunctions.DoWhileGetValidInput();

            // Esercizio 4: Scrivere un ciclo for che calcola la somma di un array.
            Console.WriteLine("\nExercise 4\n");
            LoopFunctions.SumArray();

            // Esercizio 5: Utilizzare un ciclo foreach per iterare attraverso una lista di stringhe.
            Console.WriteLine("\nExercise 5\n");
            LoopFunctions.IterateStringList();

            // Esercizio 6: Creare un ciclo for che calcola il fattoriale di un numero.
            Console.WriteLine("\nExercise 6\n");
            LoopFunctions.CalculateFactorial();

            // Esercizio 7: Scrivere un ciclo while che verifica se un numero è primo.
            Console.WriteLine("\nExercise 7\n");
            LoopFunctions.CheckIfPrime();

            // Esercizio 8: Utilizzare un ciclo do-while per stampare i numeri pari fino a un massimo.
            Console.WriteLine("\nExercise 8\n");
            LoopFunctions.PrintEvenNumbers();

            // Esercizio 9: Scrivere un ciclo for che stampa i numeri in ordine inverso.
            Console.WriteLine("\nExercise 9\n");
            LoopFunctions.PrintReverseOrder();

            // Esercizio 10: Creare un ciclo while che calcola il prodotto dei numeri fino a un valore specifico.
            Console.WriteLine("\nExercise 10\n");
            LoopFunctions.CalculateProduct();

            // Esercizio 11: Utilizzare un ciclo foreach per modificare i valori in una lista.
            Console.WriteLine("\nExercise 11\n");
            LoopFunctions.ModifyListValues();

            // Esercizio 12: Scrivere un ciclo do-while che calcola il totale di un array.
            Console.WriteLine("\nExercise 12\n");
            LoopFunctions.CalculateArrayTotal();

            // Esercizio 13: Creare un ciclo for che utilizza un'istruzione break.
            Console.WriteLine("\nExercise 13\n");
            LoopFunctions.BreakInForLoop();

            // Esercizio 14: Utilizzare un ciclo while che termina con un'istruzione continue.
            Console.WriteLine("\nExercise 14\n");
            LoopFunctions.ContinueInWhileLoop();

            // Esercizio 15: Scrivere un ciclo for che utilizza una variabile dichiarata all'esterno del ciclo.
            Console.WriteLine("\nExercise 15\n");
            LoopFunctions.ForLoopWithExternalVariable();

            // Esercizio 16: Creare un ciclo foreach che stampa gli indici e i valori di un array.
            Console.WriteLine("\nExercise 16\n");
            LoopFunctions.PrintIndexAndValues();

            // Esercizio 17: Utilizzare un ciclo do-while che verifica un valore booleano prima di continuare.
            Console.WriteLine("\nExercise 17\n");
            LoopFunctions.DoWhileWithBooleanCondition();

            // Esercizio 18: Scrivere un ciclo for che calcola la somma dei numeri dispari.
            Console.WriteLine("\nExercise 18\n");
            LoopFunctions.SumOddNumbers();

            // Esercizio 19: Creare un ciclo while che termina quando un valore raggiunge una soglia.
            Console.WriteLine("\nExercise 19\n");
            LoopFunctions.WhileUntilThreshold();

            // Esercizio 20: Utilizzare un ciclo foreach per calcolare la lunghezza totale di tutte le stringhe in una lista.
            Console.WriteLine("\nExercise 20\n");
            LoopFunctions.TotalStringLength();

            // Esercizio 21: Scrivere un ciclo do-while che stampa un menu fino a quando l'utente sceglie di uscire.
            Console.WriteLine("\nExercise 21\n");
            LoopFunctions.MenuWithDoWhile();

            // Esercizio 22: Creare un ciclo for che utilizza una condizione complessa.
            Console.WriteLine("\nExercise 22\n");
            LoopFunctions.ComplexConditionInForLoop();

            // Esercizio 23: Utilizzare un ciclo while per cercare un valore specifico in un array.
            Console.WriteLine("\nExercise 23\n");
            LoopFunctions.SearchInArray();

            // Esercizio 24: Scrivere un ciclo for che calcola la media di un array.
            Console.WriteLine("\nExercise 24\n");
            LoopFunctions.CalculateArrayAverage();

            // Esercizio 25: Creare un ciclo foreach che copia valori da un array a un altro.
            Console.WriteLine("\nExercise 25\n");
            LoopFunctions.CopyArrayValues();
        }
    }
}
