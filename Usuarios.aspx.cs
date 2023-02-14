using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaLucasTesteNoSSD
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Inserido(object sender, SqlDataSourceStatusEventArgs e)
        {
            if(e.Exception!= null)
            {
                IMsg.Text = "Inserindo um registro duplicado ou com os campos em branco";  
                e.ExceptionHandled = true;
            }
        }

        protected void Atualizado(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                IMsg.Text = "Alterando um registro sem informar todos os campos";
                e.ExceptionHandled = true;
            }
        }
    }
}