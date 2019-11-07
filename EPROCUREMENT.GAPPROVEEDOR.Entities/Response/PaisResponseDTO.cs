using System.Collections.Generic;

namespace EPROCUREMENT.GAPPROVEEDOR.Entities
{
    public class PaisResponseDTO: ResponseBaseDTO
    {
        public List<PaisDTO> PaisList { get; set; }
    }
}
