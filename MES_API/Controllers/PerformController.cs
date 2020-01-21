using MES_API.DAC.Perform;
using MES_API.Models.Perform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MES_API.Controllers
{
    [RoutePrefix("api/Perform")]
    public class PerformController : ApiController
    {
        [HttpGet]
        [Route("ProductList")]
        //GET: api/Menu
        public List<ProductListVO> ProductList()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetProductListform();
        }
    }
}
