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
            Console.WriteLine("Initial value of number: " + number);
            number = 20;
            Console.WriteLine("Modified value of number: " + number);

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
            Console.WriteLine($"Modified value of isActive: {isActive}" );

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
            Console.WriteLine("Precision of float: " + floatNumber);
            Console.WriteLine("Precision of double: " + doubleNumber);
        }
    }
}
