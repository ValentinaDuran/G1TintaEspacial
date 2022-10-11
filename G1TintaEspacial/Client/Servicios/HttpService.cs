using System.Text.Json;

namespace G1TintaEspacial.Client.Servicios
{
    public class HttpService : IHttpService
    {
        //private readonly HttpClient http;
        public HttpService(HttpClient http)
        {
            Http = http;
        }

        public HttpClient Http { get; }
        public async Task<HttpRespuesta<T>> Get<T>(string url)
        {
            var response = await Http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await DeserealizarRespuesta<T>(response);
                return new HttpRespuesta<T>(respuesta, false, response);

            }
            else
            {
                return new HttpRespuesta<T>(default, true, response);
            }
        }

        private async Task<T> DeserealizarRespuesta<T>(HttpResponseMessage response)
        {
            var respuestastring = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestastring, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });



        }
    }
}
