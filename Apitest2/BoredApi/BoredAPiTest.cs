using System;
using NUnit.Framework;
using NUnit.Framework.Api;
using Services.BoredAPI;
using System.Threading.Tasks;
using System.Net.Http;
using RestSharp;

namespace Apitest2.BoredApi
{

    public class BoredAPiTest

    {

        private HttpClient restClient = new HttpClient();
        private string URI = "https://www.boredapi.com/api/activity";
        
        
        [Test]
        [Category("Tests")]
        public async Task API_Test() 
        {

            Services.BoredAPI.BoredApi test = new Services.BoredAPI.BoredApi();
            var Response = await test.Get_200Ok();
            Assert.AreEqual("Ok", Response);
            
            

        }




    }






}
