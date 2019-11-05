using EPROCUREMENT.GAPPROVEEDOR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EPROCUREMENT.GAPPROVEEDOR.Host.Http.Controllers
{
    [RoutePrefix("api/Proveedor")]
    public class ProveedorController : ApiController
    {
        // GET: api/Proveedor
        [HttpGet]
        [Route("GetList")]
        public List<Proveedor> Get()
        {
            Proveedor proveedor = new Proveedor
            {
                Nombre = "Mauricio",
                Giro = "Desarrollo"
            };
            List<Proveedor> proveedorList = new List<Proveedor>();
            proveedorList.Add(proveedor);
             return proveedorList;
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
