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

            // Esercizio 4: Utilizzare un'espressione logica con || per verificare se un numero è compreso in un intervallo.
            Console.WriteLine("\nExercise 4:\n");
            ConditionalFunctions.CheckInRange(50, 1, 100); // Dentro l'intervallo
            ConditionalFunctions.CheckInRange(150, 1, 100); // Fuori dall'intervallo
            ConditionalFunctions.CheckInRange(150, 100, 1); // Scenario di errore

            // Esercizio 5: Scrivere un if-else che utilizza l'operatore ! per invertire una condizione.
            Console.WriteLine("\nExercise 5:\n");
            ConditionalFunctions.InvertCondition(true);
            ConditionalFunctions.InvertCondition(false);

            // Esercizio 6: Dichiarare una variabile booleana e usarla in un'istruzione if.
            Console.WriteLine("\nExercise 6:\n");
            ConditionalFunctions.UseBoolean(true);
            ConditionalFunctions.UseBoolean(false);

            // Esercizio 7: Creare un programma che utilizza if-else nidificati.
            Console.WriteLine("\nExercise 7:\n");
            ConditionalFunctions.NestedIfExample(5); // positivo e < 10
            ConditionalFunctions.NestedIfExample(15); // positivo e >= 10
            ConditionalFunctions.NestedIfExample(-3); // negativo o zero

            // Esercizio 8: Utilizzare un'espressione switch per valutare un valore booleano.
            Console.WriteLine("\nExercise 8:\n");
            ConditionalFunctions.SwitchBoolean(true);
            ConditionalFunctions.SwitchBoolean(false);

            // Esercizio 9: Creare un'istruzione if-else che utilizza un'espressione con operatori di confronto.
            Console.WriteLine("\nExercise 9:\n");
            ConditionalFunctions.CompareNumbers(10, 5);
            ConditionalFunctions.CompareNumbers(5, 10);
            ConditionalFunctions.CompareNumbers(10, 10);

            // Esercizio 10: Utilizzare un operatore ternario per assegnare un valore a una variabile.
            Console.WriteLine("\nExercise 10:\n");
            ConditionalFunctions.TernaryOperator(20);
            ConditionalFunctions.TernaryOperator(15);

            // Esercizio 11: Scrivere una serie di if-else per verificare più condizioni.
            Console.WriteLine("\nExercise 11:\n");
            ConditionalFunctions.CheckMultipleConditions(-5);

            // Esercizio 12: Creare un programma che utilizza un if-else per determinare il maggiore tra due numeri.
            Console.WriteLine("\nExercise 12:\n");
            ConditionalFunctions.FindGreaterNumber(15, 10);
            ConditionalFunctions.FindGreaterNumber(5, 20);

            // Esercizio 13: Utilizzare un'istruzione if per verificare se una stringa è vuota o nulla.
            Console.WriteLine("\nExercise 13:\n");
            ConditionalFunctions.CheckString(""); // vuota
            ConditionalFunctions.CheckString(null); // null
            ConditionalFunctions.CheckString("Hello"); // non vuota

            // Esercizio 14: Creare un programma che utilizza if-else per verificare se un anno è bisestile.
            Console.WriteLine("\nExercise 14:\n");
            ConditionalFunctions.CheckLeapYear(2024); // bisestile
            ConditionalFunctions.CheckLeapYear(2023); // non bisestile

            // Esercizio 15: Scrivere un'espressione logica che verifica se una stringa contiene una sottostringa specifica.
            Console.WriteLine("\nExercise 15:\n");
            ConditionalFunctions.CheckSubstring("Hello world", "world");
            ConditionalFunctions.CheckSubstring("Hello world", "test");

            // Esercizio 16: Utilizzare un if-else per verificare se un array contiene un elemento specifico.
            Console.WriteLine("\nExercise 16:\n");
            ConditionalFunctions.CheckArrayContains(new int[] { 1, 2, 3, 4, 5 }, 3); // contiene 3
            ConditionalFunctions.CheckArrayContains(new int[] { 1, 2, 3, 4, 5 }, 6); // non contiene 6
        }
    }
}
