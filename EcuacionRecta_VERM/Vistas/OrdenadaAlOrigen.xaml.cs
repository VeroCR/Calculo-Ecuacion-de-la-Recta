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
    public partial class OrdenadaAlOrigen : ContentPage
    {
        public OrdenadaAlOrigen()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtm.Text) && !string.IsNullOrEmpty(txtb.Text))
            {
                int m = Convert.ToInt32(txtm.Text);
                int b = Convert.ToInt32(txtb.Text);
                if (b < 0)
                {
                    lblOrdenadaOrigen.Text = ("y = " + m + "x " + b);
                    lblFormaGeneral.Text = (-(m) + "x + y + " + -(b) + " = 0");
                }
                else
                {
                    lblOrdenadaOrigen.Text = ("y = " + m + "x + " + b);
                    lblFormaGeneral.Text = (-(m) + "x + y " + -(b) + " = 0");
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