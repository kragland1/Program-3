//Grading ID: R2226
//Program 3
//04/01/2022
//CIS 199-02
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //These are the arrays that are being used and established for the Program.
        string[] type = { "Premium", "Standard", "Discount" };
        double[] baseRate = { 1.1, 1, 0.9 };
        int[] number = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
        double[] cost = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };
        int[] discountRange = { 0, 6, 16, 21 };
        double[] discounts = { 1, 0.95, 0.90, 0.85 };
        
        private void flowerbutton_Click(object sender, EventArgs e)
        {
            //These are the variables that will be implemented for the project.
            int nums = 0;
            double flowerCost = 0;
            double based = 0;
            double perFlower = 0;
            double customer = 0;
            double baseA = 0;
            double total;
            int quantity = 0;
            bool flowerFound = false;
            bool numberCost = false;
            bool qtyFound = false;

            //This is the code for the combo box for the GUI application and it is done to count the arrays in the code
            for( int x = 0; x < type.Length && !flowerFound; ++x)
            {
                if(typeComboBox.SelectedIndex >= 0)
                {
                    if(typeComboBox.SelectedIndex == 1)
                    {
                        flowerFound = true;
                        based = 1.1;
                    }
                    else if(typeComboBox.SelectedIndex == 2)
                    {
                        flowerFound = true;
                        based = 1;
                    }
                    else
                    {
                        flowerFound= true;
                        based = 0.90;
                    }
                }
            }
            //This if-else statement is here just in case someone were to not make the bool variable true.
            if(flowerFound)
            {

            }
            else
            {
                MessageBox.Show("Error you may have to retype");
            }

            //This is a TryParse and a nested loop that involves the use of arrays for an output label.
            if (int.TryParse(entreeBox.Text, out nums) && nums > 10000 && nums < 10008)
            {
                for (int x = 0; x < number.Length && !numberCost; ++x)
                {
                    if(nums == number[x])
                    {
                        numberCost = true;
                        perFlower = cost[x];
                    }
                }
            }
            //This an if-else statement that is here just in case someone were not able to put in the correct information for the GUI.
            if(numberCost)
            {

            }
            else
            {
                MessageBox.Show("Error so retry");
            }
            //This int is here to help the if-else and nested loop statement down below.
            int index = discountRange.Length - 1; 
            //A TryParse that involves tha use of the a while loop for another textbox in the GUI but for discounts in the array.
            if(int.TryParse(quantityBox.Text, out quantity) && quantity >= 0)
            {
               while(index >= 0 && !qtyFound)
                {
                    if(quantity >= discountRange[index])
                    {
                        qtyFound = true;
                    }
                    else
                    {
                        --index;
                    }
                }
            }
            //This if-else statement is here for all the equations and output labels for the GUI and including an error message in case. 
            if(qtyFound)
            {
                customer = 1 - discounts[index];
                flowerCost = quantity * perFlower;
                baseA = flowerCost * based;
                total = baseA - (baseA * customer);
                outputFlowers.Text = $"{flowerCost:C2}";
                outputDiscount.Text = $"{customer:P}";
                outputBase.Text = $"{baseA:C2}";
                outputTotal.Text = $"{total:C2}";
            }
            else
            {
                MessageBox.Show("Error so retry");
            }






        }
    }
}
