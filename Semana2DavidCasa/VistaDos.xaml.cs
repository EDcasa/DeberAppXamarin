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
    public partial class VistaDos : ContentPage
    {
        public VistaDos(String user, String clave)
        {
            InitializeComponent();
            DisplayAlert("Bienvenido", "Bienvenido al sistema "+user+"!", "Gracias");
            lblUser.Text = user;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                //calculo semana 1
                double seguimiento = Convert.ToDouble(txtSeguimiento.Text);
                double examen = Convert.ToDouble(txtExamen.Text);
                double suma = (seguimiento*0.3)+(examen*0.2);
                lblNotaParcial.Text = "Nota Parcial 1:  " + suma.ToString();

                if(seguimiento > 10)
                {
                    DisplayAlert("Alert", "Las notas no pueden ser mayores a 10!", "Aceptar");

                }else if (examen > 10)
                {
                    DisplayAlert("Alert", "Las notas no pueden ser mayores a 10!", "Aceptar");
                }
                //calculo semana 2

                double seguimientoDos = Convert.ToDouble(txtSeguimientoDos.Text);
                double examenDos = Convert.ToDouble(txtExamenDos.Text);
                double sumaDos = (seguimiento * 0.3) + (examen * 0.2);
                lblNotaParcialDos.Text = "Nota Parcial 2:  " +  suma.ToString();

                double notaFinal = suma + sumaDos;

                if (seguimientoDos > 10)
                {
                    DisplayAlert("Alert", "Las notas no pueden ser mayores a 10!", "Aceptar");

                }
                else if (examenDos > 10)
                {
                    DisplayAlert("Alert", "Las notas no pueden ser mayores a 10!", "Aceptar");
                }
                //nota final 
                lblNotaFinal.Text = "Nota Final: "+notaFinal.ToString();

                if (notaFinal >= 7) {
                    lblEstado.Text = "Aprobado";
                    DisplayAlert("Estado","Usted ha aprobado!", "Aceptar");
                    
                }else if (notaFinal <5)
                {
                    lblEstado.Text = "Reprobado";
                    DisplayAlert("Estado", "Usted ha reprobado!", "Aceptar");
                    
                }
                else if (notaFinal >= 5 && notaFinal <= 6.9)
                {
                    lblEstado.Text = "Complementario";
                    DisplayAlert("Estado", "Usted debe rendir examen complementario!", "Aceptar");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}