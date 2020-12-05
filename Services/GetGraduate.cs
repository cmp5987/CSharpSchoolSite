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
    public class GetGraduate
    {
        public async Task<List<Graduate>> GetAllGraduate()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/degrees/graduate", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Graduate>>>(data);

                    List<Graduate> graduateList = new List<Graduate>();
                    Graduate graduate = new Graduate();

                    foreach (KeyValuePair<string, List<Graduate>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            graduateList.Add(item);
                        }
                    }

                    return graduateList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Graduate> graduateList = new List<Graduate>();
                    return graduateList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Graduate> graduateList = new List<Graduate>();
                    return graduateList;
                    //return "Exception"; ;
                }
            }
        }
    }
}