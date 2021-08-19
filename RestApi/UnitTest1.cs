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
        //*******POST********
        [TestMethod]
        public void CreatePlaylist()
        {
            string myToken = "Bearer BQDt7Wo9ml4bdHrHUql1m2uw1VqIsAaxkDr3FxIPcfgbZS-tQGIalcHQmHcaxV3hSr5mpzRYg_EQIXlfW7ipPGVG8fvp529CMFiMzOkyRbZLL5DdcHlSkciPPbfSsEeuvSxfgnWojOhwAOJXfqe7_OynAuank9m7UZmrPbzvjJzuBsIOQIbID8BwGk2Jn267jCeRcVC0nxQ9OdsNu-aa55jUXppozcRRRRs66mT8IgGQW2CgOXI0Al-XIMG6OaC_asVv3wtHhcgSrt81vvbYKEj9XOBiVCLZirfhpJag";
            string getUrl = "https://api.spotify.com/v1/users/miq9x438ysuedi1io43rz0awv/playlists";
            string jsonBody = "{"+
                                 "\"name\":\"girish\","+
                                 "\"description\": \"fav songs\","+
                                  "\"public\": false"+
                               "}";
            client = new RestClient();
            request = new RestRequest(getUrl);
            request.AddHeader("Authorization", "Token" + myToken);
            request.AddJsonBody(jsonBody);
            response = client.Post(request);
            Assert.AreEqual(201, (int)response.StatusCode);
            

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
        public void AddItemToPlaylist()
        {
            string token = "Bearer BQCDEXtA85NRW4j9jdKMx7XSNJZmb1v6Weo3iW3xkwi2UWiQdH2w35Y-l52o3_CsSjlRETr4SpJbyXruiW3GtPet45IJAOCFzyawDPJQpKJWXM5R0oZBij33wncCr4ckGxlTAbBant_2k8NGy7bbKBnsfhdq2scfXWZ3ciAXCrqKRFacw6ldfhi1Gno-EdGk1gnfDXAHV19n3kczuqrbSn2vV45kgTGSOfs4L-YpJIPTuC6fAOyHD4hyFbQ4LkmNbA3SFMUeR5YsmcAtmWZ1YUVaIuZ_dUJszkEQ6jKB";
            string getUrl = "https://api.spotify.com/v1/playlists/1VycgeJFTpPqvyfKJNqQph/tracks?uris=spotify%3Atrack%3A5sbooPcNgIE22DwO0VNGUJ";
            client = new RestClient();
            request = new RestRequest(getUrl);
            request.AddHeader("Authorization", "Token" + token);
            response = client.Post(request);
            Assert.AreEqual(201, (int)response.StatusCode);
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
        public void UpdatePlaylist()
        {
            string token = "Bearer BQCDEXtA85NRW4j9jdKMx7XSNJZmb1v6Weo3iW3xkwi2UWiQdH2w35Y-l52o3_CsSjlRETr4SpJbyXruiW3GtPet45IJAOCFzyawDPJQpKJWXM5R0oZBij33wncCr4ckGxlTAbBant_2k8NGy7bbKBnsfhdq2scfXWZ3ciAXCrqKRFacw6ldfhi1Gno-EdGk1gnfDXAHV19n3kczuqrbSn2vV45kgTGSOfs4L-YpJIPTuC6fAOyHD4hyFbQ4LkmNbA3SFMUeR5YsmcAtmWZ1YUVaIuZ_dUJszkEQ6jKB";
            string getUrl = "https://api.spotify.com/v1/playlists/1VycgeJFTpPqvyfKJNqQph";
            string jsonBody = "{" +
                                 "\"name\":\"girish\"," +
                                 "\"description\": \"favorite songs\"," +
                                  "\"public\": false" +
                               "}";
            client = new RestClient();
            request = new RestRequest(getUrl);
            request.AddHeader("Authorization", "Token" + token);
            request.AddJsonBody(jsonBody);
            response = client.Put(request);
            Assert.AreEqual(200, (int)response.StatusCode);
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