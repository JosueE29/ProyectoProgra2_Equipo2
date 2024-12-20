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
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGridTecnicos();
        }
        protected void LlenarGridTecnicos()
        {
            {
                string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Tecnicos"))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                GridViewTecnicos.DataSource = dt;
                                GridViewTecnicos.DataBind();
                            }
                        }
                    }
                }
            }
        }
        protected void AgregarTecnico_Click(object sender, EventArgs e)
        {
            int TecnicoID;
            string NombreTech = NombreTechTextBox.Text;
            string Especialidad = EspecialidadTextBox.Text;


            if (!int.TryParse(TecnicosIDTextBox.Text, out TecnicoID))
            {
                Response.Write("<script>alert('El ID del usuario debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.TecnicosLogica.AgregarTecnicos(TecnicoID, NombreTech, Especialidad);

            if (resultado > 0)
            {

                Response.Write("<script>alert('Tecnico agregado exitosamente.');</script>");

                LlenarGridTecnicos();


                TecnicosIDTextBox.Text = "";
                NombreTechTextBox.Text = "";
                EspecialidadTextBox.Text = "";
            }
            else
            {

                Response.Write("<script>alert('Ocurrió un error al agregar al Tecnico. Verifique los datos.');</script>");
            }
        }
        protected void BorrarTecnico_Click(object sender, EventArgs e)
        {
            int TecnicoID;


            if (!int.TryParse(TecnicosIDTextBox.Text, out TecnicoID))
            {
                Response.Write("<script>alert('El ID del Tecnico debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.TecnicosLogica.borrar_tecnico(TecnicoID);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Tecnico eliminado exitosamente.');</script>");
                LlenarGridTecnicos();

                TecnicosIDTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar al Tecnico. Verifique el ID.');</script>");
            }
        }
        protected void ModificarTecnico_Click(object sender, EventArgs e)
        {
            int TecnicoID;
            string NombreTech = NombreTechTextBox.Text;
            string Especialidad = EspecialidadTextBox.Text;
   

            if (!int.TryParse(TecnicosIDTextBox.Text, out TecnicoID))
            {
                Response.Write("<script>alert('El ID del Usuario debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.TecnicosLogica.ModificarTecnico(TecnicoID, NombreTech, Especialidad);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Tecnico modificado exitosamente.');</script>");
                LlenarGridTecnicos();


                TecnicosIDTextBox.Text = "";
                NombreTechTextBox.Text = "";
                EspecialidadTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Error al modificar los datos del Tecnico. Verifique los datos.');</script>");
            }
        }
    }
}
