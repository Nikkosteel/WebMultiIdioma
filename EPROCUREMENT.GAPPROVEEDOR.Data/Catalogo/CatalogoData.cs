using EPROCUREMENT.GAPPROVEEDOR.Entities;
using EPROCUREMENT.GAPPROVEEDOR.Entities.Catalogo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPROCUREMENT.GAPPROVEEDOR.Data
{
    public class CatalogoData
    {
        private readonly TryCatchExecutor tryCatch;

        public CatalogoData()
        {
            tryCatch = new TryCatchExecutor();
        }
        /// <summary>
        /// Obtiene un listado de paises
        /// </summary>
        /// <returns>Un objeto de tipo PaisResponseDTO</returns>
        public PaisResponseDTO GetPaisList()
        {
            PaisResponseDTO response = new PaisResponseDTO()
            {
                Success = false,
                PaisList = new List<PaisDTO>()
            };

            PaisDTO pais = null;

            Func<PaisResponseDTO> action = () =>
            {

                using (var conexion = new SqlConnection(Helper.Connection()))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("[dbo].[usp_EPROCUREMENT_Pais_GETL]", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pais = new PaisDTO();
                        pais.IdPais = Convert.ToInt32(reader["IdPais"]);
                        pais.Nombre = reader["Pais"].ToString();
                        response.PaisList.Add(pais);
                    }
                }
                response.Success = true;
                return response;
            };

            return tryCatch.SafeExecutor(action);
        }
    }
}
