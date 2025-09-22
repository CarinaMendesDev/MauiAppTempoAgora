using System.Threading.Tasks;
using MauiAppTempoAgora.Models;
using MauiAppTempoAgora.Services;

namespace MauiAppTempoAgora
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cidadeEntry.Text))
                {
                    Tempo? t = await DataService.GetPrevisao(cidadeEntry.Text);

                    if (t != null)
                    {

                        string dados_previsao = "";

                        dados_previsao += $"Latitude: {t.lat}\n";
                        dados_previsao += $"Longitude: {t.lon}\n";
                        dados_previsao += $"Nascer do Sol: {t.sunrise}\n";
                        dados_previsao += $"Pôr do Sol: {t.sunset}\n";
                        dados_previsao += $"Temperatura Min: {t.temp_min} ºC\n";
                        dados_previsao += $"Temperatura Max: {t.temp_max} ºC\n";
                        dados_previsao += $"Descrição: {t.description}\n";
                        dados_previsao += $"Velocidade do Vento: {t.speed} m/s\n";
                        dados_previsao += $"Visibilidade: {t.visibility} m\n";


                        resultadoLabel.Text = dados_previsao;

                    }
                    else
                    {
                        resultadoLabel.Text = "Sem dados de Previsão";
                    }
                }
                else
                {
                    resultadoLabel.Text = "Preencha o nome da cidade.";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");

            }
        }
    }
}

