using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Place:Button
    {
        public string path_to_img;
        public double max_width;
        public double max_length;
        public bool free = true;
        public int? number;
        public Car?[] cars = new Car?[24] {null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        public int[] timetable = new int[24] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int get_number_of_free_hours(int start)
        {
            int co = 0;
            int i = start;
            while (i < 24 && timetable[i] != 1)
            {
                co++;
                i++;
            }
            return co;
        }
        public void book_hours (int start, int h, Car c)
        {
            for (int i=start; i<start+h;i++)
            {
                timetable[i] = 1;
                cars[i] = c;
            }
        }
    }
    internal class usual_Place:Place
    {
        public usual_Place()
        {
            max_length = 5;
            max_width = 2;
            path_to_img = "car.png";
        }
    }
    internal class cargo_Place:Place
    {
        public cargo_Place()
        {
            max_length = 15;
            max_width = 3.5;
            path_to_img = "cargo_car.png";
        }
    }
    internal class simple_place
    {
        public bool free = true;
        public int? number;
        public Car?[] cars = new Car?[24];
        public int[] timetable = new int[24];
    }
}
