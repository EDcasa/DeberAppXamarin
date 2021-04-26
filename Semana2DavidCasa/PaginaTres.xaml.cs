using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2DavidCasa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTres : ContentPage
    {
        public PaginaTres()
        {
            InitializeComponent();
        }

        private async void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new VistaDos(usuario, clave));
            }
            else
            {
                DisplayAlert("Alert", "El usuario o clave son incorrectos", "Aceptar");

            }

        }
    }
}