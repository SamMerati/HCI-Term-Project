using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HCI_Term_Project
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var client = new RestClient("https://api.spotify.com/v1/me");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer BQCoDH7t3lRmUf_WU772rc5hxkcBVqg8BD2iZ1DMVdn0yq4PSC04-6dBcRNsE6n1ChPXCsQqPqbJcpbIwCKuy-jtMGBL6uXrCrhAWGNL_AYKiZ6HvLE2qsvD4Y8fGxMTepcydB306ShFsCKbeyJfH-bkJgLFHCe5nw");
            IRestResponse response = client.Execute(request);
/*            Console.WriteLine(response.Content);
*/
            JObject json = JObject.Parse(response.Content);

            profilePic.ImageUrl = json["images"][0]["url"].ToString();
            usernameText.Text = json["id"].ToString();
            followersText.Text = json["followers"]["total"].ToString();


        }
    }
}