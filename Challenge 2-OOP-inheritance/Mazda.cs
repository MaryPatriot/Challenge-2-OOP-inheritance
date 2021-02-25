using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_OOP_inheritance
{
    class Mazda: Car
    {
        private string steeingWheelWarmer;

        public string SteeingWheelWarmer { get => steeingWheelWarmer; set => steeingWheelWarmer = value; }

        public Mazda(): base()
        {

        }
    }
}
