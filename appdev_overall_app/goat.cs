using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_overall_app
{
    //class goat inherits from Animal
    class goat : Animal
    {
        //variables unique to goat
        public double goat_amt_of_milk; //per day

        //goat constructor
        public goat(double water, double cost, double weight, int age, string color, double amt_milk)
            : base(water, cost, weight, age, color)
        {
            goat_amt_of_milk = amt_milk;  
        }
    }
}
