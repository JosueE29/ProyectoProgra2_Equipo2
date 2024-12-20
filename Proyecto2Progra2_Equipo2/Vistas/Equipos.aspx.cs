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
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGridEquipos();
        }
        protected void LlenarGridEquipos()
        {
            {
                string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Equipos"))

                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridViewEquipos.DataSource = dt;
                            GridViewEquipos.DataBind();
                        }
                    }
                }
            }
        }
        protected void AgregarEquipo_Click(object sender, EventArgs e)
        {
            int EquipoID;
            string TipoEquipo = TipoEquipoTextBox.Text;
            string Modelo = ModeloTextBox.Text;
            int UsuarioID;

           
            if (!int.TryParse(EquiposIDTextBox.Text, out EquipoID))
            {
                Response.Write("<script>alert('El ID del Equipo debe ser un número válido.');</script>");
                return;
            }

       
            if (!int.TryParse(UserIDTextBox.Text, out UsuarioID)) 
            {
                Response.Write("<script>alert('El ID del Usuario debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.EquiposLogica.AgregarEquipos(EquipoID, TipoEquipo, Modelo, UsuarioID);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Equipo agregado exitosamente.');</script>");
                LlenarGridEquipos();

         
                EquiposIDTextBox.Text = "";
                TipoEquipoTextBox.Text = "";
                ModeloTextBox.Text = "";
                UserIDTextBox.Text = ""; 
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al agregar el Equipo. Verifique los datos.');</script>");
            }
        }
        protected void BorrarEquipo_Click(object sender, EventArgs e)
        {
            int EquiposID;


            if (!int.TryParse(EquiposIDTextBox.Text, out EquiposID))
            {
                Response.Write("<script>alert('El ID del Equipo debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.EquiposLogica.BorrarEquipo(EquiposID);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Equipo eliminado exitosamente.');</script>");
                LlenarGridEquipos();

                EquiposIDTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar el Equipo. Verifique el ID.');</script>");
            }
        }
        protected void ModificarEquipo_Click(object sender, EventArgs e)
        {
            int EquiposID;
            string TipoEquipo = TipoEquipoTextBox.Text.Trim();
            string Modelo = ModeloTextBox.Text.Trim();

   
            if (string.IsNullOrWhiteSpace(EquiposIDTextBox.Text) || !int.TryParse(EquiposIDTextBox.Text, out EquiposID))
            {
                Response.Write("<script>alert('El ID del Equipo debe ser un número válido.');</script>");
                return;
            }

    
            if (string.IsNullOrWhiteSpace(TipoEquipo) || string.IsNullOrWhiteSpace(Modelo))
            {
                Response.Write("<script>alert('Todos los campos son obligatorios. Por favor, complete los datos.');</script>");
                return;
            }

            try
            {
     
                int resultado = Logica.EquiposLogica.ModificarEquipo(EquiposID, TipoEquipo, Modelo);

                if (resultado > 0)
                {
        
                    Response.Write("<script>alert('Equipo modificado exitosamente.');</script>");
                    LlenarGridEquipos(); 


                    EquiposIDTextBox.Text = "";
                    TipoEquipoTextBox.Text = "";
                    ModeloTextBox.Text = "";
                }
                else
                {

                    Response.Write("<script>alert('No se encontró un equipo con el ID especificado.');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Ocurrió un error al intentar modificar el equipo: {ex.Message}');</script>");
            }
        }


    }

}

