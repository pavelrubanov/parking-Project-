using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Car
    {
        public string model;
        public string gos_number;
        public double max_width;
        public double max_length;
    }

    public class Passenger_car : Car
    {
        public Passenger_car(string model, string gos_number)
        {
            this.model= model;
            this.gos_number = gos_number;
            max_length = 5;
            max_width = 2;
        }
    }

    public class Cargo_car : Car
    {
        public Cargo_car (string model, string gos_number)
        {
            this.model = model;
            this.gos_number = gos_number;
            max_length = 15;
            max_width = 3.5;
        }
    }
}
