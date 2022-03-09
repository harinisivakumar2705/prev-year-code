using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdev_overall_app
{
    //abstract class animal cannot have any instances as animals have to belong to a sub class
    abstract class Animal
    {
        //list of variables as per db
        public double amt_of_water;
        public double daily_cost;
        public double weight;
        public int age;
        public string color;

        //Animal constructor 
        public Animal(double a_water, double a_cost, double a_weight, int a_age, string a_color)
        {
            amt_of_water = a_water;
            daily_cost = a_cost;
            weight = a_weight;
            age = a_age;
            color = a_color;
        }

        //getter-setter method Values
        public object Values { get; internal set; }

        //info() displays all animal information as required
        public string info()
        {
            string animal_type = System.Convert.ToString(this.GetType().Name); //gets class name as a type and converts to string
            return String.Format("Animal Type: {0}, water: {1}, daily cost: {2}, weight: {3}, age:{4}, color;{5}", animal_type, amt_of_water, daily_cost, weight, age, color);
        }
  }
}
