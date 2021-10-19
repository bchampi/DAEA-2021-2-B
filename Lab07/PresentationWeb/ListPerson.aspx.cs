using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using System.Data;

namespace PresentationWeb
{
    public partial class ListPerson : System.Web.UI.Page
    {
        DataTable tablePerson = new DataTable();
        BusinessPerson bp = new BusinessPerson();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tablePerson = bp.GetAll();

                dgvPerson.DataSource = tablePerson;
                dgvPerson.DataBind();
            }
        }
    }
}