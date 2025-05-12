using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Campaigns.ActualizarTotalesCampania
{
    public class ActualizarTotalesCampaniaResponse
    {
        public int TotalMensajes { get; set; }
        public int TotalEnviados { get; set; }
        public int TotalPendientes { get; set; }
        public int TotalFallidos { get; set; }
    }
}
