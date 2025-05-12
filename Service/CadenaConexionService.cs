using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CadenaConexionService
    {
        public string ObtenerCadena() 
        {
            var CadenaConexion = "Server=DESKTOP-JH9SQQI\\SQLEXPRESS;Database=marketing_campaign;Integrated Security=True;Application Name=SinapsisPT.Api";
            return CadenaConexion;
        }
    }
}
