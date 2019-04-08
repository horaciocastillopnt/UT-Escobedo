using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UT_Escobedo.Views.Becas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BecasPage : ContentPage
	{
		public BecasPage ()
		{

			InitializeComponent ();

            HomePage.bandera = 0;

		}

        #region Display Beca Interna

        private void BtnInformacion_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Informacion", "Beca la cual te reducira lo que tienes que pagar de cuota escolar", "Cerrar");

        }

        private void BtnRequerimientos_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Requisitos", "- Kardex del Cuatrimestre en Curso\n" + " - Ingresos Familiares\n" +
                " - Recibo de Servicio Público (Gas, Agua, Teléfono, Luz)\n" + " - Recibo de Pago, Inscripción o Reinscripción\n" +
                " - No tener Becas Externas\n" + " Entregar los documentos junto con la solicitud de beca a escolar\n"
                + "(NOTA: Ir por la solicitud al departamento de escolar)", "Cerrar");

        }

        private void BtnFecha_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Fechas", "15 de Enero al 31 de Enero", "Cerrar");

        }



        #endregion

        #region Display Beca de Transporte

        private void BtnInformacionBecaTransporte_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Información", "Se le depositará 300 pesos a tu tarjeta Feria cada mes", "Cerrar");

        }

        private void BtnRequerimientosBecaTransporte_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Requisitos", "- Kardex del Cuatrimestre en Curso\n" + " - Ingresos Familiares\n" +
                " - Recibo de Servicio Público (Gas, Agua, Telefono, Luz)\n" + " - Recibo de Pago, Inscripción o Reinscripción\n" +
                " - No tener Becas Externas\n" + " Entregar los documentos junto con la solicitud de beca a escolar\n"
                + "(NOTA: Ir por la solicitud al departamento de escolar)", "Cerrar");

        }

        private void BtnFechaBecaTransporte_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Fechas", "15 de Enero al 30 de Enero", "Cerrar");

        }

        #endregion

        #region Display Beca Alimenticia

        private void BtnInformacionBecaAlimenticia_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Información", "Se te proporcionará vales los cuales podras canjear en cafeteria por un platillo en el menú", "Cerrar");

        }

        private void BtnRequerimientosBecaAlimenticia_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Requisitos", "- Kardex del Cuatrimestre en Curso\n" + " - Ingresos Familiares\n" +
                         " - Recibo de Servicio Publico (Gas, Agua, Telefono, Luz)\n" + " - Recibo de Pago, Inscripcion o Reinscripcion\n" +
                         " - No tener Becas Externas\n" + " Entregar los documentos junto con la solicitud de beca a escolar\n"
                         + "(NOTA: Ir por la solicitud al departamento de escolar)", "Cerrar");

        }

        private void BtnFechaBecaAlimenticia_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Fechas", "15 de Enero al 30 de Enero", "Cerrar");

        }

        #endregion

        #region Display Beca Deportiva

        private void BtnInformacionBecaDeportiva_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Información", "", "Cerrar");

        }

        private void BtnRequerimientosBecaDeportiva_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Requisitos", "- Kardex del Cuatrimestre en Curso\n" + " - Ingresos Familiares\n" +
                         " - Recibo de Servicio Público (Gas, Agua, Teléfono, Luz)\n" + " - Recibo de Pago, Inscripción o Reinscripción\n" +
                         " - No tener Becas Externas\n" + " Entregar los documentos junto con la solicitud de beca a escolar\n"
                         + "(NOTA: Ir por la solicitud al departamento de escolar)", "Cerrar");

        }

        private void BtnFechaBecaDeportiva_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Fechas", "15 de Enero al 30 de Enero", "Cerrar");

        }

        #endregion

        protected override bool OnBackButtonPressed()
        {

            Device.BeginInvokeOnMainThread(async () =>
            {

                var home = new MainPage()
                {

                    Detail = new NavigationPage(new HomePage())

                };

                NavigationPage.SetHasNavigationBar(home, false);

                await Navigation.PushAsync(home);

            });

            return true;

        }

    }
}