using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraWindows
{
    
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string mathOperator;
        double firsNumber, secondNumber;

        private void OnClear(object sender, EventArgs e)
        {
            firsNumber = 0;
            secondNumber = 0;
            currentState = 1;
            this.resultText.Text = "0";

        }
        void onSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            this.resultText.Text = "0";

            if (this.resultText.Text == "0" || currentState < 0)
            {
                this.resultText.Text = "";
                if(currentState < 0)
                {
                    currentState *= -1;
                }
                this.resultText.Text += pressed;
                double number;
                if (double.TryParse(this.resultText.Text, out number))
                {
                    this.resultText.Text = number.ToString("NO");
                    if (currentState == 1)
                    {
                        firsNumber = number;
                    }
                    else
                    {
                        secondNumber = number;
                    }
                }
            } 
        }

        public MainPage()
        {
            InitializeComponent();
            OnClear(new object(), new EventArgs());
        }

    }
}
