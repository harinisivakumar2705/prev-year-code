using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_overall_app
{
    //class Dog inherits class Animal
    class Dog : Animal
    {
        //no variables unique to dog that's not already in Animal
        //Dog constructor
        public Dog(double d_water, double d_cost, double d_weight, int d_age, string d_color)
        : base(d_water, d_cost, d_weight, d_age, d_color)
        { }
    }
}
