namespace Loop
{
    internal class LoopFunctions
    {
        // Esercizio 1: Scrivere un ciclo for che stampa numeri da 1 a 10.
        internal static void PrintNumbers()
        {
            // Stampa numeri da 1 a 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Esercizio 2: Creare un ciclo while che continua finché un valore è minore di 100.
        internal static void WhileLessThan100()
        {
            int value = 0;
            while (value < 100)
            {
                Console.WriteLine(value);
                value += 10;
            }
        }

        // Esercizio 3: Utilizzare un ciclo do-while per chiedere all'utente di inserire un valore valido.
        internal static void DoWhileGetValidInput()
        {
            int input;
            do
            {
                Console.WriteLine("Enter a number greater than 0:");
                input = int.Parse(Console.ReadLine());
            } while (input <= 0);
        }

        // Esercizio 4: Scrivere un ciclo for che calcola la somma di un array.
        internal static void SumArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum: {sum}");
        }

        // Esercizio 5: Utilizzare un ciclo foreach per iterare attraverso una lista di stringhe.
        internal static void IterateStringList()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Pear" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        // Esercizio 6: Creare un ciclo for che calcola il fattoriale di un numero.
        internal static void CalculateFactorial()
        {
            int factorial = 1;
            int number = 5; // Cambia il valore per testare
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number}: {factorial}");
        }

        // Esercizio 7: Scrivere un ciclo while che verifica se un numero è primo.
        internal static void CheckIfPrime()
        {
            int n = 29; // Cambia il numero per testare
            int divisor = 2;
            bool isPrime = true;
            while (divisor <= Math.Sqrt(n))
            {
                if (n % divisor == 0)
                {
                    isPrime = false;
                    break;
                }
                divisor++;
            }
            Console.WriteLine($"Is {n} prime? {isPrime}");
        }

        // Esercizio 8: Utilizzare un ciclo do-while per stampare i numeri pari fino a un massimo.
        internal static void PrintEvenNumbers()
        {
            int max = 10;
            int even = 0;
            do
            {
                Console.WriteLine(even);
                even += 2;
            } while (even <= max);
        }

        // Esercizio 9: Scrivere un ciclo for che stampa i numeri in ordine inverso.
        internal static void PrintReverseOrder()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Esercizio 10: Creare un ciclo while che calcola il prodotto dei numeri fino a un valore specifico.
        internal static void CalculateProduct()
        {
            int limit = 5;
            int product = 1;
            int current = 1;
            while (current <= limit)
            {
                product *= current;
                current++;
            }
            Console.WriteLine($"Product: {product}");
        }

        // Esercizio 11: Utilizzare un ciclo foreach per modificare i valori in una lista.
        internal static void ModifyListValues()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            for (int i = 0; i < list.Count; i++)
            {
                list[i] *= 2;
            }
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
        }

        // Esercizio 12: Scrivere un ciclo do-while che calcola il totale di un array.
        internal static void CalculateArrayTotal()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int total = 0;
            int index = 0;
            do
            {
                total += arr[index];
                index++;
            } while (index < arr.Length);
            Console.WriteLine($"Total: {total}");
        }

        // Esercizio 13: Creare un ciclo for che utilizza un'istruzione break.
        internal static void BreakInForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

        // Esercizio 14: Utilizzare un ciclo while che termina con un'istruzione continue.
        internal static void ContinueInWhileLoop()
        {
            int count = 0;
            while (count < 10)
            {
                count++;
                if (count % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(count);
            }
        }

        // Esercizio 15: Scrivere un ciclo for che utilizza una variabile dichiarata all'esterno del ciclo.
        internal static void ForLoopWithExternalVariable()
        {
            int outerVariable = 0;
            for (; outerVariable < 5; outerVariable++)
            {
                Console.WriteLine(outerVariable);
            }
        }

        // Esercizio 16: Creare un ciclo foreach che stampa gli indici e i valori di un array.
        internal static void PrintIndexAndValues()
        {
            string[] colors = { "Red", "Blue", "Green" };
            foreach (string color in colors.Select((value, index) => $"{index}: {value}"))
            {
                Console.WriteLine(color);
            }
        }

        // Esercizio 17: Utilizzare un ciclo do-while che verifica un valore booleano prima di continuare.
        internal static void DoWhileWithBooleanCondition()
        {
            bool condition = true;
            int attempts = 0;
            do
            {
                attempts++;
                Console.WriteLine($"Attempt: {attempts}");
                condition = attempts < 3;
            } while (condition);
        }

        // Esercizio 18: Scrivere un ciclo for che calcola la somma dei numeri dispari.
        internal static void SumOddNumbers()
        {
            int oddSum = 0;
            for (int i = 1; i <= 10; i += 2)
            {
                oddSum += i;
            }
            Console.WriteLine($"Odd sum: {oddSum}");
        }

        // Esercizio 19: Creare un ciclo while che termina quando un valore raggiunge una soglia.
        internal static void WhileUntilThreshold()
        {
            int threshold = 50;
            int currentValue = 0;
            while (currentValue < threshold)
            {
                currentValue += 10;
            }
            Console.WriteLine($"Final value: {currentValue}");
        }

        // Esercizio 20: Utilizzare un ciclo foreach per calcolare la lunghezza totale di tutte le stringhe in una lista.
        internal static void TotalStringLength()
        {
            List<string> words = new List<string> { "Hello", "World", "Programming" };
            int totalLength = 0;
            foreach (string word in words)
            {
                totalLength += word.Length;
            }
            Console.WriteLine($"Total length: {totalLength}");
        }

        // Esercizio 21: Scrivere un ciclo do-while che stampa un menu fino a quando l'utente sceglie di uscire.
        internal static void MenuWithDoWhile()
        {
            string choice;
            do
            {
                Console.WriteLine("1. Option 1\n2. Option 2\n3. Exit");
                choice = Console.ReadLine();
            } while (choice != "3");
        }

        // Esercizio 22: Creare un ciclo for che utilizza una condizione complessa.
        internal static void ComplexConditionInForLoop()
        {
            for (int i = 0, j = 10; i < j; i++, j--)
            {
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }

        // Esercizio 23: Utilizzare un ciclo while per cercare un valore specifico in un array.
        internal static void SearchInArray()
        {
            int[] searchArray = { 1, 2, 3, 4, 5 };
            int target = 3;
            int pos = 0;
            bool found = false;
            while (pos < searchArray.Length)
            {
                if (searchArray[pos] == target)
                {
                    found = true;
                    break;
                }
                pos++;
            }
            Console.WriteLine($"Value found? {found}");
        }

        // Esercizio 24: Scrivere un ciclo for che calcola la media di un array.
        internal static void CalculateArrayAverage()
        {
            int[] values = { 10, 20, 30, 40 };
            int valuesSum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                valuesSum += values[i];
            }
            double average = (double)valuesSum / values.Length;
            Console.WriteLine($"Average: {average}");
        }

        // Esercizio 25: Creare un ciclo foreach che copia valori da un array a un altro.
        internal static void CopyArrayValues()
        {
            int[] sourceArray = { 1, 2, 3 };
            int[] targetArray = new int[sourceArray.Length];
            int targetIndex = 0;
            foreach (int item in sourceArray)
            {
                targetArray[targetIndex++] = item;
            }
            Console.WriteLine("Copied array: " + string.Join(", ", targetArray));
        }
    }
}
