namespace G1TintaEspacial.Client.Servicios
{
    public class HttpRespuesta <T>
    {
        public HttpRespuesta( T respuesta, bool error, HttpResponseMessage httpResponseMessage)
        {
            Respuesta = respuesta;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public T Respuesta { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; }
    }
}
