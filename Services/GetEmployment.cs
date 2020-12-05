using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3.Services
{
    public class GetEmployment
    {
        public async Task<Employment> GetAllEmployment()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/employment", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Employment>(data);
                    Console.WriteLine("Here");
                    Console.WriteLine(rtnResults);
                    return rtnResults;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    var employment = new Employment();
                    return employment;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    var employment = new Employment();
                    return employment;
                    //return "Exception"; ;
                }
            }
        }
    }
}