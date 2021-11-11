using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonList()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person
            {
                PersonID = 1,
                FirstName = "Juan",
                LastName = "Perez",
                Address = "Av. Evergreen 123",
                DateOfBirth = Convert.ToDateTime("1997-11-07"),
                Email = "jperez@email.com"
            });
            persons.Add(new Person
            {
                PersonID = 2,
                FirstName = "Jazmin",
                LastName = "Esquivel",
                Address = "Av. Cajamarca 1003",
                DateOfBirth = Convert.ToDateTime("2001-01-20"),
                Email = "jesquivel@email.com"
            });
            persons.Add(new Person
            {
                PersonID = 3,
                FirstName = "Brayan",
                LastName = "Champi",
                Address = "Av. Pacifico",
                DateOfBirth = Convert.ToDateTime("2001-05-27"),
                Email = "brayan.champi@tecsup.edu.pe"
            });
            return View(persons);
        }

        public ActionResult PersonShow(int id)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person
            {
                PersonID = 1,
                FirstName = "Juan",
                LastName = "Perez",
                Address = "Av. Evergreen 123",
                DateOfBirth = Convert.ToDateTime("1997-11-07"),
                Email = "jperez@email.com"
            });
            persons.Add(new Person
            {
                PersonID = 2,
                FirstName = "Jazmin",
                LastName = "Esquivel",
                Address = "Av. Cajamarca 1003",
                DateOfBirth = Convert.ToDateTime("2001-01-20"),
                Email = "jesquivel@email.com"
            });
            persons.Add(new Person
            {
                PersonID = 3,
                FirstName = "Brayan",
                LastName = "Champi",
                Address = "Av. Pacifico",
                DateOfBirth = Convert.ToDateTime("2001-05-27"),
                Email = "brayan.champi@tecsup.edu.pe"
            });

            Person person = (from p in persons
                             where p.PersonID == id
                             select p).FirstOrDefault();

            return View(person);
        }
    }
}