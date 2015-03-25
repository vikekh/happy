using Happy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Happy.Web.Controllers
{
    public class EmotionsController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage PostEmotion([FromBody] Emotion emotion)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            return Request.CreateResponse(HttpStatusCode.Created, emotion);
        }
    }
}
