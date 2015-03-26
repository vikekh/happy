using Happy.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Happy.Web.Controllers
{
    public class EmotionsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetEmotions()
        {
            return Request.CreateResponse(new List<Emotion>());
        }

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
