using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdev__task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prices price = new Prices();
            Animal[] animals = new Animal[10];

            // Get User Input
            price.cowMilkPrice = Convert.ToDouble(textBoxCowsMilk.Text);
            price.goatMilkPrice = Convert.ToDouble(textBoxGoatsMilk.Text);
            price.costofvacCow = Convert.ToDouble(textBoxCostOfVacCow.Text);
            price.costofvacGoat = Convert.ToDouble(textBoxCostOfVacGoat.Text);
            price.costofvacJC = Convert.ToDouble(textBoxCostOfVacJC.Text);

            // Read File
            using (TextReader reader = File.OpenText("test.txt"))
            {
                for (int i = 0; i <= 10; i++)
                {
                    string[] val = reader.ReadLine().Replace(" ", "").Split(",");
                    val[2] = val[2].Replace(".", ""); //remove fullstop at the end
                    if (val[2].ToLower() == "cow")
                    {
                        animals[i] = new Cow( Convert.ToDouble(val[1]));
                    }
                    else if (val[2].ToLower() == "goat")
                    {
                        animals[i] = new Goat(Convert.ToDouble(val[1]));

                    }
                    else if (val[2].ToLower() == "jersey_cow")
                    {
                        animals[i] = new JerseyCow( Convert.ToDouble(val[1]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
            }

            // Output
            double prof = 0;
            for(int i = 0; i<animals.Length; i++)
            {
                prof += animals[i].getprofit(price);
            }
            textBoxOutput.Text = Convert.ToString(prof);
        }

  
    }
}
