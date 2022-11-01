using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcuacionRecta_VERM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PuntoPendiente : ContentPage
    {
        public PuntoPendiente()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtx.Text) && !string.IsNullOrEmpty(txty.Text) && !string.IsNullOrEmpty(txtm.Text))
            {
                int x = Convert.ToInt32(txtx.Text);
                int y = Convert.ToInt32(txty.Text);
                int m = Convert.ToInt32(txtm.Text);
                int c;
                c = m*(-x)-(-y);
                if (x < 0)
                {
                    if(y < 0)
                    {
                        lblPuntoPendiente.Text = ("y +" + -(y) + " = " + m +"(x +"+-(x)+ ")");
                    }
                    else
                    {
                        lblPuntoPendiente.Text = ("y" + -(y) + " = " + m + "(x +" + -(x) + ")");
                    }
                    
                }
                else
                {
                    if(y < 0)
                    {
                        lblPuntoPendiente.Text = ("y +" + -(y) + " = " + m + "(x" + -(x) + ")");
                    }
                    else
                    {
                        lblPuntoPendiente.Text = ("y " + -(y) + " = " + m + "(x" + -(x) + ")");
                    }
                }
                if (c < 0)
                {
                    lblFormaGeneral.Text = (m + "x - y " + c + " = 0");
                }
                else
                {
                    lblFormaGeneral.Text = (m + "x - y + " + c + " = 0");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese los valores.", "Cerrar");
            }
        }

        private void regresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}