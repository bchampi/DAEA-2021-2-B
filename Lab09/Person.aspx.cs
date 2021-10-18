using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab09
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool ValidatePerson(string firstName, string lastName)
        {
            if (firstName.Length != 0 && lastName.Length != 0)
            {
                return true;
            }
            return false;
        }

        protected void BtnGreeting_Click(object sender, EventArgs e)
        {
            if (ValidatePerson(textFirstName.Text, textLastName.Text))
            {
                Response.Write("<script>alert('Hola " + textFirstName.Text + " " + textLastName.Text + "');</script>");
            }
            else
                Response.Write("<script>alert('Llene los campos nombre y apellidos');</script>");
        }
    }
}