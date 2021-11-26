using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A15 齋藤　圭吾";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double weight, height, BMI;
            try
            {


                weight = double.Parse(weighit.Text);
                height = double.Parse(heighit.Text);
                if(height > 10)
                {
                    height = height / 100;
                }
                
                if(weight >1000)
                {
                    weight = weight / 1000;
                }
                BMI = (weight / (height * height));
                BMI = BMI * 10;
                double bmi = Math.Round(BMI);
                bmi = bmi / 10;
                

                if (BMI < 18.5)
                {
                    result.Text = bmi + "　低体重（痩せ）";
                }
                else
                if (BMI < 25)
                {
                    result.Text = bmi + "　普通体重";
                }
                else
                if (BMI < 30)
                {
                    result.Text = bmi + "　肥満（１度）";
                }
                else
                if (BMI < 35)
                {
                    result.Text = bmi + "　肥満（２度）";
                }
                else
                if (BMI < 40)
                {
                    result.Text = bmi + "　肥満（３度）";
                }
                else
                {
                    result.Text = bmi + "　肥満（４度）";
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
