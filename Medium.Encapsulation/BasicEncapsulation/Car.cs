using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Encapsulation.BasicEncapsulation
{
    public class Car
    {
        private string _color;

        public Car(string color)
        {
            _color = color;
        }

        public void Repaint(string color)
        {
            _color = color;
        }
    }
}
