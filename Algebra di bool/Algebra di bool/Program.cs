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

            // Esercizio 17: Creare una funzione che utilizza if-else per determinare se un numero è positivo, negativo o zero.
            Console.WriteLine("\nExercise 17:\n");
            ConditionalFunctions.CheckNumber(5); // positivo
            ConditionalFunctions.CheckNumber(-3); // negativo
            ConditionalFunctions.CheckNumber(0); // zero

            // Esercizio 18: Creare un programma che utilizza un switch per determinare il giorno della settimana.
            Console.WriteLine("\nExercise 18:\n");
            ConditionalFunctions.GetDayOfWeek(1); // Lunedì
            ConditionalFunctions.GetDayOfWeek(5); // Venerdì
            ConditionalFunctions.GetDayOfWeek(8); // Giorno non valido

            // Esercizio 19: Utilizzare un'istruzione if per verificare se un numero è divisibile per 3 e 5.
            Console.WriteLine("\nExercise 19:\n");
            ConditionalFunctions.CheckDivisibility(15); // Divisibile per entrambi
            ConditionalFunctions.CheckDivisibility(9); // Non divisibile per entrambi

            // Esercizio 20: Scrivere un'istruzione if per verificare se un valore booleano è true.
            Console.WriteLine("\nExercise 20:\n");
            ConditionalFunctions.CheckBoolean(true);
            ConditionalFunctions.CheckBoolean(false);

            // Esercizio 21: Utilizzare un switch per valutare una variabile stringa.
            Console.WriteLine("\nExercise 21:\n");
            ConditionalFunctions.SwitchString("monday");
            ConditionalFunctions.SwitchString("friday");
            ConditionalFunctions.SwitchString("sunday");

            // Esercizio 22: Creare un programma che utilizza un if per verificare se un array è vuoto.
            Console.WriteLine("\nExercise 22:\n");
            ConditionalFunctions.CheckIfArrayIsEmpty([1, 2, 3]);
            ConditionalFunctions.CheckIfArrayIsEmpty([]);

            // Esercizio 23: Utilizzare un if per verificare se un valore è un numero primo.
            Console.WriteLine("\nExercise 23:\n");
            ConditionalFunctions.CheckPrimeNumber(7); // Numero primo
            ConditionalFunctions.CheckPrimeNumber(4); // Non primo
            ConditionalFunctions.CheckPrimeNumber(1); // Non primo

            // Esercizio 24: Scrivere un programma che utilizza un'istruzione if-else per verificare se una parola è palindroma.
            Console.WriteLine("\nExercise 24:\n");
            ConditionalFunctions.CheckPalindrome("racecar"); // Palindromo
            ConditionalFunctions.CheckPalindrome("hello"); // Non palindromo
        }
    }
}
