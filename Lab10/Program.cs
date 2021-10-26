using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            // ORIGEN DE DATOS
            NorthwndDataContext context = new NorthwndDataContext();
            IQueryable<Products> query;

            // LISTAR TODOS LOS PRODUCTOS
            // string title = "LISTAR TODOS LOS PRODUCTOS";
            // Console.WriteLine(title + "\n==========================================================");
            // var query = from p in context.Products select p;


            // LISTAR PRODUCTOS CON CATEGORIA BERERAGES
            // string title = "PRODUCTOS CON CATEGORIA BERERAGES";
            // Console.WriteLine(title + "\n==========================================================");
            // var query = from p in context.Products 
            //             where p.Categories.CategoryName == "Beverages" select p;


            // LISTAR PRODUCTOS CUYO PRECIO ES MENOR A 20
            // string title = "LISTAR PRODUCTOS CUYO PRECIO ES MENOR A 20";
            // Console.WriteLine(title + "\n==========================================================");
            // var query = from p in context.Products where p.UnitPrice < 20 select p;


            // LISTAR NOMBRE DE PRODUCTOS QUE INCLUEN LA PALABRA 'QUESO'
            // string title = "LISTAR NOMBRE DE PRODUCTOS QUE INCLUEN LA PALABRA 'QUESO'";
            // Console.WriteLine(title + "\n==========================================================");
            // query = from p in context.Products where p.ProductName.Contains("queso") select p;


            // LISTAR PRODUCTOS CUYO PAQUETE SEA 'PKG O PKGS'
            // string title = "LISTAR PRODUCTOS CUYO PAQUETE SEA 'PKG O PKGS";
            // Console.WriteLine(title + "\n==========================================================");
            // query = from p in context.Products 
            //         where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs") select p;


            // LISTAR PRODUCTOS QUE EMPIEZAN CON LA LETRA 'A'
            // string title = "LISTAR PRODUCTOS QUE EMPIEZAN CON LA LETRA 'A'";
            // Console.WriteLine(title + "\n==========================================================");
            // query = from p in context.Products where p.ProductName.StartsWith("A") select p;


            // LISTAR PRODUCTOS SIN STOCK
            // string title = "LISTAR PRODUCTOS SIN STOCK";
            // Console.WriteLine(title + "\n==========================================================");
            // query = from p in context.Products where p.UnitsInStock == 0 select p;


            // LISTAR PRODUCTOS DISCONTINUADOS
            string title = "LISTAR PRODUCTOS DISCONTINUADOS";
            Console.WriteLine(title + "\n==========================================================");
            query = from p in context.Products where p.Discontinued == true select p;


            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2} \t QuantityPerUnit={3} \t Stock={4} \t Discontinued={5}",
                    prod.ProductID, prod.UnitPrice, prod.ProductName, prod.QuantityPerUnit, prod.UnitsInStock, prod.Discontinued);
            }


            Console.ReadKey();
        }

        private static void newProduct()
        {
            NorthwndDataContext context = new NorthwndDataContext();
            Products p = new Products();
            p.ProductName = "Peruvian Coffe";
            p.SupplierID = 20;
            p.CategoryID = 1;
            p.QuantityPerUnit = "10 pkgs";
            p.UnitPrice = 25;

            context.Products.InsertOnSubmit(p);
            context.SubmitChanges();
        }

        private static void editProduct()
        {
            NorthwndDataContext context = new NorthwndDataContext();
            var product = (from p in context.Products where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges();
        }

        private static void deleteProduct()
        {
            NorthwndDataContext context = new NorthwndDataContext();
            var product = (from p in context.Products where p.ProductID == 78
                           select p).FirstOrDefault();
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();
        }
    }
}
