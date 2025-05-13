using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Campaigns.ObtenerParticipacionUsuarios
{
    public class ObtenerParticipacionUsuariosResponse
    {
        public int UsuarioId { get; set; }

        public string NombreUsuario { get; set; }

        public int TotalMensajesExitososUsuario { get; set; }

        public double PorcentajeParticipacion { get; set; }
    }
}
