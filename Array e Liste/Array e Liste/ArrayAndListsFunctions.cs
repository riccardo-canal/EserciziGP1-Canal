namespace Array_e_Liste
{
    internal class ArrayAndListsFunctions
    {
        // Esercizio 1: Creare un array di int con 5 elementi e stamparne i valori.
        internal static void PrintIntArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Esercizio 2: Dichiarare una lista di stringhe e aggiungere elementi dinamicamente.
        internal static void AddElementsToStringList()
        {
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        // Esercizio 3: Creare un array bidimensionale e popolarlo con valori. ([,])
        internal static void Populate2DArray()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Esercizio 4: Utilizzare un array per calcolare la media dei valori.
        internal static void CalculateAverage()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = numbers.Average();
            Console.WriteLine($"Average: {average}");
        }

        // Esercizio 5: Dichiarare una lista di oggetti personalizzati. (classi, enum, struct, ecc)
        public struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"Point - X: {X}, Y: {Y}";
            }
        }

        public enum Color
        {
            Red,
            Green,
            Blue
        }

        internal static void CustomObjectList()
        {
            // Lista di oggetti generici
            List<object> mixedList = new List<object>
            {
                new Person("Alice", 30), // Oggetto di classe
                new Point (10, 20),      // Oggetto di struct
                Color.Red                // Valore di enum
            };

            // Iterare attraverso la lista e stampare i valori
            foreach (var item in mixedList)
            {
                Console.WriteLine(item);
            }
        }

        // Esercizio 6: Creare un array di booleani per rappresentare lo stato di vari interruttori.
        internal static void BooleanArray()
        {
            bool[] switches = { true, false, true, true, false };
            foreach (var state in switches)
            {
                Console.WriteLine(state ? "ON" : "OFF");
            }
        }

        // Esercizio 7: Dichiarare una lista di numeri e ordinarla.
        internal static void SortNumberList()
        {
            List<int> numbers = new List<int> { 5, 3, 8, 1, 4 };
            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));
        }

        // Esercizio 8: Utilizzare un array per contare la frequenza di un valore.
        internal static void CountFrequency()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 2, 5 };
            int target = 2;
            int frequency = numbers.Count(n => n == target);
            Console.WriteLine($"Frequency of {target}: {frequency}");
        }

        // Esercizio 9: Creare una lista di stringhe e rimuovere elementi specifici.
        internal static void RemoveElementsFromList()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Banana" };
            // Rimuove la prima occorrenza di "Banana"
            // fruits.Remove("Banana");
            // Rimuove tutte le occorrenze di "Banana"
            fruits.RemoveAll(fruit => fruit == "Banana");

            Console.WriteLine(string.Join(", ", fruits));
        }

        // Esercizio 10: Dichiarare un array e inizializzarlo con valori predefiniti.
        internal static void PredefinedArray()
        {
            int[] numbers = [10, 20, 30, 40, 50];
            Console.WriteLine(string.Join(", ", numbers));
        }

        // Esercizio 11: Creare una lista che accetta solo valori univoci.
        internal static void UniqueValueList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 3, 4, 5, 1 };

            // Utilizza il metodo Distinct() per eliminare i valori duplicati dalla lista originale.
            // Distinct() restituisce solo i valori univoci.
            // ToList() converte il risultato in una nuova lista.
            List<int> uniqueNumbers = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(", ", uniqueNumbers));
        }

        // Esercizio 12: Utilizzare un array per rappresentare una matrice di 3x3.
        internal static void ArrayMatrix3x3()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Esercizio 13: Dichiarare una lista e cercare un elemento al suo interno.
        internal static void SearchElementInList()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            bool containsBob = names.Contains("Bob");
            Console.WriteLine($"List contains 'Bob': {containsBob}");
        }

        // Esercizio 14: Creare un array di oggetti e iterare sui valori.
        internal static void ArrayOfObjects()
        {
            Person[] people = { new Person("Alice", 30), new Person("Bob", 25) };
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }

        // Esercizio 15: Utilizzare una lista per memorizzare i punteggi di un gioco.
        internal static void GameScoresList()
        {
            List<int> scores = new List<int> { 100, 200, 300 };
            foreach (var score in scores)
            {
                Console.WriteLine($"Score: {score}");
            }
        }

        // Esercizio 16: Dichiarare un array di char per rappresentare una parola.
        internal static void CharArrayWord()
        {
            char[] word = { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine(new string(word));
        }

        // Esercizio 17: Creare una lista che accetta solo valori di tipo float.
        internal static void FloatList()
        {
            List<float> numbers = new List<float> { 1.5f, 2.3f, 3.7f };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Esercizio 18: Utilizzare un array per memorizzare i giorni della settimana.
        internal static void DaysOfWeekArray()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(string.Join(", ", days));
        }

        // Esercizio 19: Dichiarare una lista e modificarne gli elementi in base alla loro posizione.
        internal static void ModifyListElements()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            numbers[2] = 100;
            Console.WriteLine(string.Join(", ", numbers));
        }

        // Esercizio 20: Creare un array di stringhe e concatenare tutti i valori in un'unica stringa.
        internal static void ConcatenateArrayStrings()
        {
            string[] words = { "Hello", "World", "from", "C#" };
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }

        // Esercizio 21: Utilizzare una lista per memorizzare dati inseriti dall'utente.
        internal static void UserInputList()
        {
            List<string> inputs = new List<string>();
            Console.WriteLine("Enter words (type 'stop' to end):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "stop")
                    break;
                inputs.Add(input);
            }
            Console.WriteLine("You entered: " + string.Join(", ", inputs));
        }

        // Esercizio 22: Dichiarare un array di numeri casuali.
        internal static void RandomNumberArray()
        {
            Random random = new Random();
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        // Esercizio 23: Creare una lista che accetta solo valori superiori a 10.
        internal static void FilterValuesAbove10()
        {
            List<int> numbers = new List<int> { 5, 15, 20, 3, 8 };
            // Filtra i numeri nella lista, mantenendo solo quelli maggiori di 10
            // La funzione Where prende ogni numero 'n' e restituisce 'true' solo se n è maggiore di 10
            List<int> filtered = numbers.Where(n => n > 10).ToList();
            Console.WriteLine(string.Join(", ", filtered));
        }

        // Esercizio 24: Utilizzare un array per rappresentare una tabella di moltiplicazione.
        internal static void MultiplicationTableArray()
        {
            const int size = 10;
            int[,] table = new int[size, size];
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    table[i - 1, j - 1] = i * j;
                    Console.Write(table[i - 1, j - 1].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        // Esercizio 25: Dichiarare una lista e convertirla in array.
        internal static void ConvertListToArray()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            int[] array = numbers.ToArray();
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
