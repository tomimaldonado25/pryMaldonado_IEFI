using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaldonado_IEFI
{
    public class clsUsuarioDatos
    {
        clsConexion conexion = new clsConexion();

        public clsUsuario ValidarLogin(string usuario, string contraseña)
        {
            clsUsuario encontrado = null;

            try
            {
                conexion.Abrir();

                string consulta = "SELECT * FROM Usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña AND Activo = Yes";

                OleDbCommand cmd = new OleDbCommand(consulta, conexion.conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                OleDbDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    encontrado = new clsUsuario
                    {
                        IdUsuario = Convert.ToInt32(lector["IdUsuario"]),
                        NombreUsuario = lector["NombreUsuario"].ToString(),
                        CambiarContraseña = Convert.ToBoolean(lector["CambiarContraseña"]),
                        Area = lector["Area"].ToString(),
                        // Podés agregar más campos si los necesitás
                    };
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return encontrado;
        }
    }

}

