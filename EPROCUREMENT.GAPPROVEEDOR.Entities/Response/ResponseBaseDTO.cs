using EPROCUREMENT.GAPPROVEEDOR.Entities.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROCUREMENT.GAPPROVEEDOR.Entities
{
    public class ResponseBaseDTO
    {
        /// <summary>
        /// Hace referencia al la bandera que indica si el servicio se ejecuto de forma correcta.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Hace referencia a la lista de errores.
        /// </summary>
        public List<ErrorDTO> ErrorList { get; set; }
    }
}
