using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Encapsulation.StateProtection
{
    public class Car
    {
        private string _color;

        public Car(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }
    }
}
