using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2Progra2_Equipo2.Vistas
{
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsAuthenticated"] != null && (bool)Session["IsAuthenticated"])
            {
                Response.Redirect("Hogar.aspx"); 
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            // Simulación de autenticación
            if (username == "admin" && password == "admin123")
            {
                Session["IsAuthenticated"] = true;
                Session["Username"] = username;    
                Response.Redirect("Hogar.aspx");  
            }
            else
            {
                ErrorLabel.Text = "Usuario o contraseña incorrectos.";
                ErrorLabel.Visible = true;
            }
        }
    }
} 