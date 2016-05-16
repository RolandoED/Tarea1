using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea1RolandoED
{
    class Book
    {
        public String Name { get; set; }
        public String Category { get; set; }
        public int Price { get; set; }
        public Book(String vNam, String vCat)
        {
            Random rnd = new Random();
            //int month = rnd.Next(1, 13); // creates a number between 1 and 12
            this.Price = rnd.Next(1000, 20000); // creates a number between 1 and 12
            this.Name = vNam;
            this.Category = vCat;
        }
        public Book()
        {
        }

        public Book(String vNam, String vCat, int vPrice)
        {
            Random rnd = new Random();            
            this.Price = vPrice;
            this.Name = vNam;
            this.Category = vCat;
        }

        public void RandomPrice() {
            Random rnd = new Random();
            this.Price = rnd.Next(1000, 20000); // creates a number between 1 and 12
        }

        public void printObject(){
            if (Name.Length != 0 && Price >0 && Category.Length != 0)
            {
                Console.WriteLine("" + this.Name + " \n\tCategoria: " + this.Category + " \n\tPrecio: ¢" + this.Price );
            }        
        }
    }
}
