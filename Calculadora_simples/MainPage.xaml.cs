using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_simples
{
    public partial class MainPage : ContentPage
    {
        double n1;
        double n2;
        string op;
        string resp;
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(inp1.Text);
            n2 = Convert.ToDouble(inp2.Text);
            op = iop.Text;
            if (op == "+")
            {
               var n4 = n1 + n2;
                resp = n4.ToString();
                respo.Text = resp;
            }
            else if (op == "-") 
            { 
              resp = (n1 - n2).ToString();
                respo.Text = resp;
            }
            else if (op == "*" || op == "x")
            {
                resp = (n1 * n2).ToString();
                respo.Text = resp;
            }
            else if (op == "/")
            {
                resp += (n1 / n2).ToString();
                respo.Text = resp;
            }
            else if(op == "%")
            { 
                resp = ((n1 / n2).ToString()).ToString();
                respo.Text = resp;
            }
            else
            {
                resp = "deu ruim";
                respo.Text = resp;
            }


        }
    }
}
