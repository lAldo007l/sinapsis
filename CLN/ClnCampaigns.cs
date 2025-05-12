using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using CEN.Campaigns.ActualizarTotalesCampania;

namespace CLN
{
    public class ClnCampaigns
    {
        public ActualizarTotalesCampaniaResponse ActualizarTotalesCampania(ActualizarTotalesCampaniaRequest request)
        {
            CadCampaigns campaigns = new CadCampaigns();
            var response = campaigns.ActualizarTotalesCampaniaResponse(request);
            return response;
        }

    }
}
