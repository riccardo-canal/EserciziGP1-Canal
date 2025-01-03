namespace Classi
{
    public class Collezione
    {
        private string[] items = new string[10];

        // Esercizio 7: Creare una classe con proprietà indicizzate.
        public string this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }
}
