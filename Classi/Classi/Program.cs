namespace Classi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Header
            Console.WriteLine("======================");
            Console.WriteLine("Exercises on Classes");
            Console.WriteLine("======================");

            // Esercizio 1: Creare una classe Persona con proprietà per nome e età e una classe Lavoro con parametri il nome e la descrizione.
            Console.WriteLine("\nExercise 1\n");
            ClassFunctions.PersonaAndLavoroClasses();

            // Esercizio 2: Dichiarare una classe con un costruttore parametrizzato.
            Console.WriteLine("\nExercise 2\n");
            ClassFunctions.ClassWithParameterizedConstructor();

            // Esercizio 3: Creare una classe che implementa un metodo per calcolare un valore.
            Console.WriteLine("\nExercise 3\n");
            ClassFunctions.ClassWithCalculationMethod();

            // Esercizio 4: Creare una classe che eredita da un'altra.
            Console.WriteLine("\nExercise 4\n");
            ClassFunctions.ClassWithInheritance();

            // Esercizio 5: Aggiungere diversi metodi public all'interno della classe 'Persona'
            Console.WriteLine("\nExercise 5\n");
            ClassFunctions.PersonaWithMethods();

            // Esercizio 6: Creare una classe che contiene una lista come proprietà.
            Console.WriteLine("\nExercise 6\n");
            ClassFunctions.ClassWithListProperty();

            // Esercizio 7: Creare una classe con proprietà indicizzate.
            Console.WriteLine("\nExercise 7\n");
            ClassFunctions.ClassWithIndexers();

            // Esercizio 8: Dentro a persona dichiarare un parametro di tipo Lavoro
            Console.WriteLine("\nExercise 8\n");
            ClassFunctions.PersonaWithLavoroParameter();

            // Esercizio 9: Fare un programma che data una lista di Persone e una lista di Lavori venga assegnato a ogni persona un Lavoro casuale.
            Console.WriteLine("\nExercise 9\n");
            ClassFunctions.AssignRandomLavoroToPersona();
        }
    }
}
