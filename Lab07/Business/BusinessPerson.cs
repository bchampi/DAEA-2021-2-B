using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessPerson
    {
        DAOPerson daoPerson = new DAOPerson();

        public DataTable GetAll()
        {
            return daoPerson.GetAll();
        }

        public DataTable SearchPerson(string input)
        {
            return daoPerson.SearchPerson(input);
        }
    }
}
