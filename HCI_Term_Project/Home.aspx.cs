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

            const string TOKEN = "BQCDUZxWtOdkltwFizh7ZxTRbpwWLnh40wFGU2kS1F6-1d9FHcMJzfPTb5_qYBoCspZYNvIDq5AZvrCZ72isQJIvq7vaUae2CUPKqrWLpdBsCiqKTzmLlf9b7RIz4CAPlnDA9lclWUl2ryoWeLASK66Vzsj0MieDgg";

            Session["token"] = "Bearer " + TOKEN;

            var client = new RestClient("https://api.spotify.com/v1/me");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", Session["token"].ToString());
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