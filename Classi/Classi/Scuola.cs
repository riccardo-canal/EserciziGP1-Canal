namespace Classi
{
    public class Scuola
    {
        public List<string> Students { get; set; }

        public Scuola()
        {
            Students = new List<string>();
        }

        // Esercizio 6: Creare una classe che contiene una lista come proprietà.
        public void AddStudent(string student)
        {
            Students.Add(student);
        }

        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Student: {student}");
            }
        }
    }
}
