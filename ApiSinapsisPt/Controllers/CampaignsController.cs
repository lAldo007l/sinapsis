using CEN.Campaigns.ActualizarEstadoCampania;
using CEN.Campaigns.ActualizarTotalesCampania;
using CLN;
using Microsoft.AspNetCore.Mvc;

namespace ApiSinapsisPt.Controllers
{
    [Route("[controller]")]
    public class CampaignsController : Controller
    {
        [HttpGet("ObtenerTotalCampaigns/{id}")]
        public IActionResult ObtenerTotalCampaigns(int id)
        {
            ActualizarTotalesCampaniaRequest request = new()
            {
                CampaniaId = id
            };
            ClnCampaigns ClnCampaigns = new();
            var response = ClnCampaigns.ActualizarTotalesCampania(request);
            return Ok(response);
        }

        [HttpGet("ActualizarEstadoCampaigns/{id}")]
        public IActionResult ActualizarEstadoCampaigns(int id)
        {
            ActualizarEstadoCampaniaRequest request = new()
            {
                CampaniaId = id
            };
            ClnCampaignsActualizar ClnCampaigns = new();
            var response = ClnCampaigns.ActualizarEstadoCampania(request);
            return Ok(response);
        }
    }

}
