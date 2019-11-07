using EPROCUREMENT.GAPPROVEEDOR.Business.Catalogo;
using EPROCUREMENT.GAPPROVEEDOR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EPROCUREMENT.GAPPROVEEDOR.Host.Http.Controllers
{
    [RoutePrefix("api/Catalogo")]
    public class CatalogoController : ApiController
    {
        // GET: api/Proveedor
        [HttpGet]
        [Route("PaisGetList")]
        public PaisResponseDTO Get()
        {
            HandlerCatalogo handlerCatalogo = new HandlerCatalogo();
            var paisResponseDTO = new PaisResponseDTO();
            paisResponseDTO = handlerCatalogo.GetPaisList();
            return paisResponseDTO;
        }

        // GET: api/Proveedor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Proveedor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Proveedor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Proveedor/5
        public void Delete(int id)
        {
        }
    }
}
