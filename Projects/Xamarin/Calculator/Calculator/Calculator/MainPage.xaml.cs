using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        double screen;
        public MainPage()
        {
            InitializeComponent();
            screen = 0;
            Et_Visor.Text = screen.ToString();
        }

        private void Num_Clicked(object sender, EventArgs e)
        {
            if (Et_Visor.Text == "0")
            {
                Et_Visor.Text = "";
                Button b = (Button)sender;
                Et_Visor.Text += b.Text;
            }
            else
            {
                Button b = (Button)sender;
                Et_Visor.Text += b.Text;
            }
        }

        private void Op_Clicked(object sender, EventArgs e)
        {
            screen = double.Parse(Et_Visor.Text);
            Et_Visor.Text = "";
            
            Button b = (Button)sender;
            switch(b.Text)
            {
                case "/":
                    break;
                case "*":
                    //codigo
                    break;
                case "-":
                    break;
                case "+":
                    break;
            }
            //DisplayAlert("Message", b.Text,"OK");
        }
    }
}
