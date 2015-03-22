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
        public int PostEmotion(Emotion emotion)
        {
            return emotion.NormalizedValue;
        }
    }
}
