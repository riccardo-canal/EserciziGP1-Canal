namespace Classi
{
    class ClassFunctions
    {
        // Esercizio 1: Creare una classe Persona con proprietà per nome e età e una classe Lavoro con parametri il nome e la descrizione.
        public static void PersonaAndLavoroClasses()
        {
            Persona person = new Persona("Mario", 30);
            Lavoro job = new Lavoro("Engineer", "System Design");

            Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");
            Console.WriteLine($"Job: {job.JobName}, Description: {job.Description}");
        }

        // Esercizio 2: Dichiarare una classe con un costruttore parametrizzato.
        public static void ClassWithParameterizedConstructor()
        {
            Prodotto product = new Prodotto("Laptop", 1000.0);
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        }

        // Esercizio 3: Creare una classe che implementa un metodo per calcolare un valore.
        public static void ClassWithCalculationMethod()
        {
            Calcolatrice calculator = new Calcolatrice();
            Console.WriteLine($"Sum: {calculator.Sum(5, 3)}");
            Console.WriteLine($"Multiplication: {calculator.Multiplication(5, 3)}");
        }

        // Esercizio 4: Creare una classe che eredita da un'altra.
        public static void ClassWithInheritance()
        {
            Cane dog = new Cane("Fido");
            dog.Sound();
            dog.Bark();
        }

        // Esercizio 5: Aggiungere diversi metodi public all'interno della classe 'Persona'
        public static void PersonaWithMethods()
        {
            Persona person = new Persona("Giulia", 25);
            person.Greet();
            person.Birthday();
        }

        // Esercizio 6: Creare una classe che contiene una lista come proprietà.
        public static void ClassWithListProperty()
        {
            Scuola school = new Scuola();
            school.AddStudent("Marco");
            school.AddStudent("Anna");
            school.ShowStudents();
        }

        // Esercizio 7: Creare una classe con proprietà indicizzate.
        public static void ClassWithIndexers()
        {
            Collezione collection = new Collezione();
            collection[0] = "Book";
            collection[1] = "Pen";
            Console.WriteLine(collection[0]);
            Console.WriteLine(collection[1]);
        }

        // Esercizio 8: Dentro a persona dichiarare un parametro di tipo Lavoro
        public static void PersonaWithLavoroParameter()
        {
            Lavoro job = new Lavoro("Teacher");
            Persona person = new Persona("Luca", job);
            Console.WriteLine($"{person.Name} is a {person.Job.JobName}");
        }

        // Esercizio 9: Fare un programma che data una lista di Persone e una lista di Lavori venga assegnato a ogni persona un Lavoro casuale.
        public static void AssignRandomLavoroToPersona()
        {
            Random random = new Random();
            List<Persona> people = new List<Persona>
            {
                new Persona("Maria", null),
                new Persona("Giovanni", null),
                new Persona("Luca", null)
            };

            List<Lavoro> jobs = new List<Lavoro>
            {
                new Lavoro("Doctor", "treats people"),
                new Lavoro("Engineer", "designs systems")
            };

            foreach (var person in people)
            {
                person.Job = jobs[random.Next(jobs.Count)];
                Console.WriteLine($"{person.Name} has the job of {person.Job.JobName}");
            }
        }
    }
}
