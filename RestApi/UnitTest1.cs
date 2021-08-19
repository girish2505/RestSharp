using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestApi
{
    [TestClass]
    public class ValidatingSpotify
    {
        IRestClient client;
        IRestRequest request;

        public static IRestResponse response { get; set; }
        [TestMethod]
        public void GetUserId()
        {
            string myToken = "Bearer BQCLneQmnXVbY2RyvYOlED2YBF4P82dxz1aoUhXCcGALTlU0nPPYl5HeuCrr94fXAmI_MgBHEU2zlfXK9wPM_K2utYAftUfD5Vwm18RqXL44bimAz0dVAjSGwJghKaWSll_sQbLlYTCNBx2qWHTLEO1Wb2YTDViwObr8UcUCdL3UlcPYuytMlvDsAOfPb0W1VPVpfc4Z5GhsxKgDgLYV7qZSE-xf2vO-4UjTRCvfOQ";

            string getUrl = "https://api.spotify.com/v1/me";
            client = new RestClient();
            request = new RestRequest(getUrl);
            request.AddHeader("Authorization", "Token" + myToken);
            response = client.Get(request);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            if (response.IsSuccessful)
            {
                System.Console.WriteLine("test Validated successfully with status code " + response.StatusCode + " with response :" + response.Content);

            }
            else
            {
                System.Console.WriteLine(response.ErrorException);
                System.Console.WriteLine(response.ErrorMessage);
            }
        }
        [TestMethod]
        public void GetPlaylist()
        {
            string myToken = "Bearer BQCLneQmnXVbY2RyvYOlED2YBF4P82dxz1aoUhXCcGALTlU0nPPYl5HeuCrr94fXAmI_MgBHEU2zlfXK9wPM_K2utYAftUfD5Vwm18RqXL44bimAz0dVAjSGwJghKaWSll_sQbLlYTCNBx2qWHTLEO1Wb2YTDViwObr8UcUCdL3UlcPYuytMlvDsAOfPb0W1VPVpfc4Z5GhsxKgDgLYV7qZSE-xf2vO-4UjTRCvfOQ";

            string getUrl = "https://api.spotify.com/v1/me/playlists";
            client = new RestClient();
            request = new RestRequest(getUrl);
            request.AddHeader("Authorization", "Token" + myToken);
            response = client.Get(request);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

            if (response.IsSuccessful)
            {
                System.Console.WriteLine("test Validated successfully with status code " + response.StatusCode + " with response :" + response.Content);

            }
            else
            {
                System.Console.WriteLine(response.ErrorException);
                System.Console.WriteLine(response.ErrorMessage);
            }

        }
    }
}