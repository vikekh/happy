using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Happy.Web.Models
{
    public class Emotion
    {
        public int NormalizedValue {
            get {
                return Value - 3;
            }
        }

        private int value;
        public int Value {
            get {
                if (value < 1)
                {
                    return 1;
                }
                else if (value > 5)
                {
                    return 5;
                }

                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}