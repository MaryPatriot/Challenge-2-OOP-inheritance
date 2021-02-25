using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_OOP_inheritance
{
    class Car: Vehicle
    {
        private string gear;

        public string Gear { get => gear; set => gear = value; }

        public Car(): base()
        {

        }
    }
}
