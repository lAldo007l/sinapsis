using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEN.Campaigns.ActualizarEstadoCampania;
using Service;

namespace CAD
{
    public class CadCampaignsActualizar
    {
        public ActualizarEstadoCampaniaResponse ActualizarEstadoCampaniaResponse(ActualizarEstadoCampaniaRequest request)
        {
            SqlConnection _sqlConexion;
            AdConector _datosConexion = new();
            _sqlConexion = new SqlConnection(_datosConexion.getCadenaConexion());
            SqlCommand cmd;
            ActualizarEstadoCampaniaResponse response = new();
            try
            {
                _sqlConexion.Open();
                cmd = new SqlCommand("ActualizarEstadoFinalCampania", _sqlConexion);
                cmd.Parameters.AddWithValue("@id_campania", request.CampaniaId);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response =
                            new ActualizarEstadoCampaniaResponse()
                            {
                                codigo = reader["codigo"].ToString()
                            }
                        ;
                    }
                }
                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                _sqlConexion.Close();
            }
        }
    }
}
