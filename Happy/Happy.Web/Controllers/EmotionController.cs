﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Happy.Web.Controllers
{
    public class EmotionController : ApiController
    {
        public async Task<int> AddEmotion(int emotion)
        {
            return emotion;
        }
    }
}
