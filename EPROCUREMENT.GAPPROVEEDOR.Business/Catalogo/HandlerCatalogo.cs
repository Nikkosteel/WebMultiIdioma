using EPROCUREMENT.GAPPROVEEDOR.Data;
using EPROCUREMENT.GAPPROVEEDOR.Entities;
using EPROCUREMENT.GAPPROVEEDOR.Entities.Comun;
using System.Collections.Generic;

namespace EPROCUREMENT.GAPPROVEEDOR.Business.Catalogo
{
    public class HandlerCatalogo
    {
        private readonly CatalogoData catalogoData;
        //  private readonly InputDataValidator inputDataValidator;
        /// <summary>
        /// Constructor para la inicializacion de los accesos a datos
        /// </summary>
        /// <param name="client">Acceso a datos de tarjetas</param>
        public HandlerCatalogo()
        {
            catalogoData = new CatalogoData();
        }

        /// <summary>
        /// Metodo para obtener una lista de paises
        /// </summary>
        /// <param name="request">Peticion para obtener la lista de tarjetas</param>
        /// <returns></returns>
        public PaisResponseDTO GetPaisList()
        {
            PaisResponseDTO response = new PaisResponseDTO()
            {
                Success = false,
                PaisList = new List<PaisDTO>()
            };

            response = catalogoData.GetPaisList();
            response.Success = true;
            if (!response.Success)
            {
                response.ErrorList = new List<ErrorDTO> { new ErrorDTO { Codigo = "", Mensaje = string.Format("No fue posible recuperar datos disponibles o no se encontro alguna solicitud en proceso") } };
            }
            return response;
        }
    }
}
