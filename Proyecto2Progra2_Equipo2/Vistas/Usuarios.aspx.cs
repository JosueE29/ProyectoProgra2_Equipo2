using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2Progra2_Equipo2.Vistas
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGridUsers();
        }
        protected void LlenarGridUsers()
        {
            {
                string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Usuarios"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                GridViewUsers.DataSource = dt;
                                GridViewUsers.DataBind();
                            }
                        }
                    }
                }
            }
        }
        protected void AgregarUser_Click(object sender, EventArgs e)
        {
            int usuarioID;
            string nombre = NombreTextBox.Text;
            string correo = EmailUserTextBox.Text;
            int telefono;

            if (!int.TryParse(UserIDTextBox.Text, out usuarioID))
            {
                Response.Write("<script>alert('El ID del usuario debe ser un número válido.');</script>");
                return;
            }
           
            if (!int.TryParse(TelefonoUserTextBox.Text, out telefono))
            {
                Response.Write("<script>alert('El teléfono debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.UsuariosLogica.AgregarUsuarios(usuarioID, nombre, correo, telefono);

            if (resultado > 0)
            {

                Response.Write("<script>alert('Usuario agregado exitosamente.');</script>");

                LlenarGridUsers();


                UserIDTextBox.Text = "";
                NombreTextBox.Text = "";
                EmailUserTextBox.Text = "";
                TelefonoUserTextBox.Text = "";
            }
            else
            {

                Response.Write("<script>alert('Ocurrió un error al agregar el usuario. Verifique los datos.');</script>");
            }
        }
        protected void BorrarUser_Click(object sender, EventArgs e)
        {
            int usuarioID;


            if (!int.TryParse(UserIDTextBox.Text, out usuarioID))
            {
                Response.Write("<script>alert('El ID del user debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.UsuariosLogica.EliminarUsuario(usuarioID);

            if (resultado > 0)
            {
                Response.Write("<script>alert('User eliminada exitosamente.');</script>");
                LlenarGridUsers();

                UserIDTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar el usuario. Verifique el ID.');</script>");
            }
        }
        protected void ModificarUser_Click(object sender, EventArgs e)
        {
            int UsuarioID;
            string Nombre = NombreTextBox.Text;
            string CorreoElectronico = EmailUserTextBox.Text;
            string Telefono = TelefonoUserTextBox.Text;

            if (!int.TryParse(UserIDTextBox.Text, out UsuarioID))
            {
                Response.Write("<script>alert('El ID del Usuario debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.UsuariosLogica.ModificarUsuario(UsuarioID, Nombre, CorreoElectronico, Telefono);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Usuario modificado exitosamente.');</script>");
                LlenarGridUsers();


                UserIDTextBox.Text = "";
                NombreTextBox.Text = "";
                EmailUserTextBox.Text = "";
                TelefonoUserTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Error al modificar el usuario. Verifique los datos.');</script>");
            }
        }
    }
}