using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaldonado_IEFI
{
   
    public class clsConexion
    {
        public OleDbConnection conexion;

        public clsConexion()
        {
            string rutaBD = "sistemausuarios.accdb";
            string cadenaConexion = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaBD}";
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void Abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void Cerrar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
