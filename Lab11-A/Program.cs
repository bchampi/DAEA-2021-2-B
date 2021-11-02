using System;
using System.Linq;


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
                    switch (menu)
                    {
                        case "1":
                            IQueryable<string> productName = from p in products select p.Name;
                            foreach (var product in productName)
                            {
                                Console.WriteLine(product);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "2":
                            IQueryable<string> productNameS = products.Select(p => p.Name);
                            foreach (var product in productNameS)
                            {
                                Console.WriteLine(product);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "3":
                            IQueryable<Product> productsQuery = from p in products select p;
                            IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");
                            foreach (var product in largeProducts)
                            {
                                Console.WriteLine(product.Name);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "4":
                            productsQuery = from product in AWEntities.Product select product;
                            foreach (var product in productsQuery)
                            {
                                Console.WriteLine(product.Name);
                            }
                            ReadLine();
                            Clear();
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
                                Console.WriteLine("PRODUCT ID: {0} \t PRODUCT NAME: {1} ", product.ProductId, product.ProductName);
                            }
                            ReadLine();
                            Clear();
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
                                             Total = order.OrderDate
                                         };
                            foreach (var smallOrder in query2)
                            {
                                Console.WriteLine("CONTACT ID: {0}\nLASTNAME: {1}\nFIRSTNAME: {2}\nORDER ID: {3}\nTOTAL DUE: ${4}\n",
                                    smallOrder.ContactID, smallOrder.LastName, smallOrder.FirstName, smallOrder.OrderID, smallOrder.Total);
                            }
                            ReadLine();
                            Clear();
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
                                Console.WriteLine("CONTACT ID: {0} \t LASTNAME: {1} \t FIRSTNAME: {2} \t ORDER ID: {3} \t ORDER DATE: ${4}",
                                    order.ContactID, order.LastName, order.FirstName, order.OrderID, order.OrderDate);
                            }
                            ReadLine();
                            break;

                        case "8":
                            var query4 = from order in AWEntities.SalesOrderDetail
                                         where order.OrderQty > 2 && order.OrderQty < 6
                                         select new
                                         {
                                             SalesOrderID = order.SalesOrderID,
                                             orderQty = order.OrderQty
                                         };
                            foreach (var order in query4)
                            {
                                Console.WriteLine("ORDER ID: {0} \t ORDER QUANTITY: {1}",
                                    order.SalesOrderID, order.orderQty);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "9":
                            var query5 = from product in products
                                         where product.Color == "Red"
                                         select new
                                         {
                                             Name = product.Name,
                                             ProductNumber = product.ProductNumber,
                                             ListPrice = product.ListPrice
                                         };
                            foreach (var product in query5)
                            {
                                Console.WriteLine("NAME: {0}\nPRODUCT NUMBER: {1}\nLIST PRICE: ${2}\n",
                                    product.Name, product.ProductNumber, product.ListPrice);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "10":
                            int?[] productsModelIds = { 19, 26, 118 };
                            var query6 = from product in products
                                          where productsModelIds.Contains(product.ProductModelID)
                                          select product;
                            foreach (var product in query6)
                            {
                                Console.WriteLine("PRODUCT MODEL ID: {0}\nPRODUCT ID: {1}\n", product.ProductModelID, product.ProductID);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "11":
                            IQueryable<Person> sortedNames = from n in contacts orderby n.LastName select n;
                            foreach (Person n in sortedNames)
                            {
                                Console.WriteLine(n.LastName);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "12":
                            IQueryable<decimal> sortedPrices = from p in products 
                                                               orderby p.ListPrice descending select p.ListPrice;
                            foreach (decimal price in sortedPrices)
                            {
                                Console.WriteLine(price);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "13":
                            IQueryable<Person> sortedContacts = from contact in contacts 
                                                                orderby contact.LastName, contact.FirstName select contact;
                            foreach (Person contact in sortedContacts)
                            {
                                Console.WriteLine(contact.LastName + ", " + contact.FirstName);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "14":
                            var query7 = from product in products
                                         group product by product.Style into g
                                         select new
                                         {
                                             Style = g.Key,
                                             AverageListPrice = g.Average(product => product.ListPrice)
                                         };
                            foreach (var product in query7)
                            {
                                Console.WriteLine("ESTILO: {0}\nPRECIO PROMEDIO: {1}\n", product.Style, product.AverageListPrice);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "15":
                            var query8 = from product in products
                                         group product by product.Color into g
                                         select new
                                         {
                                             Color = g.Key,
                                             ProductCount = g.Count()
                                         };
                            foreach (var product in query8)
                            {
                                Console.WriteLine("COLOR: {0}\nCANTIDAD: {1}\n", product.Color, product.ProductCount);
                            }
                            ReadLine();
                            Clear();
                            break;

                        case "16":
                            var query9 = from order in orders
                                         group order by order.SalesPersonID into g
                                         select new
                                         {
                                             Category = g.Key,
                                             MaxTotalDue= g.Max(order => order.TotalDue)
                                         };
                            foreach (var order in query9)
                            {
                                Console.WriteLine("CONTACT ID: {0}\nTOTAL DUE MAX: {1}\n", order.Category, order.MaxTotalDue);
                            }
                            ReadLine();
                            Clear();
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
        private static void Clear() { Console.Clear(); }
    }
}
