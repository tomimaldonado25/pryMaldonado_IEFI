using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMaldonado_IEFI
{
    public class clsUsuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Area { get; set; }
        public bool CambiarContraseña { get; set; }

        public int IdAuditoriaSesion { get; set; }
        public DateTime FechaAcceso { get; set; }

    }
}
