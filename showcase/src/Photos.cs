using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
namespace Showcase {
    public class Photos {

        public HttpClient Client { get; }
        public Photos () {
            HttpClient client = new HttpClient ();
            client.DefaultRequestHeaders.Accept.Clear ();
            client.DefaultRequestHeaders.Add ("User-Agent", "Technical Showcase");
            client.BaseAddress = new Uri ("https://jsonplaceholder.typicode.com/");

            Client = client;
        }
        public async Task<List<Photo>> Get (int albumId) {
            string URL = String.Format ("photos?albumId={0}", albumId);
            var streamTask = Client.GetStreamAsync (URL);

            var serializer = new DataContractJsonSerializer (typeof (List<Photo>));
            return serializer.ReadObject (await streamTask) as List<Photo>;            
        }
    }
}