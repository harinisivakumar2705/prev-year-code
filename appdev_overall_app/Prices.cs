 //using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace appdev_overall_app
{
    //class Prices is stand alone as per db design
    class Prices 
    {
        //variables to hold db values accordingly
        public double goat_milk_price; //per litre      
        public double sheep_wool_price; //per kg
        public double water_price; //in cube
        public double tax; //per kg, per day (not including dogs)
        public double jersy_cow_tax; //per kg, per day
        public double cow_milk_price; //per litre

        //Prices constructor
        public Prices(double goat_milkprice, double sheep_woolprice, double waterprice, double _tax, double jersycow_tax, double cow_milkprice)
        {
            goat_milk_price = goat_milkprice;
            sheep_wool_price = sheep_woolprice;
            water_price = waterprice;
            tax = _tax;
            jersy_cow_tax = jersycow_tax;
            cow_milk_price = cow_milkprice;
        }

        //empty constructor to create objects
        public Prices() { }

        //method to calculate income made in total per day
        public double calc_income(List<Animal> animals)
        {
            double income = 0.0;
            double cow_income = 0.0;
            double goat_income = 0.0;
            double sheep_income = 0.0;
            //foreach statement to read all values and increment income accordingly
            foreach (Animal i in animals)
            {
                if (i.GetType() == typeof(Cow))
                {
                    //temp variable to read Cow values
                    Cow temp = (Cow)i;

                    //checking if Cow is Jersy cow or not and applying different tax accordingly
                    if ((temp.cow_is_jersy) == false)
                    {
                        cow_income += cow_milk_price * temp.cow_amt_of_milk - ((cow_milk_price * temp.cow_amt_of_milk) * tax);
                    }
                    else if ((temp.cow_is_jersy) == true)
                    {
                        cow_income += cow_milk_price * temp.cow_amt_of_milk - ((cow_milk_price * temp.cow_amt_of_milk) * jersy_cow_tax);
                    }
                }
                if (i.GetType() == typeof(goat))
                {
                    goat temp = (goat)i;
                    goat_income += goat_milk_price * temp.goat_amt_of_milk - ((goat_milk_price * temp.goat_amt_of_milk) * tax);
                }
                if (i.GetType() == typeof(Sheep))
                {
                    Sheep temp = (Sheep)i;
                    sheep_income += sheep_wool_price * temp.sheep_amt_of_wool - ((goat_milk_price * temp.sheep_amt_of_wool) * tax);
                }

            }
            income = cow_income + goat_income + sheep_income;
            return income;
        }

        //method to calculate total cost to maintain an animal per day
        public double calc_cost(List<Animal> animals)
        {
            double totalcost = 0.0;
            //foreach statement to loop through Animal values
            foreach (Animal i in animals)
            {
                //product of water price and amount gives us cost of water per day
                totalcost += water_price * i.amt_of_water;

                //increments total cost by daily cost
                totalcost += i.daily_cost;
            }

            return totalcost;
        }

        //calculate profitability or loss as per report 2
        public double calc_profitorloss(List<Animal> animals)
        {
            //variables to assign income and cost from their respective methods
            double inc = calc_income(animals);
            double cost = calc_cost(animals);

            //profit or loss can be calculated by subtracting the cost from income made per day
            double profitorloss = inc - cost;
            return profitorloss;
        }

        //method to calculate tax paid per month according to report 3
        public double calc_tax(List<Animal> animals)
        {
            double taxpermonth = 0.0;
            //foreach statement to loop through animal values as per their type
            foreach (Animal i in animals)
            {
                if (i.GetType() == typeof(Cow))
                {
                    Cow temp = (Cow)i;

                    //checking if cow is jersy cow and applying seperate tax value
                    if (temp.cow_is_jersy == false)
                    {
                        taxpermonth += cow_milk_price * temp.cow_amt_of_milk * tax;
                    }
                    if (temp.cow_is_jersy == true)
                    {
                        taxpermonth += cow_milk_price * temp.cow_amt_of_milk * jersy_cow_tax;
                    }
                }
                if (i.GetType() == typeof(goat))
                {
                    goat temp = (goat)i;
                    taxpermonth += goat_milk_price * temp.goat_amt_of_milk * tax;

                }
                if (i.GetType() == typeof(Sheep))
                {
                    Sheep temp = (Sheep)i;
                    taxpermonth += sheep_wool_price * temp.sheep_amt_of_wool * tax;
                }


            }
            //so far we have only calculated tax per day as all values are per day.
            //we multiply by 30 for a month 
            taxpermonth = taxpermonth * 30;
            return taxpermonth;
        }

        //method to calculate amount of milk for cows and goats
        public double amtofmilk(List<Animal> animals)
        {
            //individual variables whose value will be added up in the end
            double amtofmilk_cows = 0.0;
            double amtofmilk_goats = 0.0;

            //foreach loop to find individual values
            foreach (Animal i in animals)
            {
                //if statement to calculate total amount of milk from cow
                if (i.GetType() == typeof(Cow))
                {
                    Cow temp = (Cow)i;
                    amtofmilk_cows += temp.cow_amt_of_milk;

                }
                ////if statement to calculate total amount of milk from cow
                else if (i.GetType() == typeof(goat))
                {
                    goat temp_g = (goat)i;
                    amtofmilk_goats += temp_g.goat_amt_of_milk;

                }
            }

            //calculating total amount of milk and returning it
            double total_amtofmilk = amtofmilk_cows + amtofmilk_goats;
            return total_amtofmilk;
        }


    }
}
