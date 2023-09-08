namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // istanzio 3 oggetti della Classe Product
            Product product1 = new Product("maglietta", "maglietta soffice in cotone a maniche corte", 10.0f);
            Product product2 = new Product("pantaloni", "pantaloni super", 40.99f);
            Product product3 = new Product("felpa", "felpa molto calda", 35.99f);

            // stampo a video il nome del prodotto, il suo codice e la sua descrizione
            Console.WriteLine($"Il nome del prodotto è: {product1.Name}");
            Console.WriteLine($"Il codice del prodotto {product1.Name} è: {product1.Code}");
            Console.WriteLine($"La descrizione del prodotto {product1.Name} è: {product1.Description}");

            // stampo a video il prezzo senza iva
            Console.Write($"Il prezzo senza iva del prodotto {product1.Name} è: ");
            product1.PriceWithoutVat();

            // stampo a video il prezzo con iva
            Console.Write($"Il prezzo con iva del prodotto {product1.Name} è: ");
            product1.PriceWithVat();

            // Stampo a video il nome concatenato
            string concatenatedNameProduct1 = product1.ConcatenatedName();
            Console.WriteLine($"Il nome concatenato del prodotto {product1.Name} è: ");
            Console.WriteLine(concatenatedNameProduct1);

            // PRODOTTO 2 ----------------
            // stampo a video il nome del prodotto, il suo codice e la sua descrizione
            Console.WriteLine($"Il nome del prodotto è: {product2.Name}");
            Console.WriteLine($"Il codice del prodotto {product2.Name} è: {product2.Code}");
            Console.WriteLine($"La descrizione del prodotto {product2.Name} è: {product2.Description}");

            // stampo a video il prezzo senza iva
            Console.Write($"Il prezzo senza iva del prodotto {product2.Name} è: ");
            product2.PriceWithoutVat();

            // stampo a video il prezzo con iva
            Console.Write($"Il prezzo con iva del prodotto {product2.Name} è: ");
            product2.PriceWithVat();

            // Stampo a video il nome concatenato
            string concatenatedNameProduct2 = product2.ConcatenatedName();
            Console.WriteLine($"Il nome concatenato del prodotto {product2.Name} è: ");
            Console.WriteLine(concatenatedNameProduct2);
        }
    }
}