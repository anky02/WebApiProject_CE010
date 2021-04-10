using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELSystem.Controllers
{
   
    public class MediaController : ApiController
    {
        EmployeeEntities1 entities1 = new EmployeeEntities1();
        public HttpResponseMessage GetMediaPlaylist()
        {
            try
            {
                var playlist = entities1.MediaTBs;
                return Request.CreateResponse(HttpStatusCode.OK, playlist, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.OK, ex.Message, Configuration.Formatters.JsonFormatter);
            }
        }

    }

}
