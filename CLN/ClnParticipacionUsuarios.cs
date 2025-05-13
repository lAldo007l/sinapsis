using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using CEN.Campaigns.ObtenerParticipacionUsuarios;

namespace CLN
{
    public class ClnParticipacionUsuarios
    {
        public List<ObtenerParticipacionUsuariosResponse> ObtenerParticipacionUsuarios(ObtenerParticipacionUsuariosRequest request)
        {
            CadParticipacionUsuarios campaigns = new CadParticipacionUsuarios();
            var response = campaigns.ObtenerParticipacionUsuariosResponse(request);
            return response;
        }
    }
}
