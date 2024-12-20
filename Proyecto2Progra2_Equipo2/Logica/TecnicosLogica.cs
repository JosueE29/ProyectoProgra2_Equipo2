using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Proyecto2Progra2_Equipo2.Logica
{
    public class TecnicosLogica
    {
        public static int AgregarTecnicos(int TecnicoID, string NombreTecnicos, string Especialidad)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {   
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ingresar_tecnico", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnico_id", TecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@nombre", NombreTecnicos));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", Especialidad));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int borrar_tecnico(int TecnicoID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borrar_tecnico", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnico_id", TecnicoID));  

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int ModificarTecnico(int TecnicoID, string NombreTecnicos, string Especialidad)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("modificar_tecnico", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@tecnico_id", TecnicoID));
                    cmd.Parameters.Add(new SqlParameter("@nombre", NombreTecnicos));
                    cmd.Parameters.Add(new SqlParameter("@especialidad", Especialidad));
                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }
            return retorno;
        }
    }
}
