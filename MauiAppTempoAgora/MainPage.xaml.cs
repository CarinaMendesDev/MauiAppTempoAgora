using System.Threading.Tasks;
using MauiAppTempoAgora.Models;
using MauiAppTempoAgora.Services;

namespace MauiAppTempoAgora
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_Previsao(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_cidade.Text))
                {
                    Tempo? t = await DataService.GetPrevisao(txt_cidade.Text);

                    if (t != null)
                    {

                        string dados_previsao = "";

                        dados_previsao += $"📍Latitude: {t.lat}\n";
                        dados_previsao += $"📍Longitude: {t.lon}\n";
                        dados_previsao += $"🌅Nascer do Sol: {t.sunrise}\n";
                        dados_previsao += $"🌄Pôr do Sol: {t.sunset}\n";
                        dados_previsao += $"🌡️Temperatura Min: {t.temp_min} ºC\n";
                        dados_previsao += $"🌡️Temperatura Max: {t.temp_max} ºC\n";
                        dados_previsao += $"🌦️Descrição: {t.description}\n";
                        dados_previsao += $"💨Velocidade do Vento: {t.speed} m/s\n";
                        dados_previsao += $"👁️Visibilidade: {t.visibility} m\n";


                        lbl_res.Text = dados_previsao;

                        string mapa = $"https://embed.windy.com/embed.html?" +
                            $"type=map&location=coordinates&metricRain=mm&metricTemp=°C" +
                            $"&metricWind=km/h&zoom=5&overlay=wind&product=ecmwf&level=surface" +
                            $"&lat={t.lat.ToString().Replace(",", ".")}&lon={t.lon.ToString().Replace(",", ".")}" +
                            $"&detailLat={t.lat.ToString().Replace(",", ".")}&detailLon={t.lon.ToString().Replace(",", ".")}&detail=true";
                                                        
                        wv_mapa.Source = mapa;

                    } 
                    else
                    {
                        lbl_res.Text = "Sem dados de Previsão";
                    }
                }
                else
                {
                    lbl_res.Text = "Preencha o nome da cidade.";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");

            }
        }

        private async void Button_Clicked_Localizacao(object sender, EventArgs e)
        {
            try 
            {
                GeolocationRequest request = new GeolocationRequest(
                        GeolocationAccuracy.Medium, 
                        TimeSpan.FromSeconds(10)
                );

                Location? local = await Geolocation.Default.GetLocationAsync(request);

                if (local != null)
                {
                    // pega cidade a partir das coordenadas
                    string cidade = await GetCidade(local.Latitude, local.Longitude);

                    string local_disp = $"📍Latitude: {local.Latitude}\n" +
                                        $"📍Longitude: {local.Longitude}\n" +
                                        $"🏙️Cidade: {cidade}\n" +
                                        $"📅Data: {local.Timestamp.ToLocalTime():dd/MM/yyyy}\n" +
                                        $"🕒Hora: {local.Timestamp.ToLocalTime():HH:mm}";
                  
                    lbl_coords.Text = local_disp;

                    //pega nome da cidade que esta nas cordenadas
                    txt_cidade.Text = cidade;

                } else
                {
                    lbl_coords.Text = "Localização não encontrada.";
                }

            }
            catch (FeatureNotSupportedException fnEx)
            {
                await DisplayAlert("Erro: Dispositivo não suporta", fnEx.Message, "OK");
            } 
            catch (FeatureNotEnabledException fneEx)
            {
                await DisplayAlert("Erro: Localização Desabilitada", fneEx.Message, "OK");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Erro: Permissão Negada", pEx.Message, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }

        }

        private async Task<string> GetCidade(double lat, double lon)
        {
            try
            {
                IEnumerable<Placemark> places = await Geocoding.Default.GetPlacemarksAsync(lat, lon);

                Placemark? place = places.FirstOrDefault();

                if (place != null)
                {
                    return place.Locality ?? "Cidade não encontrada";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro: Obtençao do nome da cidade", ex.Message, "OK");
            }

            return "Cidade não encontrada";
        }
    }
}


