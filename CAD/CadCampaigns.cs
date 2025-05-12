using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEN.Campaigns.ActualizarTotalesCampania;
using Service;

namespace CAD
{
    public class CadCampaigns
    {
        public ActualizarTotalesCampaniaResponse ActualizarTotalesCampaniaResponse(ActualizarTotalesCampaniaRequest request)
        {
            SqlConnection _sqlConexion;
            AdConector _datosConexion = new();
            _sqlConexion = new SqlConnection(_datosConexion.getCadenaConexion());
            SqlCommand cmd;
            ActualizarTotalesCampaniaResponse response = new();
            try
            {
                _sqlConexion.Open();
                cmd = new SqlCommand("CalcularYActualizarTotalesCampania", _sqlConexion);
                cmd.Parameters.AddWithValue("@campania_id", request.CampaniaId);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response =
                            new ActualizarTotalesCampaniaResponse()
                            {
                                TotalMensajes = Int32.Parse(reader["TotalMensajes"].ToString()),
                                TotalEnviados = Int32.Parse(reader["TotalEnviados"].ToString()),
                                TotalPendientes = Int32.Parse(reader["TotalPendientes"].ToString()),
                                TotalFallidos = Int32.Parse(reader["TotalFallidos"].ToString())
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
