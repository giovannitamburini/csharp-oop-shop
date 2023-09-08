using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        // ATTRIBUTI

        public int Code { get; private set; }

        public string Name { get; set; } = "prodotto";

        public string Description { get; set; } = "descrizione non disponibile";

        public float Price { get; set; }

        public float Vat { get; } = 0.22f;
        /*
        private int code;
        public int Code
        {
            get
            {
                return code;
            }
        }

        private string name = "prodotto";
        public string Name
        {
            get
            { 
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string description = "descrizione";
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private float price;
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        private float vat = 0.22f;
        public float Vat
        {
            get
            {
                return vat;
            }
        }
        */

        // STATI


        // COSTRUTTORI

        public Product(string nameProduct, string descriptionproduct, float price)
        {
            this.Code = randomNumberGeneratorFrom1toN(100000000);
            this.Name = nameProduct;
            this.Description = descriptionproduct;
            this.Price = price;
        }


        // GETTER


        // SETTER


        // METODI

        // metodo per creare un numero intero casuale
        private int randomNumberGeneratorFrom1toN (int maxNumber)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, maxNumber);

            return randomNumber;
        }

        // metodo per stampare a video il prezzo senza iva
        public void PriceWithoutVat()
        {
            Console.WriteLine(Price);
        }

        // metodo per stampare a video il prezzo con iva
        public void PriceWithVat()
        {
            float priceWithVat = this.Price + (this.Price * this.Vat);
            Console.WriteLine(priceWithVat);
        }

        // metodo per avere il nome esteso, ottenuto concatenando codice + nome
        public string ConcatenatedName()
        {
            string codeForName = this.Code.ToString();

            string concatenatedName = codeForName + this.Name;

            return concatenatedName;
        }

        // BONUS
        
        // metodo per restituire un numero con un pad left di 0 per arrivare a 8 caratteri totali
        public string NumberConverterForPadLeftWithZero()
        {
            string codeInString = this.Code.ToString();

            if(codeInString.Length == 8)
            {
                return codeInString;
            } else
            {
                codeInString = codeInString.PadLeft(8, '0');

                //int codeWithPadLeft = int.Parse(codeInString);

                //return codeWithPadLeft;
                return codeInString;
            }
        }
    }
}
