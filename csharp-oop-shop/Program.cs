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
            Console.Write($"Il nome concatenato del prodotto {product1.Name} è: ");
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
            Console.Write($"Il nome concatenato del prodotto {product2.Name} è: ");
            Console.WriteLine(concatenatedNameProduct2);

            // BONUS

            Console.WriteLine("BONUS -------------------------");

            // stampo a video il codice del prodotto con il pad left di 0 con 8 caratteri totali
            string codeWithPadLeft = product1.NumberConverterForPadLeftWithZero();
            Console.WriteLine($"Il codice del prodotto {product1} con il pad left è {codeWithPadLeft}");

            // inizializzo un array vuoto di 5 elementi
            //string[] productsArray = new string[5];

            // istanzio un array di prodotti di dimesione pari a 5
            Product[] expectedProductsArray = new Product[5];

            // creo un ciclo per chiedere all'utente il nome, la descrizione e il prezzo dei prodotti che si aspetta di trovare nel negozio
            for (int i = 0; i < expectedProductsArray.Length; i++)
            {
                // chiedo all'utente il nome del prodotto
                Console.Write($"Inseirsci il nome del {i + 1}° prodotto che ti aspetti di trovare: ");
                string expectedProductName = Console.ReadLine();

                // chiedo all'utente la descrizione del prodotto
                Console.Write($"Inserisci la descrizione del {i + 1}° prodotto che ti aspetti di trovare: ");
                string expectedProductDescription = Console.ReadLine();

                Console.Write($"Inserisci il prezzo del {i + 1}° prodotto che ti aspetti di trovare: ");

                float expectedProductPrice;

                // controllo che l'utente inserisca un numero valido
                while (!float.TryParse(Console.ReadLine(), out expectedProductPrice)) {

                    Console.WriteLine("Inserisci un prezzo valido");
                }

                expectedProductsArray[i] = new Product(expectedProductName, expectedProductDescription, expectedProductPrice);

            }


            // stampo a video il mio array di prodotti attesi
            foreach (Product product in expectedProductsArray)
            {
                int productIndex = 1;


                Console.WriteLine($"Il {productIndex}° prodotto:");
                Console.WriteLine(value: $"Nome: {product.Name}, Codice: {product.Code}, Descrizione: {product.Description}");
                Console.Write("Prezzo senza Iva: ");
                product.PriceWithoutVat();
                Console.Write("Prezzo con Iva: ");
                product.PriceWithVat();

                Console.WriteLine("----------------------");
            }


        }
    }
}