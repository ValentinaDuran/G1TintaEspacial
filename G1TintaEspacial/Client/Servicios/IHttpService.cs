namespace G1TintaEspacial.Client.Servicios
{
    public interface IHttpService
    {
        HttpClient Http { get; }

        Task<HttpRespuesta<T>> Get<T>(string url);
    }
}