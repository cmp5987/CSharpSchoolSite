using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Project3.Models;

namespace Project3.Services
{
    public class MockGetFaculty : IGetFaculty
    {
        public async Task<List<Faculty>> GetAllFaculty()
        {
            var filePath = (@"..\Project3\faculty.json");  //This specifies the relative path to the "faculty.json" file
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000]; // This specifies an array length of hexadecimal 1000 = 4096
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.UTF8.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                var data = JsonConvert.DeserializeObject<List<Faculty>>(sb.ToString());
                return data;
            }
        }
    }
}
