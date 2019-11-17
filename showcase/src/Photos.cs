using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
namespace Showcase
{
    public class Photos
    {
        public  async Task<List<Photo>> Get(int albumId)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "Technical Showcase");
            string URL = String.Format("https://jsonplaceholder.typicode.com/photos?albumId={0}", albumId);
        
            var streamTask =  client.GetStreamAsync(URL);
            
            var serializer = new DataContractJsonSerializer(typeof(List<Photo>));
            var photos = serializer.ReadObject(await streamTask) as List<Photo>;        
            return photos;


        }
    }
}
