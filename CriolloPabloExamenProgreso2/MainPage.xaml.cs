using CriolloPabloExamenProgreso2.Interfaces;
using CriolloPabloExamenProgreso2.Models;
using CriolloPabloExamenProgreso2.Reposities;

namespace CriolloPabloExamenProgreso2
{
    public partial class MainPage : ContentPage
    {
         ICriolloRecarga _recargaRepository;
          PCriolloRecarga recarga = new PCriolloRecarga();

        public MainPage()
        { 
            InitializeComponent();
            _recargaRepository = new Pcriollo_RepositoryRecarga();
            recarga = _recargaRepository.GetRecarga("1");
            BindingContext = recarga;
        }

        private async void GuardarRecarga_Clicked(object sender, EventArgs e)
        {
            PCriolloRecarga  recarga = new PCriolloRecarga()
            {
                Nombre = EditorNumero.Text,
                Numero = EditorNombre.Text,
                
            };
            bool guardar_Recarga = _recargaRepository.CreateRecarga(recarga);
            if (guardar_Recarga)
            {
                await DisplayAlert("Alerta", "Recarga realizada exitosamente", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Recarga no realizada corectamente", "OK");
            }
        }




    }

}
