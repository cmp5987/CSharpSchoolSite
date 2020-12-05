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
    public class GetResearchByFaculty
    {
        public async Task<List<ByFaculty>> GetAllResearchByFaculty()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/research/byFaculty", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<ByFaculty>>>(data);

                    List<ByFaculty> byFacultyList = new List<ByFaculty>();
                    ByFaculty byFaculty = new ByFaculty();

                    foreach (KeyValuePair<string, List<ByFaculty>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            byFacultyList.Add(item);
                        }
                    }

                    return byFacultyList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<ByFaculty> byFacultyList = new List<ByFaculty>();
                    return byFacultyList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<ByFaculty> byFacultyList = new List<ByFaculty>();
                    return byFacultyList;
                    //return "Exception"; ;
                }
            }
        }
    }
}