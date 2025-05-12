using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using CEN.Campaigns.ActualizarEstadoCampania;
using CEN.Campaigns.ActualizarTotalesCampania;

namespace CLN
{
    public class ClnCampaignsActualizar
    {
        public ActualizarEstadoCampaniaResponse ActualizarEstadoCampania(ActualizarEstadoCampaniaRequest request)
        {
            CadCampaignsActualizar campaigns = new CadCampaignsActualizar();
            var response = campaigns.ActualizarEstadoCampaniaResponse(request);
            return response;
        }
    }
}
