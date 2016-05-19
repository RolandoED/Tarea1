using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Tarea1RolandoED
{
    class Program
    {
        //dictionary.Add("infantiles", 0.1);
        /// <summary>
        /// Process is
        /// 1-  Create a list of pseudorandom books,
        ///     name is set, price is random
        /// 2-  Person selects the book and amount
        /// 3-  Price is calculated by units and saved to arraylist
        /// 4-  Depending on the genre of the books, they have a discount
        /// 5-  Make an invoice with every detail collected               
        /// 

        static String nombreLibreria = "Librería el Buen Lector";
        static String nombreCliente = "";
        static String telefonoCliente = "";
        static String SEPARADOR = "-------------------------------------------------";
        static String SEPARADOR2 = "=================================================";        
        static double PagaCon = 0;
        
        static List<string> libros = new List<string>(new string[] { 
                "El Señor de los Anillos, Las dos torres",
                "Alicia en el país de la Maravillas",
                "Cementerio de Mascotas",
                "Quiero aprender",
                "El poder del pensamiento Positivo",
                "Mi primer libro de matemáticas",
                "Las aventuras de Tom Sawyer",
                "El mago de Oz",
                "La zona muerta",
                "Viaje al centro de la tierra" });
        static List<string> generos = new List<string>(new string[] { "fantasia", "infantil", "misterio", "educativo", "superacion" ,"educativo", "infantil", "fantasia", "misterio" , "cienciaficcion"});
        
        static Dictionary<string, double> descuentos =
            new Dictionary<string, double>() { 
            {"infantiles", 0.05},
            {"misterio", 0.10},
            {"fantasia", 0.15},
            {"educativos", 0.20},
            {"otros", 0.25},                                
            };

        static void PrintBooks(List<Book> arrayLibros)
        {
            int cont = 1;
            foreach (var Book in arrayLibros)
            {
                Console.Write(cont + " - ");
                Book.printObject();
                cont++;
            }                
        }

        static void PrintInvoice(List<BookInvoice> array)
        {
            int cont = 1;
            Console.WriteLine("\n========Facturados Actual========\n");
            foreach (var BookInvoice in array)
            {
                Console.Write(cont + " - ");
                BookInvoice.printObject();
                cont++;
            }
        }

        static void clienteInfo()
        {
            Console.WriteLine("Ingrese el nombre del cliente");
            nombreCliente = Console.ReadLine();
            Console.Write("El nombre es: \n " + nombreCliente + "\n");
            Console.WriteLine("Ingrese el telefono del cliente");
            telefonoCliente = Console.ReadLine();
        }

        static void facturar(List<BookInvoice> array, int num)
        {
            double totalOrden = 0;
            double totalDescuento = 0;
            String output = "\n" + SEPARADOR2 + "\n\t*_* Libreria El Buen Lector *_*\n"+SEPARADOR2+"\n";
            //padded integer with 4 zeros
            output += "Factura Proforma\t\t\tN° " + num.ToString("D4") + "\n";
            output += "Cliente: " + nombreCliente + "\n";
            output += "Teléfono: " + telefonoCliente + "\n" + SEPARADOR + "\n";
            output += "Item\t\t\tCtd\tPrecio\tSubtotal\n";
            
            foreach (var item in array)
            {
                output += item.Name.Substring(0,13)+"...\t" +
                    item.amountBooks+"\t"+
                    "¢" + item.Price + "\t" +
                    "¢" + item.Price*item.amountBooks +
                    "\n";
                totalOrden += item.Price * item.amountBooks;
                //Descuento acorde al tipo de libro
                if (item.Category.Equals("infantil"))                
                    totalDescuento += (item.Price * item.amountBooks) * 0.05;                
                else if (item.Category.Equals("misterio"))                
                    totalDescuento += (item.Price * item.amountBooks) * 0.10;                
                else if (item.Category.Equals("fantasia"))                
                    totalDescuento += (item.Price * item.amountBooks) * 0.15;                
                else if (item.Category.Equals("educativos"))                
                    totalDescuento += (item.Price * item.amountBooks) * 0.20;                
                else 
                    totalDescuento += (item.Price * item.amountBooks) * 0.25;                
            }
            output += SEPARADOR + "\n";
            output += "Total Orden:\t\t\t\t¢" + totalOrden + "\n";
            output += "Total Descuento:\t\t\t¢" + Math.Round(totalDescuento) + "\n";
            output += "Impuesto Venta:\t\t\t\t13%\n";
            output += "Impuesto Total:\t\t\t\t¢" + Math.Round((totalOrden - totalDescuento) * 0.13) + "\n";
            output += "Precio Neto:\t\t\t\t¢" + Math.Round((totalOrden - totalDescuento) * 1.13) + "\n";
            output += SEPARADOR + "\n";
            output += "Monto Recibido:\t¢" + PagaCon + "\n";
            output += "Monto Cambio:\t¢" + Math.Round(PagaCon - ((totalOrden - totalDescuento) * 1.13)) + "\n";
            output += "=========================================\n";
            output += "Gracias por su Compra...\n";
            Console.WriteLine(output);
        }

        static double averiguarTotal(List<BookInvoice> array)
        {
            double totalOrden = 0;
            double totalDescuento = 0;           
            foreach (var item in array)
            {
                totalOrden += item.Price * item.amountBooks;
                //Descuento acorde al tipo de libro
                if (item.Category.Equals("infantil"))
                    totalDescuento += (item.Price * item.amountBooks) * 0.05;
                else if (item.Category.Equals("misterio"))
                    totalDescuento += (item.Price * item.amountBooks) * 0.10;
                else if (item.Category.Equals("fantasia"))
                    totalDescuento += (item.Price * item.amountBooks) * 0.15;
                else if (item.Category.Equals("educativos"))
                    totalDescuento += (item.Price * item.amountBooks) * 0.20;
                else
                    totalDescuento += (item.Price * item.amountBooks) * 0.25;
            }
            return totalOrden - totalDescuento;
            
        }


        static void Main()
        {
            bool salir = true;
            int numfactura = 1;
            Console.WriteLine("\t"+nombreLibreria+"\n");
            List<Book> arrayLibros = new List<Book>();
            List<BookInvoice> arrayfactura = new List<BookInvoice>();
            Random rnd = new Random();
            int idLibro = Int16.MinValue;
            int cantLibros = Int16.MinValue;
            //Crea todos los libros
            for (int i = 0; i < 10; i++)
            {   //Genera un libro con precio aleatorio
                Book x = new Book(libros[i], generos[i], rnd.Next(1000, 10000));
                Console.Write(i+1+" - ");
                x.printObject();
                arrayLibros.Add(x);
            }
            //El usuario entra los libros y la cantidad.
            while (salir)
            {
                Console.WriteLine("\t" + nombreLibreria + "\n\n");
                Console.WriteLine("\nIngrese el número del libro a agregar \n< \"salir\" \tpara terminar la ejecucion>" +
                "\n< \"libros\" \tpara listarlos>" +
                "\n< \"facturar\" \tpara Facturar>" +
                "\n< \"cliente\" \tpara ingresar datos del cliente>");
                string datoIngresado = Console.ReadLine();
                if (datoIngresado.ToLower().Equals("salir"))
                    System.Environment.Exit(0);
                else if (datoIngresado.ToLower().Equals("clear"))
                    Console.Clear();
                else if (datoIngresado.ToLower().Equals("libros"))
                    PrintBooks(arrayLibros);
                else if (datoIngresado.ToLower().Equals("cliente"))
                    clienteInfo();
                else if (datoIngresado.ToLower().Equals("facturar"))
                {
                    //Muestra cuanto debe
                    double TotalaPagar = Math.Round(averiguarTotal(arrayfactura) * 1.13);
                    Console.WriteLine("El total con descuento + IVA es : ¢ " + TotalaPagar);
                    Console.WriteLine("Ingrese con cuanto paga: ¢ ");
                    try
                    {
                        PagaCon = double.Parse(Console.ReadLine());
                        if (PagaCon < TotalaPagar) throw new Exception("Error: Cantidad Menor al monto a Pagar");
                        facturar(arrayfactura, numfactura);
                        numfactura++;
                        arrayfactura.Clear();
                        PagaCon = 0;
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("ERROR" + e.Message);
                        //MessageBox.Show("" + e.Message);
                    }
                }
                else
                {
                    try
                    {
                        idLibro = int.Parse(datoIngresado);
                        //Analiza si esta en rango de 0 a el maximo de libros
                        if (idLibro >= 0 && idLibro <= arrayLibros.Count)
                        {
                            Console.Write("En Rango\n");
                            Console.WriteLine("El Libro es: ");
                            arrayLibros[idLibro - 1].printObject();
                            Console.WriteLine("Inserte la cantidad de Libros: ");
                            cantLibros = int.Parse(Console.ReadLine());
                            //Excepcion si la cantidad es menor a 0
                            if (cantLibros <= 0) throw new Exception("Error: Cantidad Menor a 0");
                            Book LibroaAgregar = arrayLibros[idLibro - 1];
                            arrayfactura.Add(new BookInvoice(LibroaAgregar.Name, LibroaAgregar.Category, LibroaAgregar.Price, cantLibros));
                            //Imprime el estado actual de la factura
                            PrintInvoice(arrayfactura);
                        }
                        else
                        {
                            MessageBox.Show("ERROR: Numero Fuera de Rango No existe el libro");
                        }
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("ERROR" + e.Message);
                        //MessageBox.Show("" + e.Message);
                    }
                }
            }


        #region  JSON ADD TO FILE

            //JavaScriptSerializer ser = new JavaScriptSerializer();
            //string outputJSON = ser.Serialize(arrayLibros);
            //File.WriteAllText("Output.json", outputJSON);
            //Console.ReadLine();

            ////JSON TESTS
            //String JSONString = File.ReadAllText("Books.json");

            //JavaScriptSerializer ser = new JavaScriptSerializer();
            //Book b1 = ser.Deserialize<Book>(JSONString);
            //Console.WriteLine(b1);

        #endregion


        }
    }
}
