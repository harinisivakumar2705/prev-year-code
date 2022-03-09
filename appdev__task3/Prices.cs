using System;
using System.Collections.Generic;
using System.Text;

namespace appdev__task3
{
    class Prices
    {
        private double _cowMilkPrice;
        private double _goatMilkPrice;
        private double _costofvacCow;
        private double _costofvacJC;
        private double _costofvacGoat;

        public double cowMilkPrice
        {
            get { return _cowMilkPrice; }
            set { _cowMilkPrice = value; }
        }

        public double goatMilkPrice
        {
            get { return _goatMilkPrice; }
            set { _goatMilkPrice = value; }
        }
        public double costofvacCow
        {
            get { return _costofvacCow; }
            set { _costofvacCow = value; }
        }
        public double costofvacJC
        {
            get { return _costofvacJC; }
            set { _costofvacJC = value; }
        }
        public double costofvacGoat
        {
            get { return _costofvacGoat; }
            set { _costofvacGoat = value; }
        }

    }
}
