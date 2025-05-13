using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using CEN.Campaigns.ObtenerParticipacionUsuarios;

namespace CAD
{
    public class CadParticipacionUsuarios
    {
        public List<ObtenerParticipacionUsuariosResponse> ObtenerParticipacionUsuariosResponse(ObtenerParticipacionUsuariosRequest request)
        {
            SqlConnection _sqlConexion;
            AdConector _datosConexion = new();
            _sqlConexion = new SqlConnection(_datosConexion.getCadenaConexion());
            SqlCommand cmd;
            List<ObtenerParticipacionUsuariosResponse> response = new();
            try
            {
                _sqlConexion.Open();
                cmd = new SqlCommand("ObtenerParticipacionUsuariosPorCliente", _sqlConexion);
                cmd.Parameters.AddWithValue("@id_cliente", request.ClienteId);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response.Add(
                            new ObtenerParticipacionUsuariosResponse()
                            {
                                UsuarioId = Int32.Parse(reader["UsuarioId"].ToString()),
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                TotalMensajesExitososUsuario = Convert.ToInt32(reader["TotalMensajesExitososUsuario"]),
                                PorcentajeParticipacion = Double.Parse(reader["PorcentajeParticipacion"].ToString())

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
