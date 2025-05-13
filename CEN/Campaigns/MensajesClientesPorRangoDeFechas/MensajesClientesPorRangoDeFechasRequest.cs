using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Campaigns.MensajesClientesPorRangoDeFechas
{
    public class MensajesClientesPorRangoDeFechasRequest
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
