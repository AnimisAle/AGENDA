using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgendaLucasTesteNoSSD
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AçãoLogar(object sender, EventArgs e)
        {
            String email = txbEmail.Text;
            String senha = txbSenha.Text;
            //
            //capturar a string de conexão 
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            //cria um objeto de conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Usuario where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("senha", senha);
            con.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                //cookie 
                HttpCookie login = new HttpCookie("login",txbEmail.Text);
                Response.Cookies.Add(login);
                //direcionar para a página principal
                Response.Redirect("~/index.aspx"); 
                //IMsg.Text = "Congratulations";
            }
            else
            {   
                Response.Write("<script> alert('email ou senha incorretos!!!');</script>");
                //IMsg.Text = "E-mail ou senha incorretos"; 
            }
        }
    }
}