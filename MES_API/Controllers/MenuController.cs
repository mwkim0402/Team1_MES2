using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MES_DTO;
using MES_API.DAC;

namespace MES_API.Controllers
{
    [RoutePrefix("api/Menu")]
    public class MenuController : ApiController
    {
        /// <summary>
        /// 메뉴트리에 넣을 메뉴 목록을 가지고온다.
        /// </summary>
        /// <returns></returns>
        [Route("GetAllMenu")]
        // GET: api/Menu
        public List<MenuTreeVo> GetAllMenu()
        {
            MenuTreeDac dac = new MenuTreeDac();
            return dac.GetAllMenu();
        }

    }
}
