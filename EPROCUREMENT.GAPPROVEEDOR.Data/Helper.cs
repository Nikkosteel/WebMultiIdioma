using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROCUREMENT.GAPPROVEEDOR.Data
{
    public static class Helper
    {
        /// <summary>
        /// Regresa la conexion a base de datos
        /// </summary>
        /// <returns></returns>
        public static string Connection()
        {
            return ConfigurationManager.ConnectionStrings["GAPProveedoresConnectionString"].ToString();
        }


    }
}
