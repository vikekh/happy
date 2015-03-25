using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Happy.Web.Models
{
    public class Emotion
    {
        [Range(-2, 2)]
        public int Value { get; set; } 
    }
}