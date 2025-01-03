namespace Array_e_Liste
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Array and Lists");
            Console.WriteLine("======================");

            // Esercizio 1: Creare un array di int con 5 elementi e stamparne i valori.
            Console.WriteLine("\nExercise 1\n");
            ArrayAndListsFunctions.PrintIntArray();

            // Esercizio 2: Dichiarare una lista di stringhe e aggiungere elementi dinamicamente.
            Console.WriteLine("\nExercise 2\n");
            ArrayAndListsFunctions.AddElementsToStringList();

            // Esercizio 3: Creare un array bidimensionale e popolarlo con valori. ([,])
            Console.WriteLine("\nExercise 3\n");
            ArrayAndListsFunctions.Populate2DArray();

            // Esercizio 4: Utilizzare un array per calcolare la media dei valori.
            Console.WriteLine("\nExercise 4\n");
            ArrayAndListsFunctions.CalculateAverage();

            // Esercizio 5: Dichiarare una lista di oggetti personalizzati. (classi, enum, struct, ecc)
            Console.WriteLine("\nExercise 5\n");
            ArrayAndListsFunctions.CustomObjectList();

            // Esercizio 6: Creare un array di booleani per rappresentare lo stato di vari interruttori.
            Console.WriteLine("\nExercise 6\n");
            ArrayAndListsFunctions.BooleanArray();

            // Esercizio 7: Dichiarare una lista di numeri e ordinarla.
            Console.WriteLine("\nExercise 7\n");
            ArrayAndListsFunctions.SortNumberList();

            // Esercizio 8: Utilizzare un array per contare la frequenza di un valore.
            Console.WriteLine("\nExercise 8\n");
            ArrayAndListsFunctions.CountFrequency();

            // Esercizio 9: Creare una lista di stringhe e rimuovere elementi specifici.
            Console.WriteLine("\nExercise 9\n");
            ArrayAndListsFunctions.RemoveElementsFromList();

            // Esercizio 10: Dichiarare un array e inizializzarlo con valori predefiniti.
            Console.WriteLine("\nExercise 10\n");
            ArrayAndListsFunctions.PredefinedArray();

            // Esercizio 11: Creare una lista che accetta solo valori univoci.
            Console.WriteLine("\nExercise 11\n");
            ArrayAndListsFunctions.UniqueValueList();

            // Esercizio 12: Utilizzare un array per rappresentare una matrice di 3x3.
            Console.WriteLine("\nExercise 12\n");
            ArrayAndListsFunctions.ArrayMatrix3x3();

            // Esercizio 13: Dichiarare una lista e cercare un elemento al suo interno.
            Console.WriteLine("\nExercise 13\n");
            ArrayAndListsFunctions.SearchElementInList();

            // Esercizio 14: Creare un array di oggetti e iterare sui valori.
            Console.WriteLine("\nExercise 14\n");
            ArrayAndListsFunctions.ArrayOfObjects();

            // Esercizio 15: Utilizzare una lista per memorizzare i punteggi di un gioco.
            Console.WriteLine("\nExercise 15\n");
            ArrayAndListsFunctions.GameScoresList();

            // Esercizio 16: Dichiarare un array di char per rappresentare una parola.
            Console.WriteLine("\nExercise 16\n");
            ArrayAndListsFunctions.CharArrayWord();

            // Esercizio 17: Creare una lista che accetta solo valori di tipo float.
            Console.WriteLine("\nExercise 17\n");
            ArrayAndListsFunctions.FloatList();

            // Esercizio 18: Utilizzare un array per memorizzare i giorni della settimana.
            Console.WriteLine("\nExercise 18\n");
            ArrayAndListsFunctions.DaysOfWeekArray();

            // Esercizio 19: Dichiarare una lista e modificarne gli elementi in base alla loro posizione.
            Console.WriteLine("\nExercise 19\n");
            ArrayAndListsFunctions.ModifyListElements();

            // Esercizio 20: Creare un array di stringhe e concatenare tutti i valori in un'unica stringa.
            Console.WriteLine("\nExercise 20\n");
            ArrayAndListsFunctions.ConcatenateArrayStrings();

            // Esercizio 21: Utilizzare una lista per memorizzare dati inseriti dall'utente.
            Console.WriteLine("\nExercise 21\n");
            ArrayAndListsFunctions.UserInputList();

            // Esercizio 22: Dichiarare un array di numeri casuali.
            Console.WriteLine("\nExercise 22\n");
            ArrayAndListsFunctions.RandomNumberArray();

            // Esercizio 23: Creare una lista che accetta solo valori superiori a 10.
            Console.WriteLine("\nExercise 23\n");
            ArrayAndListsFunctions.FilterValuesAbove10();

            // Esercizio 24: Utilizzare un array per rappresentare una tabella di moltiplicazione.
            Console.WriteLine("\nExercise 24\n");
            ArrayAndListsFunctions.MultiplicationTableArray();

            // Esercizio 25: Dichiarare una lista e convertirla in array.
            Console.WriteLine("\nExercise 25\n");
            ArrayAndListsFunctions.ConvertListToArray();
        }
    }
}
