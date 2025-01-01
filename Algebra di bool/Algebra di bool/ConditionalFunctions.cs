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

        // Esercizio 10: Utilizzare un operatore ternario per assegnare un valore a una variabile.
        public static void TernaryOperator(int age)
        {
            string result = (age >= 18) ? "Adult" : "Minor";
            Console.WriteLine(result);
        }

        // Esercizio 11: Scrivere una serie di if-else per verificare più condizioni.
        public static void CheckMultipleConditions(int number)
        {
            if (number > 100)
            {
                Console.WriteLine("The number is greater than 100.");
            }
            else
            {
                Console.WriteLine("The number is not greater than 100.");
            }

            if (number >= 50 && number <= 100)
            {
                Console.WriteLine("The number is between 50 and 100.");
            }
            else
            {
                Console.WriteLine("The number is not between 50 and 100.");
            }

            if (number < 50 && number >= 0)
            {
                Console.WriteLine("The number is between 0 and 50.");
            }
            else
            {
                Console.WriteLine("The number is not between 0 and 50.");
            }

            if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is not negative.");
            }
        }
        // Esercizio 12: Creare un programma che utilizza un if-else per determinare il maggiore tra due numeri.
        public static void FindGreaterNumber(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}.");
            }
            else
            {
                Console.WriteLine($"{num2} is greater than {num1}.");
            }
        }

        // Esercizio 13: Utilizzare un'istruzione if per verificare se una stringa è vuota o nulla.
        public static void CheckString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is empty or null.");
            }
            else
            {
                Console.WriteLine("String has value.");
            }
        }

        // Esercizio 14: Creare un programma che utilizza if-else per verificare se un anno è bisestile.
        public static void CheckLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }

        // Esercizio 15: Scrivere un'espressione logica che verifica se una stringa contiene una sottostringa specifica.
        public static void CheckSubstring(string mainString, string subString)
        {
            if (mainString.Contains(subString))
            {
                Console.WriteLine($"The string contains '{subString}'.");
            }
            else
            {
                Console.WriteLine($"The string does not contain '{subString}'.");
            }
        }

        // Esercizio 16: Utilizzare un if-else per verificare se un array contiene un elemento specifico.
        public static void CheckArrayContains(int[] array, int element)
        {
            if (array.Contains(element))
            {
                Console.WriteLine($"Array contains {element}.");
            }
            else
            {
                Console.WriteLine($"Array does not contain {element}.");
            }
        }

        // Esercizio 17: Creare una funzione che utilizza if-else per determinare se un numero è positivo, negativo o zero.
        public static void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Esercizio 18: Creare un programma che utilizza un switch per determinare il giorno della settimana.

        public static void GetDayOfWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }

        // Esercizio 19: Utilizzare un'istruzione if per verificare se un numero è divisibile per 3 e 5.
        public static void CheckDivisibility(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"{number} is divisible by both 3 and 5.");
            }
            else
            {
                Console.WriteLine($"{number} is not divisible by both 3 and 5.");
            }
        }

        // Esercizio 20: Scrivere un'istruzione if per verificare se un valore booleano è true.
        public static void CheckBoolean(bool value)
        {
            if (value)
            {
                Console.WriteLine("The value is true.");
            }
            else
            {
                Console.WriteLine("The value is false.");
            }
        }

        // Esercizio 21: Utilizzare un switch per valutare una variabile stringa.
        public static void SwitchString(string day)
        {
            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Start of the week.");
                    break;
                case "tuesday":
                case "wednesday":
                case "thursday":
                    Console.WriteLine("Midweek.");
                    break;
                case "friday":
                    Console.WriteLine("End of the workweek.");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid day entered.");
                    break;
            }
        }

        // Esercizio 22: Creare un programma che utilizza un if per verificare se un array è vuoto.
        public static void CheckIfArrayIsEmpty(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("The array is empty.");
            }
            else
            {
                Console.WriteLine("The array is not empty.");
            }
        }
    }
}
