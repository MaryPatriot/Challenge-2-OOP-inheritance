using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_OOP_inheritance
{
    class Vehicle
    {
        private string steeringWheel;
        private string gasPedal;
        private string tires;

        public string SteeringWheel { get => steeringWheel; set => steeringWheel = value; }
        public string GasPedal { get => gasPedal; set => gasPedal = value; }
        public string Tires { get => tires; set => tires = value; }

        public Vehicle()
        {

        }

        
    }
}
