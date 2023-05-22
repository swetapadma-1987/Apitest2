using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo
{
    public class DemoAPI
    {
        public ListOfResponse GetResponse() {

            {
                var restClient = new RestClient("https://www.boredapi.com");
                var response = new RestRequest("/api/activity", Method.GET);
                response.AddHeader("Accept-Encoding", "gzip, deflate, br");
                response.AddHeader("Accept", "application/json");
                response.RequestFormat = DataFormat.Json;
                IRestResponse res = restClient.Execute(response);
                var content = res.Content;
                var users1 = JsonConvert.DeserializeObject<ListOfResponse>(content);
                return users1;
            }




        }
    }
}
