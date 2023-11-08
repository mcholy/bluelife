using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BlueToolkit;
using BlueToolkit.Extensions;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace BlueLife.Controllers.Outsiders
{
    [Route("api/infopersonas")]
    [ApiController]
    //[Authorize]
    public class InfoPersonasController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public InfoPersonasController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet(Name ="getInfoPersonaByID")]
        public async Task<IActionResult> GetInfoPersona([FromQuery] string dni, string force = "0")
        {
            try
            {
                // Hacer una solicitud al servicio externo utilizando HttpClient
                HttpResponseMessage response = await _httpClient.GetAsync($"http://www.infoburo.com.pe/android/BuscarDocumentoAndroid?uid=0&dni={dni}&force={force}");

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta y devolverlo como JSON
                    string content = await response.Content.ReadAsStringAsync();
                    //var data = JsonConvert.DeserializeObject(content)!;
                    //var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(content)!;
                    //ConvertToNestedDictionaries(data);
                    //dynamic data = JsonConvert.DeserializeObject<dynamic>(content)!;
                    return Ok(content);
                }
                else
                {
                    // Manejar errores si la solicitud al servicio externo no fue exitosa
                    return BadRequest("Error al consultar el servicio externo");
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpGet("buscados")]
        public async Task<IActionResult> GetBuscados()
        {
            try
            {
                // Hacer una solicitud al servicio externo utilizando HttpClient
                HttpResponseMessage response = await _httpClient.GetAsync($"http://www.infoburo.com.pe/android/ListarBuscados");

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta y devolverlo como JSON
                    string content = await response.Content.ReadAsStringAsync();
                    //dynamic data = JsonConvert.DeserializeObject<dynamic>(content)!;
                    //var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);
                    return Ok(content);
                }
                else
                {
                    // Manejar errores si la solicitud al servicio externo no fue exitosa
                    return BadRequest("Error al consultar el servicio externo");
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                return StatusCode(500, "Error interno del servidor");
            }
        }

        private void ConvertToNestedDictionaries(Dictionary<string, object> dictionary)
        {
            foreach (var key in dictionary.Keys.ToList())
            {
                if (dictionary[key] is string jsonString)
                {
                    // Si el valor es una cadena JSON, intenta deserializarla como un diccionario
                    try
                    {
                        var nestedDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
                        dictionary[key] = nestedDict;
                        ConvertToNestedDictionaries(nestedDict);
                    }
                    catch (JsonException)
                    {
                        // Si no se puede deserializar, deja el valor como está
                    }
                }
                else if (dictionary[key] is Dictionary<string, object> nestedDict)
                {
                    // Si el valor es un diccionario, realiza una conversión recursiva
                    ConvertToNestedDictionaries(nestedDict);
                }
            }
        }
    }
}
