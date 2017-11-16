using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double w = Double.Parse(Weight.Text);
            Double h = Double.Parse(Height.Text);

            h /= 100;

            double bmi = w / h / h;

            double code = System.Math.Pow(10, 2);
            bmi = bmi > 0 ? System.Math.Floor(bmi * code) / code :
                System.Math.Ceiling(bmi * code) / code;

            string bmit = "";

            if (bmi < 18.5)
            {
                bmit = "低体重（痩せ型）";
            }
            else if (bmi < 25)
            {
                bmit = "普通体重";
            }
            else if (bmi < 30)
            {
                bmit = "肥満（1度）";
            }
            else if (bmi < 35)
            {
                bmit = "肥満（2度）";
            }
            else if (bmi < 40)
            {
                bmit = "肥満（3度）";
            }
            else
            {
                bmit = "肥満（4度）";
            }

            Bmi.Text = string.Format("BMI {0} {1}", bmi, bmit);
        }
    }
}
