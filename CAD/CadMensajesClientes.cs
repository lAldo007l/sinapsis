using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using CEN.Campaigns.MensajesClientesPorRangoDeFechas;

namespace CAD
{
    public class CadMensajesClientes
    {
        public List<MensajesClientesPorRangoDeFechasResponse> MensajesClientesPorRangoDeFechasResponse(MensajesClientesPorRangoDeFechasRequest request)
        {
            SqlConnection _sqlConexion;
            AdConector _datosConexion = new();
            _sqlConexion = new SqlConnection(_datosConexion.getCadenaConexion());
            SqlCommand cmd;
            List<MensajesClientesPorRangoDeFechasResponse> response = new();
            try
            {
                _sqlConexion.Open();
                cmd = new SqlCommand("ObtenerClientesMensajesExitososPorRangoDeFechas", _sqlConexion);
                cmd.Parameters.AddWithValue("@fecha_inicio", request.FechaInicio);
                cmd.Parameters.AddWithValue("@fecha_fin", request.FechaFin);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response.Add(
                            new MensajesClientesPorRangoDeFechasResponse()
                            {
                                NombreCliente = reader["NombreCliente"].ToString(),
                                TotalMensajesExitosos = Convert.ToInt32(reader["TotalMensajesExitosos"])
                            })
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
