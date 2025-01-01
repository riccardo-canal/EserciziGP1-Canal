﻿namespace Algebra_di_bool
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

        // Esercizio 3: Creare un'espressione logica che combina più condizioni con &&.
        public static void CheckConditions(int x, int y)
        {
            if (x > 5 && y < 10)
            {
                Console.WriteLine("Both conditions are true.");
            }
            else
            {
                Console.WriteLine("One or both conditions are false.");
            }
        }

        // Esercizio 4: Utilizzare un'espressione logica con || per verificare se un numero è compreso in un intervallo.
        public static void CheckInRange(int number, int lowerBound, int upperBound)
        {
            // Verifica se il minimo è maggiore del massimo
            if (lowerBound > upperBound)
            {
                Console.WriteLine("Error: the lower bound cannot be greater than the upper bound.");
                return; // Uscita anticipata, non continua con il resto del codice
            }

            // Verifica usando solo OR (||) per verificare se il numero è fuori dall'intervallo
            if (number < lowerBound || number > upperBound)
            {
                Console.WriteLine($"{number} is out of the range of {lowerBound} and {upperBound}.");
            }
            else
            {
                Console.WriteLine($"{number} is within the range of {lowerBound} and {upperBound}.");
            }
        }

    }
}
