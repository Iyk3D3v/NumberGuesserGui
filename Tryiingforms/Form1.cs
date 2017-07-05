using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tryiingforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //function to submit
            Random myrandom = new Random();
            int mainNum = myrandom.Next(1,10);//random variable
            int number;//holds user input

            
            //to chk five inputs only

            //try
            //{
            //    number = int.Parse(txtNumber.Text);
            //    int newNmber = number;
            //    return;

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Invalid data, enter a number between 1 and 10");
            //}


            // txtNumber.Clear();
            int num = 0;
            do
            {
                int.TryParse(txtNumber.Text, out number);
                //number = int.Parse(txtNumber.Text);

                if (number == mainNum)
                {
                    txtNumber.Clear();
                    MessageBox.Show("Correct!!");
                    Application.Exit();

                }

                else if (number != mainNum)
                {
                    txtNumber.Clear();
                    MessageBox.Show("InCorrect!! Try again");
                    return;
                }
            }
            while (num < 3);
            num++;
            

            //int a = 3;

            //for(int i = 5; i <5; i++)
            //{

            //}

            
               
          
        }

       //problems faced
       //to reduce num of imput times
       //chk valodation
    }
}
