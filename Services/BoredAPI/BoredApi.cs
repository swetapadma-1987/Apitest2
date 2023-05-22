using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json;

namespace Services.BoredAPI;


public class BoredApi
{
    private string URI = "https://www.boredapi.com/api/activity";
    private HttpClient httpClient = new HttpClient();
   
    
    
    private readonly Dictionary<string, object> _queryparams = new Dictionary<string, object>()
    {
        ["type"] = "social",
        ["participants"] = "2"
    };
    private readonly Dictionary<string, string> _headers = new Dictionary<string, string>() 
    {
        ["Accept"] = "*/*",
        ["Accept-Encoding"] = "gzip, deflate, br",
        ["Content-Type"] = "application/json",
        ["Connection"] = "keep-alive"

    };
    
    public async Task<string> Get_200Ok() {
       // httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
       //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept","*/*");
       //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
       //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Connection", "keep-alive");

        //var response = await restClient.GetAsync(URI);
        //var reasonPhrase = response.ReasonPhrase.ToString();

        // return reasonPhrase;
        var restClient = new RestClient("https://www.boredapi.com");
        var response =  new RestRequest("/api/activity",Method.GET);
        response.AddHeader("Accept-Encoding", "gzip, deflate, br");
        response.AddHeader("Accept", "application/json");
        response.RequestFormat = DataFormat.Json;
        IRestResponse res = restClient.Execute(response);
        var content = res.Content;
        var users = JsonConvert.DeserializeObject(content);
        return content;

    }

};
