namespace Classi
{
    public class Prodotto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Prodotto(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
