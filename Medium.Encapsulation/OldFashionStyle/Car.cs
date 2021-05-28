using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Encapsulation.OldFashionStyle
{
    public class Car
    {
        private string _color;

        public string Color
        {
            get
            {
                // Any logic
                return _color;
            }
            set
            {
                // Any logic
                _color = value;
                // Any logic
            }
        }
    }
}
