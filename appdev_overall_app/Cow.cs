using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_overall_app
{
    //class Cow inherits from Animal
    class Cow : Animal
    {
        //list of extra variables as per db
        public double cow_amt_of_milk; //per day
        public bool cow_is_jersy; //yes or no

        //Cow constructor
        public Cow(double c_water, double c_cost, double c_weight, int c_age, string c_color, double c_amt_milk, bool is_jersy ) 
            : base(c_water, c_cost, c_weight, c_age, c_color)
        {
            cow_amt_of_milk = c_amt_milk;
            cow_is_jersy = is_jersy;
        }
    }
}
