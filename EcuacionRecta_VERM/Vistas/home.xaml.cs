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
    public partial class home : ContentPage
    {
        public home()
        {
            InitializeComponent();
        }

        private void ordenada_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrdenadaAlOrigen());
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PuntoPendiente());
        }

        private void terminar_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}