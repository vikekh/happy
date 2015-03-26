using System;
using System.ComponentModel.DataAnnotations;

namespace Happy.Web.Models
{
    public class Emotion
    {
        public DateTime Created { get; set; }

        [Range(-2, 2)]
        public int Value { get; set; } 
    }
}