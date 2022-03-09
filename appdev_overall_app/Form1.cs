using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdev_overall_app
{
    public partial class Form1 : Form
    {
        static IDictionary<int, Animal> animalValues;
        static Prices objprices;
        

        public Form1()
        {
            InitializeComponent();
        } 

        //Report 1 - displays animal information that corresponds to user ID
        private void button1_Click(object sender, EventArgs e)
        {
            int input_id = Int32.Parse(textBox1.Text);
            //see keypress for method to only allow int values
            //if statement to check if id matches db value
            //info() is a method in class Animal that returns animal information

            if (animalValues.ContainsKey(input_id))
            {
                textBox2.Text = animalValues[input_id].info();
            }
            else
            {
                textBox2.Text = "id not found";
            }
        }
        
        //displays all reports on load
        private void Form1_Load(object sender, EventArgs e)
        {
            getAllData(); //method to get data
            print_profitability(); //report 2
            print_totaltax(); //report 3
            print_totalmilkperday(); //report 4
            average_age(); //report 5
            print_profitcompare(); //report 6
            print_comparecost(); //report 7
            print_animalsinorder(); //report 8
            print_ratioffred(); //report 9
            print_taxbyjersycows(); //report 10
            print_profitabilityofjersycows(); //report 12

           
            
            
        }

        //get all data gets data from the database and sends it to a data dictionary. this method is called on load
        public void getAllData()
        {
            //initialising animalValues dictionary
            animalValues = new Dictionary<int, Animal>();

            //creating new instance of class Prices
            objprices = new Prices();

            //OleDB connection to connect to the database
            OleDbConnection conn = new OleDbConnection();

            //connection string with file path
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\skyis\\Downloads\\FarmInfomation (1).accdb ";
            //opening connection
            conn.Open();

            /*retreiving data from table cows
             * cmd_cow executes the select statement
             reader is a data reader that reads data 
            the while statement creates variables and type casts the value from the table to the variable*/
            OleDbCommand cmd_cow = new OleDbCommand("SELECT * from Cows ", conn);
            OleDbDataReader reader = cmd_cow.ExecuteReader();
            while (reader.Read())
            {
                int index = reader.GetInt16(0);
                double cows_water = System.Convert.ToDouble(reader.GetDouble(1));
                double cows_cost = System.Convert.ToDouble(reader.GetDouble(2));
                double cows_weight = System.Convert.ToDouble(reader.GetDouble(3));
                Int32 cows_age = System.Convert.ToInt32(reader.GetInt16(4));
                string cows_color = System.Convert.ToString(reader.GetString(5));
                double cows_amountofmilk = System.Convert.ToDouble(reader.GetDouble(6));
                bool is_jersy = System.Convert.ToBoolean(reader.GetBoolean(7));
                animalValues.Add(index, new Cow(cows_water, cows_cost, cows_weight, cows_age, cows_color, cows_amountofmilk, is_jersy));
            }

            /*retreiving data from table dogs
            * cmd_dogs executes the select statement
            reader is a data reader that reads data 
           the while statement creates variables and type casts the value from the table to the variable*/
            OleDbCommand cmd_dogs = new OleDbCommand("SELECT * from Dogs ", conn);
            reader = cmd_dogs.ExecuteReader();
            while (reader.Read())
            {
                int index = reader.GetInt32(0);
                double dogs_water = System.Convert.ToDouble(reader.GetDouble(1));
                double dogs_weight = System.Convert.ToDouble(reader.GetDouble(2));
                int dogs_age = System.Convert.ToInt32(reader.GetInt16(3));
                string dogs_color = System.Convert.ToString(reader.GetString(4));
                double dogs_cost = System.Convert.ToDouble(reader.GetDouble(5));

                animalValues.Add(index, new Dog(dogs_water, dogs_cost, dogs_weight, dogs_age, dogs_color));


            }

            /*retreiving data from table goats
            * cmd_goats executes the select statement
            reader is a data reader that reads data 
           the while statement creates variables and type casts the value from the table to the variable*/
            OleDbCommand cmd_goats = new OleDbCommand("SELECT * from Goats ", conn);
            reader = cmd_goats.ExecuteReader();
            while (reader.Read())
            {
                int index = reader.GetInt32(0);
                double goats_water = System.Convert.ToDouble(reader.GetDouble(1));
                double goats_cost = System.Convert.ToDouble(reader.GetDouble(2));
                double goats_weight = System.Convert.ToDouble(reader.GetDouble(3));
                int goats_age = System.Convert.ToInt32(reader.GetInt16(4));
                string goats_color = System.Convert.ToString(reader.GetString(5));
                double goats_amountofmilk = System.Convert.ToDouble(reader.GetDouble(6));

                animalValues.Add(index, new goat(goats_water, goats_cost, goats_weight, goats_age, goats_color, goats_amountofmilk));


            }

            /*retreiving data from table sheep
            * cmd_sheep executes the select statement
            reader is a data reader that reads data 
           the while statement creates variables and type casts the value from the table to the variable*/
            OleDbCommand cmd_sheep = new OleDbCommand("SELECT * from Sheep ", conn);
            reader = cmd_sheep.ExecuteReader();
            while (reader.Read())
            {



                int index = System.Convert.ToInt32(reader.GetInt16(0));
                double sheep_water = System.Convert.ToDouble(reader.GetDouble(1));
                double sheep_cost = System.Convert.ToDouble(reader.GetDouble(2));
                double sheep_weight = System.Convert.ToDouble(reader.GetDouble(3));
                int sheep_age = System.Convert.ToInt32(reader.GetInt16(4));
                string sheep_color = System.Convert.ToString(reader.GetString(5));
                double sheep_amountofwool = System.Convert.ToDouble(reader.GetDouble(6));

                animalValues.Add(index, new Sheep(sheep_water, sheep_cost, sheep_weight, sheep_age, sheep_color, sheep_amountofwool));


            }

            /*retreiving data from table Commodity prices
            * cmd_prices executes the select statement
            reader is a data reader that reads data 
           the while statement assigns value from db and initialises the class Prices*/
            OleDbCommand cmd_prices = new OleDbCommand("SELECT * from [Commodity Prices]", conn);
            reader = cmd_prices.ExecuteReader();
            while (reader.Read())
            {
                //category variable is to see what category the price is
                String category = reader.GetString(0).ToUpper();

                //value variable is the price value from commodity prices
                double value = reader.GetDouble(1);

                if (category.CompareTo("GOAT MILK PRICE") == 0)
                {
                    objprices.goat_milk_price = value;
                }
                else if (category.CompareTo("SHEEP WOOL PRICE") == 0)
                {
                    objprices.sheep_wool_price = value;
                }
                else if (category.CompareTo("WATER PRICE") == 0)
                {
                    objprices.water_price = value;
                }
                else if (category.CompareTo("GOVERNMENT TAX PER KG") == 0)
                {
                    objprices.tax = value;                   
                }
                else if (category.CompareTo("JERSY COW TAX") == 0)
                {
                    objprices.jersy_cow_tax = value;
                }
                else if (category.CompareTo("COW MILK PRICE") == 0)
                {
                    objprices.cow_milk_price = value;
                }

            }
            //Console.WriteLine("cow milk price: "+ objprices.cow_milk_price + "goat milk price" + objprices.goat_milk_price + "jersy cow tax:" + objprices.jersy_cow_tax + "sheep wool price: " + objprices.sheep_wool_price + "goverment tax:" + objprices.tax + "water price:" + objprices.water_price);
            reader.Close();
        }
        
        //Keypress helps filter inputs to only integers
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        //prints profitability/loss of farm per day
        private void print_profitability()
            {
                //Report number 2 - display total profitability or loss
                //adding dictionary values to list as method parameter only takes list values
                List<Animal> animalvalues_list = animalValues.Values.ToList<Animal>();

                //return statement returns profit/loss value, adds a dollar sign in front and filters decimal value to only 2 places
                textBox3.Text = "$" + objprices.calc_profitorloss(animalvalues_list).ToString("#.##"); 
            }

        //prints total tax paid per month
        private void print_totaltax()
        { 
            //Report number 3 - display total tax paid to goverment per month
            //adding values to a list as method parameters only take list values
            List<Animal> animalvalues_list = animalValues.Values.ToList<Animal>();

            //return statement returns total tax paid, adds a dollar sign in front and filters decimal value to only 2 places
            textBox4.Text = "$" + objprices.calc_tax(animalvalues_list).ToString("#.##");
        }
        
        //prints total milk per day for cows and goats
        private void print_totalmilkperday()
        {
            //Report number 4 - display total amount of milk per day of cows of goats
            List<Animal> animalvalues_list = animalValues.Values.ToList<Animal>();

            //return statement returns total milk, adds a dollar sign in front and filters decimal value to only 2 places
            textBox5.Text = objprices.amtofmilk(animalvalues_list).ToString("#.##") + " Litres/per day";
        }
        
        //method to find average age of all animals excluding dogs
        public void average_age()
        {
            //Report 5 - display average age of all animals excluding dogs
            //age variable to store age in years
            int age = 0;

            //foreach loop to increment age variable
            foreach (KeyValuePair<int, Animal> kvp in animalValues)
            {
                //if loop to exclude dogs
                if(kvp.GetType() == typeof(Dog))
                {
                    continue;
                }

                //statement to increment age value
                else
                age += kvp.Value.age;
            }

            //dividing age by number of values to get average
            age = age / animalValues.Count();
            textBox6.Text = age + " years";

        } 

        //method to display ratio for goats and cows vs sheep
        private void print_profitcompare()
        {
            //Report number 6 - Display the average profitability of “Goats and Cow” Vs. Sheep
            //making lists to hold values as methods used only take list parameters
            List<Animal> cows_goats = new List<Animal>();
            List<Animal> sheep = new List<Animal>();

            //foreach loop to add values to lists
            foreach (KeyValuePair<int, Animal> kvp in animalValues)
            {   
                //if and else if statements to seperate cows & goats list from sheep list
                if(kvp.Value.GetType() == typeof(Sheep))
                {
                    sheep.Add(kvp.Value);
                }
                else if(kvp.Value.GetType() == typeof(Cow) || kvp.Value.GetType() == typeof(goat))
                {
                    cows_goats.Add(kvp.Value);
                }
            }
            //statement calling methods to print profit/loss made from corresponding animals
            textBox7.Text = string.Format("{0:0.00} VS {1:0.00}", 
                objprices.calc_profitorloss(cows_goats), objprices.calc_profitorloss(sheep));

            }

        //method to generate file that contains the ID of all animal ordered by their profitability
        //excluding dogs
        private void print_animalsinorder()
        {
            //Report 8 - Generate a file that contains the ID of all animal ordered by their profitability         
            //creating lists to store animal ID & profit
            List<int> animals_ids = new List<int>();
            List<double> animals_profit = new List<double>();

            //foreach loop to add values to corresponding lists 
            foreach(KeyValuePair<int, Animal> kvp in animalValues)
            {
                //excluding dogs
                if(kvp.Value.GetType() != typeof(Dog))
                {
                    //temp injection variable
                    List<Animal> temp = new List<Animal>();
                    
                    //adding values to animal IDs
                    temp.Add(kvp.Value);
                    animals_ids.Add(kvp.Key);

                    //using method from class Prices to calculate profit/loss
                    animals_profit.Add(objprices.calc_profitorloss(temp));
                }
            }
            //file path
            string path = @"C:\Users\skyis\source\repos\appdev_overall_app\report8.txt";

            //using streamwriter to create and write to file
            using (StreamWriter writer = new StreamWriter(path))
            {
                //foreach loop to write sorted values to file
                foreach(int key in bubble_sort(animals_ids, animals_profit))
                {
                    //writeline is used to write values one per line
                    writer.WriteLine(key.ToString());
                }
            }
        }

        //bubble sort
        private List<int> bubble_sort(List<int> keys, List<double> sortby)
        {
            //bool variable to assume lists are not sorted
            bool sorted = false;

            //while loop to sort
            while (!sorted)
            {
                //loop exits when there's no swaps
                sorted = true;

                //for loop to loop through list values
                for (int i =0; i<sortby.Count - 1; i++)
                {   
                    //if statement to check if list[1] < list[2] 
                    if(sortby[i] > sortby[i + 1])
                    {
                        //if  list[1] > list[2] then we set sorted to false
                        sorted = false;

                        //swapping sortby values
                        double temp = sortby[i];
                        sortby[i] = sortby[i + 1];
                        sortby[i + 1] = temp;

                        //swapping keys values simultaneously
                        int temp1 = keys[i];
                        keys[i] = keys[i + 1];
                        keys[i + 1] = temp1;
                    }
                }
            }
            foreach(double profitability in sortby)
            {
                double profit = profitability;
               // return profit;
                
            }
            
            //we return only keys as report only needs IDs in order of profitability
            return keys;
            
        }
       

        //method to display ratio of dogs' cost vs total cost
        private void print_comparecost()
        {
            //Report 7 - Display the ratio of Dogs’ cost compared to the total cost 5
            //lists to store values from dictionary as methods parameters only take list values
            List<Animal> dogs_cost = new List<Animal>();
            List<Animal> all_cost = new List<Animal>();

            //foreach loop to add values to corresponding lists
            foreach (KeyValuePair<int, Animal> kvp in animalValues)
            {
                //adds values to all_cost list
                all_cost.Add(kvp.Value);

                //adds values to dog_cost list
                if (kvp.Value.GetType() == typeof(Dog))
                {
                    dogs_cost.Add(kvp.Value);
                }

            }
            //printing to textbox
            textBox8.Text = string.Format("{0} vs {1}", objprices.calc_cost(dogs_cost), objprices.calc_cost(all_cost)  );
        }

        //method to display ratio of livestock with color red
        private void print_ratioffred()
        {
            //Report 9 - Display the ratio of livestock with the color red
            //ratio variable
            int ratio_of_red = 0;

            //foreach loop to check color value and increment ratio
            foreach(KeyValuePair<int, Animal> kvp in animalValues)
            {
                if (kvp.Value.color.ToUpper() == "RED")
                {
                    ratio_of_red++;

                }
                //else skip
                else continue;
            }
            //printing to textbox
            textBox9.Text = ratio_of_red.ToString();
        }

        //method to display total tax paid by jersy cows
        private void print_taxbyjersycows()
        {
            //Report 10 - Display the total tax paid for Jersey Cows 
            //list to store jersycow values as method can only take list parameters
            List<Animal> jersycows = new List<Animal>();

            //foreach loop to store values in jersycows list
            foreach(KeyValuePair<int, Animal> kvp in animalValues)
            {
                //if statement to check if type is Cow
                if(kvp.Value.GetType() == typeof(Cow))
                {
                    Cow temp = (Cow)kvp.Value;
                    //if statement to check if cow is jersy cow
                    if (temp.cow_is_jersy)
                    {
                        jersycows.Add(kvp.Value);
                    }
                }
            }
            //printing to textbox
            textBox10.Text = "$" + objprices.calc_tax(jersycows);
        }

        //method to take a threshold (number of years)
        //and method returns ratio of the number of animal farm where the age is above this threshold
        private void button2_Click(object sender, EventArgs e)
        {
            //Report 11 - The user enter a threshold (number of years), and the program displays the
            //ratio of the number of animal farm where the age is above this threshold.

            //getting user input from text box
            int input_age = Int32.Parse(textBox11.Text);

            //counter variable to count number of animals
            int counter = 0;

            //foreach loop to read data dictionary and increment counter
            foreach(KeyValuePair<int, Animal> kvp in animalValues)
            {
                //if statement to increment counter if age is above threshold
                if(kvp.Value.age > input_age)
                {
                    counter++;
                }
            }
            //printing to textbox
            textBox12.Text = counter.ToString();
            
        }

        //method to display profitability of Jersy cows
        private void print_profitabilityofjersycows()
        {
            //Report 12 - Display the total profitability made by jersy cows
            //list to store jersycow values as method can only take list parameters
            List<Animal> jersycows = new List<Animal>();

            //foreach loop to store values in jersycows list
            foreach (KeyValuePair<int, Animal> kvp in animalValues)
            {
                //if statement to check if type is Cow
                if (kvp.Value.GetType() == typeof(Cow))
                {
                    Cow temp = (Cow)kvp.Value;
                    //if statement to check if cow is jersy cow
                    if (temp.cow_is_jersy)
                    {
                        jersycows.Add(kvp.Value);
                    }
                }
            }
            //printing to textbox
            textBox13.Text = "$" + objprices.calc_profitorloss(jersycows).ToString("#.##");
        }
    }
}
