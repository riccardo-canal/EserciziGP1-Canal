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

        // Esercizio 5: Scrivere un if-else che utilizza l'operatore ! per invertire una condizione.
        public static void InvertCondition(bool condition)
        {
            if (!condition)
            {
                Console.WriteLine("Condition is false.");
            }
            else
            {
                Console.WriteLine("Condition is true.");
            }
        }

        // Esercizio 6: Dichiarare una variabile booleana e usarla in un'istruzione if.
        public static void UseBoolean(bool isActive)
        {
            if (isActive)
            {
                Console.WriteLine("The system is active.");
            }
            else
            {
                Console.WriteLine("The system is inactive.");
            }
        }

        // Esercizio 7: Creare un programma che utilizza if-else nidificati.
        public static void NestedIfExample(int number)
        {
            if (number > 0)
            {
                if (number < 10)
                {
                    Console.WriteLine("Number is positive and less than 10.");
                }
                else
                {
                    Console.WriteLine("Number is positive and greater than or equal to 10.");
                }
            }
            else
            {
                Console.WriteLine("Number is zero or negative.");
            }
        }

        // Esercizio 8: Utilizzare un'espressione switch per valutare un valore booleano.
        public static void SwitchBoolean(bool isActive)
        {
            switch (isActive)
            {
                case true:
                    Console.WriteLine("The system is active.");
                    break;
                case false:
                    Console.WriteLine("The system is inactive.");
                    break;
            }
        }

        // Esercizio 9: Creare un'istruzione if-else che utilizza un'espressione con operatori di confronto.
        public static void CompareNumbers(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}.");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} is less than {b}.");
            }
            else
            {
                Console.WriteLine($"{a} is equal to {b}.");
            }
        }
    }
}
