using MauiAppTempoAgora.Models;
using Newtonsoft.Json.Linq;

namespace MauiAppTempoAgora.Services
{
    public class DataService
    {
        public static async Task<Tempo?> GetPrevisao(string cidade)
        {
            Tempo t = null;

            string chave = "10141e64141665463a0d012983efee57";

            string url = $"https://api.openweathermap.org/data/2.5/weather?" +
                         $"q={cidade}&units=metric&lang=pt_br&appid={chave}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage resp;

                try
                {
                    resp = await client.GetAsync(url);
                }
                catch
                {
                    throw new Exception("Sem conexão com a internet.");
                }


                if (resp.IsSuccessStatusCode)
                {
                    string json = await resp.Content.ReadAsStringAsync();

                    var rascunho = JObject.Parse(json);

                    // Converte Unix Timestamp → DateTime
                    DateTime sunrise = DateTime.UnixEpoch
                        .AddSeconds((double)rascunho["sys"]["sunrise"])
                        .ToLocalTime();

                    DateTime sunset = DateTime.UnixEpoch
                        .AddSeconds((double)rascunho["sys"]["sunset"])
                        .ToLocalTime();

                    t = new Tempo()
                    {
                        lat = (double)rascunho["coord"]["lat"],
                        lon = (double)rascunho["coord"]["lon"],
                        description = (string)rascunho["weather"][0]["description"],
                        main = (string)rascunho["weather"][0]["main"],
                        temp_min = (double)rascunho["main"]["temp_min"],
                        temp_max = (double)rascunho["main"]["temp_max"],
                        speed = (double)rascunho["wind"]["speed"],
                        visibility = (int)rascunho["visibility"],
                        sunrise = sunrise.ToString("HH:mm"),
                        sunset = sunset.ToString("HH:mm")
                    };

                }
                else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new Exception("Cidade não encontrada. Verifique o nome digitado.");
                }
                else
                {
                    throw new Exception("Erro ao consultar a API.");
                }
            }
            return t;

        }
    }
}
