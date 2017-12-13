using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasonMellingerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] calculator = new double[] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};     //array to hold the value of number
        double calculatorValue = 0;                                             //variable to hold value of calculator
        double sourceNumber = 0;                                                //number to hold a number in memory
        double storedNumber = 0;                                                //number used for memory storage
        int function = -1;                                                      //variable to choose function in switch statement
        string decimalValue = "";                                               //hold variable when decimal is called
        Boolean isDecimal = false;                                              //variable to decide if decimal situation needs to be applied

        public void enterNumber(double x)                                       //function to enter number into calculator
        {
            if (isDecimal == false)                                             //normal protocal
            {
                for (int i = 9; i >= 0; i--)                                    //iterate through calculator array
                {
                    if (calculator[i] == -1)                                    //if there isn't already a number there
                    {
                        calculator[i] = x;                                      //put that number in that part of the calculator
                        break;
                    }
                }

                convertToNumber();                                              //update value

                textBox1.Text = calculatorValue.ToString();                     //put value in textbox
            }
            if (isDecimal == true)                                              //decimal protocal
            {
                decimalValue = decimalValue + x.ToString();                     //append new value to decimal
                calculatorValue = Convert.ToDouble(decimalValue);               //update calculatorValue
                textBox1.Text = decimalValue;
            }
        }

        public void convertToNumber()                                       //function to convert array to variable number
        {
            int placeValue = 1;                                             //variable to help convert

            double calcValue = 0;

            for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator
            {
                if (calculator[i] != -1)
                {
                    calcValue = calcValue + (placeValue * calculator[i]);    //multiply that place value and add it

                    placeValue = placeValue * 10;                               //increment place value
                }
            }

            calculatorValue = calcValue;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            enterNumber(0);                                                 //put the number 0 into the array
        }

        private void one_Click(object sender, EventArgs e)
        {
            enterNumber(1);                                                 //put the number 1 into the array
        }

        private void two_Click(object sender, EventArgs e)
        {
            enterNumber(2);                                                 //put the number 2 into the array
        }

        private void three_Click(object sender, EventArgs e)
        {
            enterNumber(3);                                                 //put the number 3 into the array
        }

        private void four_Click(object sender, EventArgs e)
        {
            enterNumber(4);                                                 //put the number 4 into the array
        }

        private void five_Click(object sender, EventArgs e)
        {
            enterNumber(5);                                                 //put the number 5 into the array
        }

        private void six_Click(object sender, EventArgs e)
        {
            enterNumber(6);                                                 //put the number 6 into the array
        }

        private void seven_Click(object sender, EventArgs e)
        {
            enterNumber(7);                                                 //put the number 7 into the array
        }

        private void eight_Click(object sender, EventArgs e)
        {
            enterNumber(8);                                                 //put the number 8 into the array
        }

        private void nine_Click(object sender, EventArgs e)
        {
            enterNumber(9);                                                 //put the number 9 into the array
        }

        private void divide_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            sourceNumber = calculatorValue;                                 //hold calculator value
            calculatorValue = -1;                                           //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
            {
                calculator[i] = -1;                                         //reset the array
            }
            function = 0;                                                   //divide function is 0 in switch statement
            textBox1.AppendText(" / ");                                     //add divide symbol to textbox
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            sourceNumber = calculatorValue;                                 //hold calculator value
            calculatorValue = -1;                                           //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
            {
                calculator[i] = -1;                                         //reset the array
            }
            function = 1;                                                   //multiply function is 1 in switch statement
            textBox1.AppendText(" * ");                                     //add multiply symbol to textbox
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            sourceNumber = calculatorValue;                                 //hold calculator value
            calculatorValue = -1;                                           //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
            {
                calculator[i] = -1;                                         //reset the array
            }
            function = 2;                                                   //subtract function is 2 in switch statement
            textBox1.AppendText(" - ");                                     //add subtract symbol to textbox
        }

        private void add_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            sourceNumber = calculatorValue;                                 //hold calculator value
            calculatorValue = -1;                                           //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
            {
                calculator[i] = -1;                                         //reset the array
            }
            function = 3;                                                   //subtract function is 3 in switch statement
            textBox1.AppendText(" + ");                                     //add addition symbol to textbox
        }

        private void equal_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            double finalValue = 0;                                              //holds the final value
        
            switch (function)
            {
                case 0:
                    finalValue = sourceNumber * (1 / calculatorValue);              //divide
                    textBox1.Text = finalValue.ToString();                          //print the final value
                    calculatorValue = -1;                                           //reset calculator value
                    sourceNumber = finalValue;                                      
                    for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
                    {
                        calculator[i] = -1;                                         //reset the array
                    }
                    break;
                case 1:
                    finalValue = sourceNumber * calculatorValue;                    //multiply
                    textBox1.Text = finalValue.ToString();                          //print the final value
                    calculatorValue = -1;                                           //reset calculator value
                    sourceNumber = finalValue;
                    for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
                    {
                        calculator[i] = -1;                                         //reset the array
                    }
                    break;
                case 2:
                    finalValue = sourceNumber - calculatorValue;                    //subtract
                    textBox1.Text = finalValue.ToString();                          //print the final value
                    calculatorValue = -1;                                           //reset calculator value
                    sourceNumber = finalValue;
                    for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
                    {
                        calculator[i] = -1;                                         //reset the array
                    }
                    break;
                case 3:
                    finalValue = sourceNumber + calculatorValue;                    //add
                    textBox1.Text = finalValue.ToString();                          //print the final value
                    calculatorValue = -1;                                           //reset calculator value
                    sourceNumber = finalValue;
                    for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
                    {
                        calculator[i] = -1;                                         //reset the array
                    }
                    break;
                default:
                    textBox1.Text = "You did something wrong, please try again";    //wrong
                    calculatorValue = -1;                                           //reset calculator value
                    for (int i = 0; i < calculator.Length; i++)                     //iterate through calculator array
                    {
                        calculator[i] = -1;                                         //reset the array
                    }
                    break;

            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            calculatorValue = Math.Sqrt(calculatorValue);                           //change the value of value to its square root
            textBox1.Text = calculatorValue.ToString();                             //print it
        }

        private void percent_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            textBox1.AppendText("%");                                               //add a percent sign to the textbox
            calculatorValue = calculatorValue / 100;                                //turn the calculatorvalue into a percent
        }

        private void oneOver_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            calculatorValue = 1 / calculatorValue;                                  //execute 1 / x
            textBox1.Text = calculatorValue.ToString();                             //print it
        }

        private void flipSign_Click(object sender, EventArgs e)
        {
            isDecimal = false;                                              //number entry returns to normal
            calculatorValue = calculatorValue * (-1);                               //flip the sign
            textBox1.Text = calculatorValue.ToString();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            decimalValue = calculatorValue.ToString();                              //turn the calculator value to a string
            decimalValue = decimalValue + ".";                                      //add decimal place to variable
            textBox1.Text = decimalValue;
            calculatorValue = -1;                                                   //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                             //iterate through calculator array
            {
                calculator[i] = -1;                                                 //reset the array
            }
            isDecimal = true;                                                       //set boolean variable to true
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (isDecimal == true)
            {
                decimalValue = decimalValue.Remove(decimalValue.Length - 1);        //remove last character in decimal value
                textBox1.Text = decimalValue;                                       //update textbox
            }
            if (isDecimal == false)
            {
                for (int i = 0; i < calculator.Length; i++)                         //itereate through calculator
                {
                    if (calculator[i] != -1)                                        //if it was last number entered
                    {
                        calculator[i] = -1;                                         //erase it
                        break;                                                      //break out of loop
                    }
                    convertToNumber();                                              //calculate new number
                    textBox1.Text = calculatorValue.ToString();                     //display new number
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            calculatorValue = -1;                                                   //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                             //iterate through calculator array
            {
                calculator[i] = -1;                                                 //reset the array
            }
            isDecimal = false;                                                       //set boolean variable to false
            textBox1.Text = "";                                                      //clear most recent entry
        }

        private void C_Click(object sender, EventArgs e)
        {
            calculatorValue = -1;                                                   //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                             //iterate through calculator array
            {
                calculator[i] = -1;                                                 //reset the array
            }
            isDecimal = false;                                                       //set boolean variable to false
            textBox1.Text = "";                                                      //clear most recent entry

            sourceNumber = 0;                                                        //reset entire calculation
        }

        private void MS_Click(object sender, EventArgs e)
        {
            storedNumber = calculatorValue;                                         //store the displayed number
            textBox2.Text = "M";                                                    //indicate that memory is being stored

            calculatorValue = -1;                                                   //reset calculator value
            for (int i = 0; i < calculator.Length; i++)                             //iterate through calculator array
            {
                calculator[i] = -1;                                                 //reset the array
            }
            isDecimal = false;                                                       //set boolean variable to false
            textBox1.Text = "";                                                      //clear most recent entry
        }

        private void MR_Click(object sender, EventArgs e)
        {
            calculatorValue = storedNumber;                                         //recall the stored number
            textBox1.Text = calculatorValue.ToString();                             //post in the textbox
        }

        private void addMemory_Click(object sender, EventArgs e)
        {
            storedNumber = storedNumber + calculatorValue;                          //add displayed number to number already in memory
        }

        private void MC_Click(object sender, EventArgs e)
        {
            storedNumber = 0;                                                       //reset the memory variable
            textBox2.Text = "";                                                     //clear the memory textbox
        }
    }
}
