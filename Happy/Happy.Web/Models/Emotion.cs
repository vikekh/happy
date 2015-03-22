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

        private int _value;
        public int Value {
            get {
                if (_value < 1)
                {
                    return 1;
                }
                else if (_value > 5)
                {
                    return 5;
                }

                return _value;
            }

            set
            {
                _value = value;
            }
        }
    }
}