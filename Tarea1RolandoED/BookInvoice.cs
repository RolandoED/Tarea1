using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea1RolandoED
{
    class BookInvoice : Book 
    {
        public int amountBooks { get; set; }

        public BookInvoice(String vNam, String vCat, int vPrice, int amount)
        {
            Random rnd = new Random();            
            this.Price = vPrice;
            this.Name = vNam;
            this.Category = vCat;
            this.amountBooks = amount;
        }

        public void printObject()
        {
            if (Name.Length != 0 && Price > 0 && Category.Length != 0)
            {
                Console.WriteLine("" + this.Name + " \n\tCategoria: " + this.Category + " \n\tPrecio: " + this.Price + " colones\n\tCantidad: " + this.amountBooks);
            }
        }
    }
}
