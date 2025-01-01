namespace Algebra_di_bool
{
    internal class ConditionalFunctions
    {
        // Esercizio 1: Utilizzare un if-else per verificare se un numero è pari o dispari.
        internal static void CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

        // Esercizio 2: Scrivere un programma che utilizza una serie di if-else per categorizzare un'età.
        internal static void CategorizeAge(int age)
        {
            if (age >= 0 && age <= 12)
            {
                Console.WriteLine($"Age {age}: Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine($"Age {age}: Teenager");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine($"Age {age}: Adult");
            }
            else
            {
                Console.WriteLine($"Age {age}: Senior");
            }
        }
    }
}
