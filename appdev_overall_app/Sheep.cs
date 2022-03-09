using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_overall_app
{
    //class Sheep inherits class Animal // 80
    class Sheep : Animal
    {
        //variables unique to Sheep class
        public double sheep_amt_of_wool; //per day

        //Sheep constructor
        public Sheep(double water, double cost, double weight, int age, string color, double amt_wool)
           : base(water, cost, weight, age, color)
        {
            sheep_amt_of_wool = amt_wool;
        }
    }
}
