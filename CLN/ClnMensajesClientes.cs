using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using CEN.Campaigns.MensajesClientesPorRangoDeFechas;

namespace CLN
{
    public class ClnMensajesClientes
    {
        public List<MensajesClientesPorRangoDeFechasResponse> MensajesClientesPorRangoDeFechas(MensajesClientesPorRangoDeFechasRequest request)
        {
            CadMensajesClientes campaigns = new CadMensajesClientes();
            var response = campaigns.MensajesClientesPorRangoDeFechasResponse(request);
            return response;
        }
    }
}
