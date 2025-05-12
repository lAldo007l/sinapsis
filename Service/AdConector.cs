using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AdConector
    {
        public static string CadenaConexion { get; set; }
        public string getCadenaConexion()
        {
            CadenaConexionService cadenaConexion = new CadenaConexionService();
            var strCadenaConexion = cadenaConexion.ObtenerCadena();
            return strCadenaConexion;
        }
    }
}
