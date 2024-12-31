namespace Variabili
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Variables");
            Console.WriteLine("======================");

            // Esercizio 1: Dichiarare una variabile di tipo int e assegnarle un valore, quindi modificarlo.
            Console.WriteLine("\nExcercise 1:\n");
            int number = 10;
            Console.WriteLine($"Initial value of number: {number}");
            number = 20;
            Console.WriteLine($"Modified value of number: {number}");

            // Esercizio 2: Creare una variabile di tipo string e concatenarla con un'altra stringa.
            Console.WriteLine("\nExcercise 2:\n");
            string greeting = "Hello";
            string name = "Mario";
            string message = greeting + ", " + name + "!";
            Console.WriteLine(message);

            // Esercizio 3: Dichiarare una variabile di tipo bool e cambiarne il valore.
            Console.WriteLine("\nExcercise 3:\n");
            bool isActive = true;
            Console.WriteLine($"Initial value of isActive: {isActive}");
            isActive = false;
            Console.WriteLine($"Modified value of isActive: {isActive}");

            // Esercizio 4: Utilizzare una variabile di tipo double per rappresentare un numero con decimali.
            Console.WriteLine("\nExcercise 4:\n");
            double decimalNumber = 10.5;
            Console.WriteLine($"Double number: {decimalNumber}");

            // Esercizio 5: Dichiarare una variabile char e assegnarle un carattere.
            Console.WriteLine("\nExcercise 5:\n");
            char character = 'A';
            Console.WriteLine($"Character: {character}");

            // Esercizio 6: Usare una variabile di tipo decimal per rappresentare una quantità monetaria.
            Console.WriteLine("\nExcercise 6:\n");
            decimal price = 19.99m;
            Console.WriteLine($"Price: {price}");

            // Esercizio 7: Dichiarare una variabile float e assegnarle un valore, verificandone la precisione rispetto a double.
            Console.WriteLine("\nExcercise 7:\n");
            float floatNumber = 1.123456789f; // Precisione: ~6-9 cifre. Grandezza: 4 byte
            double doubleNumber = 1.1234567891234567; // Precisione: ~15-17 cifre. Grandezza: 8 byte
            Console.WriteLine($"Precision of float: {floatNumber}");
            Console.WriteLine($"Precision of double: {doubleNumber}");

            // Esercizio 8: Dichiarare una variabile long per rappresentare un numero molto grande.
            Console.WriteLine("\nExcercise 8:\n");
            long largeNumber = 1234567890123456789L;
            Console.WriteLine($"Large number: {largeNumber}");

            // Esercizio 9: Creare una variabile short e verificare il suo range di valori.
            Console.WriteLine("\nExcercise 9:\n");
            short shortNumber;

            // Verifica del range di valori
            Console.WriteLine("Range di valori per il tipo short:");
            Console.WriteLine($"Valore minimo di short: {short.MinValue}");
            Console.WriteLine($"Valore massimo di short: {short.MaxValue}");

            // Esempio con numeri che rientrano nel range
            shortNumber = 100;
            Console.WriteLine($"Esempio di valore short: {shortNumber}");

            // Esercizio 10: Usare una variabile byte per rappresentare un numero tra 0 e 255.
            Console.WriteLine("\nExcercise 10:\n");
            byte byteNumber = 200;
            Console.WriteLine($"Byte number: {byteNumber}");

            // Esercizio 11: Dichiarare una variabile const e provare a modificarne il valore.
            Console.WriteLine("\nExcercise 11:\n");
            const int constant = 100;
            Console.WriteLine($"Constant: {constant}");
            // constant = 200; // Errore: non si può modificare una costante.

            // Esercizio 12: Dichiarare più variabili in una sola riga e assegnare loro valori diversi.
            Console.WriteLine("\nExcercise 12:\n");
            int x = 1, y = 2, z = 3;
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");

            // Esercizio 13: Dichiarare una variabile di tipo var e verificare come il compilatore determina il tipo.
            Console.WriteLine("\nExcercise 13:\n");
            var inferredNumber = 42;
            Console.WriteLine($"Type inferred by var: {inferredNumber.GetType()}");

            // Esercizio 14: Dichiarare e usare variabili con valori predefiniti.
            Console.WriteLine("\nExcercise 14:\n");
            int defaultInt = default; // 0
            bool defaultBool = default; // false
            string? defualtString = default; // null

            Console.WriteLine($"Default value of int: {defaultInt}");
            Console.WriteLine($"Default value of bool: {defaultBool}");
            Console.WriteLine($"Default value of string: {defualtString}");

            // Esercizio 15: Cambiare il tipo di una variabile usando il casting esplicito.
            Console.WriteLine("\nExcercise 15:\n");
            double numberToCast = 9.99;
            int castedNumber = (int)numberToCast;
            Console.WriteLine($"Casted number: {castedNumber}");

            // Esercizio 16: Dichiarare una variabile costante di tipo string.
            Console.WriteLine("\nExcercise 16:\n");
            const string constantMessage = "This is a constant message.";
            Console.WriteLine(constantMessage);

            // Esercizio 17: Utilizzare una variabile per rappresentare una data usando il tipo DateTime.
            Console.WriteLine("\nExcercise 17:\n");
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Current date: {currentDate}");

            // Esercizio 18: Dichiarare una variabile e utilizzarla in un'espressione matematica.
            Console.WriteLine("\nExcercise 18:\n");
            int baseNumber = 5;
            int result = baseNumber * 10;
            Console.WriteLine($"Result of the operation: {result}");
        }
    }
}
