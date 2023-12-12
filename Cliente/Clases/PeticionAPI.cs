using Cliente.Models;
using Newtonsoft.Json;

namespace Cliente.Clases
{
    public class PeticionAPI
    {

        private HttpClient _httpClient;

        public PeticionAPI()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7082/");
        }

        public async Task<ResultadoModel> ConsumirGet()
        {
            ResultadoModel resultadoModel = new ResultadoModel();

            try
            {
                var request = await _httpClient.GetAsync("api/TestAPI/");

                if (request.IsSuccessStatusCode)
                {
                    var resultado = await request.Content.ReadAsStringAsync();
                    resultadoModel = JsonConvert.DeserializeObject<ResultadoModel>(resultado);
                }
                else
                {
                    // Manejar el caso en que la solicitud no fue exitosa
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera apropiada (log, notificar, etc.)
                throw ex;
            }

            return resultadoModel;
        }



    }
}
