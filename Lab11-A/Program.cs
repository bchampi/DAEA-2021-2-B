using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            bool next = true;
            while (next)
{
                Console.WriteLine("\nMENU");
                Console.WriteLine("============================================================================");
                Console.WriteLine("1. SINTAXIS EXPRESIONES DE CONSULTAS");
                Console.WriteLine("============================================================================");
                Console.WriteLine("2. SINTAXIS CONSULTA BASACA EN METODOS");
                Console.WriteLine("============================================================================");
                Console.WriteLine("3. CONSULTA DE PRODUCTOS CON TAMAÑO L");
                Console.WriteLine("============================================================================");
                Console.WriteLine("4. METODO SELECT PARA MOSTRAR LOS PRODUCTOS");
                Console.WriteLine("============================================================================");
                Console.WriteLine("5. METODO SELECT PARA MOSTRAR LOS PRODUCTOS EN SECUENCIA ANONIMA");
                Console.WriteLine("============================================================================");
                Console.WriteLine("6. USO DE FROM..FROM PARA MOSTRAR PEDIDOS < 500.00");
                Console.WriteLine("============================================================================");
                Console.WriteLine("7. USO DE FROM..FROM PARA MOSTRAR PEDIDOS DESDE EL 01-10-2002");
                Console.WriteLine("============================================================================");
                Console.WriteLine("8. CONSULTA DE NR. DE PEDIDOS > 2 Y < 6");
                Console.WriteLine("============================================================================");
                Console.WriteLine("9. PRODUCTOS DE COLOR ROJO");
                Console.WriteLine("============================================================================");
                Console.WriteLine("10. USO DE MATRIZ PARA ENCONTRAR PRODUCTOS");
                Console.WriteLine("============================================================================");
                Console.WriteLine("11. USO DE ORDERBY PARA LISTADO DE CONTACTOS POR APELLIDO");
                Console.WriteLine("============================================================================");
                Console.WriteLine("12. USO DE ORDERBY PARA LISTADO DE PRECIOS DE MAYOR A MENOR");
                Console.WriteLine("============================================================================");
                Console.WriteLine("13. USO DE ORDERBY Y THENBY PARA LISTADO DE CONTACTOS POR APELLIDO Y NOMBRES");
                Console.WriteLine("============================================================================");
                Console.WriteLine("14. USO DE AVERAGE PARA PROMEDIO DE PRODUCTOS POR ESTILO");
                Console.WriteLine("============================================================================");
                Console.WriteLine("15. USO DE COUNT PARA CANTIDAD DE PRODUCTOS POR COLOR");
                Console.WriteLine("============================================================================");
                Console.WriteLine("16. USO DE MAX PARA OBTENER EL MAYOR IMPORTA A PAGAR");
                Console.WriteLine("============================================================================");
                Console.WriteLine("0. SALIR\n");

                string menu = Console.ReadLine();

                using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
                {
                    var products = AWEntities.Product;
                    var contacts = AWEntities.Person;
                    var orders = AWEntities.SalesOrderHeader;
                    Console.Clear();
                    switch (menu)
                    {
                        case "1":
                            IQueryable<string> productName = from p in products select p.Name;
                            foreach (var product in productName)
                            {
                                Console.WriteLine(product);
                            }
                            ReadLine();
                            break;

                        case "2":
                            IQueryable<string> productNameS = products.Select(p => p.Name);
                            foreach (var product in productNameS)
                            {
                                Console.WriteLine(product);
                            }
                            ReadLine();
                            break;

                        case "3":
                            IQueryable<Product> productsQuery = from p in products select p;
                            IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");
                            foreach (var product in largeProducts)
                            {
                                Console.WriteLine(product.Name);
                            }
                            ReadLine();
                            break;

                        case "4":
                            productsQuery = from product in AWEntities.Product select product;
                            foreach (var product in productsQuery)
                            {
                                Console.WriteLine(product.Name);
                            }
                            ReadLine();
                            break;

                        case "5":
                            var query = from product in AWEntities.Product
                                            select new
                                            {
                                                ProductId = product.ProductID,
                                                ProductName = product.Name
                                            };
                            foreach (var product in query)
                            {
                                Console.WriteLine("Product Id: {0} Product Name: {1} ", product.ProductId, product.ProductName);
                            }
                            ReadLine();
                            break;

                        case "6":
                            var query2 = from contact in contacts
                                    from order in orders
                                    where contact.BusinessEntityID == order.SalesPerson.BusinessEntityID && 
                                    order.TotalDue < 500.00M 
                                    select new 
                                    { 
                                        ContactID = contact.BusinessEntityID,
                                        LastName = contact.LastName,
                                        FirstName = contact.FirstName,
                                        OrderID = order.SalesOrderID,
                                        Total =  order.OrderDate
                                    };
                            foreach (var smallOrder in query2)
                            {
                                Console.WriteLine("ContactId: {0} \t LastName: {1} \t FirstName: {2} \t OrderId: {3} \t TotalDue: ${4}", 
                                    smallOrder.ContactID, smallOrder.LastName, smallOrder.FirstName, smallOrder.OrderID, smallOrder.Total);
                            }
                            ReadLine();
                            break;

                        case "7":
                            var query3 = from contact in contacts
                                     from order in orders
                                     where contact.BusinessEntityID == order.SalesPerson.BusinessEntityID &&
                                     order.OrderDate >= new DateTime(2002, 10, 1)
                                     select new {
                                         ContactID = contact.BusinessEntityID,
                                         LastName = contact.LastName,
                                         FirstName = contact.FirstName,
                                         OrderID = order.SalesOrderID,
                                         OrderDate = order.OrderDate
                                     };
                            foreach (var order in query3)
                            {
                                Console.WriteLine("ContactId: {0} \t LastName: {1} \t FirstName: {2} \t OrderId: {3} \t OrderDate: ${4}",
                                    order.ContactID, order.LastName, order.FirstName, order.OrderID, order.OrderDate);
                            }
                            ReadLine();
                            break;

                        case "8":
                            //statement 
                            ReadLine();
                            break;

                        case "9":
                            //statement 
                            ReadLine();
                            break;

                        case "10":
                            //statement 
                            ReadLine();
                            break;

                        case "11":
                            //statement 
                            ReadLine();
                            break;

                        case "12":
                            //statement 
                            ReadLine();
                            break;

                        case "13":
                            //statement 
                            ReadLine();
                            break;

                        case "14":
                            //statement 
                            ReadLine();
                            break;

                        case "15":
                            //statement 
                            ReadLine();
                            break;

                        case "16":
                            //statement 
                            ReadLine();
                            break;

                        case "0":
                        default:
                            next = false;
                            break;
                    }
                }
            }

        }
        private static void ReadLine() { Console.ReadLine(); }
    }
}
