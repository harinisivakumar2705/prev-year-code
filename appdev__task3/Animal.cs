using System;
using System.Collections.Generic;
using System.Text;

namespace appdev__task3
{
    abstract class Animal
    {
        private double _milk;

        public Animal ( double milk) 
        { 
            this._milk = milk;
        }
        
        
        public double getprofit(Prices p)
        {
            double profit = 0;
            if (this is Cow)
            {
                if (this is JerseyCow)
                {
                    profit = _milk * p.cowMilkPrice - p.costofvacJC; //amtofmilk * priceofmilk - cost of vac
                }
                else
                {
                    profit = _milk * p.cowMilkPrice - p.costofvacCow; //amtofmilk * priceofmilk - cost of vac
                }
            }
            else if (this is Goat)
            {
                profit = _milk * p.goatMilkPrice - p.costofvacGoat; //amtofmilk * priceofmilk - cost of vac
            }

            return profit;
        }

    }
}
