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


            const string TOKEN = "BQA08frd_GdaQFwzaPpE9JWigm1Ki6esroMw5MDwy_XshSkLP50Q30G8ycyCrdcVMD5l7ItKTKaizdw11UQGJrnRuQhOC_iMze8HoYPtKDJTQ9H1R-IeB7MCBUA_m6-ak9Kp6L_m7x3GQRX7atkWgFAxItOQ86GTdZlfHjGQ-6Y";

            Session["token"] = "Bearer " + TOKEN;

            var client = new RestClient("https://api.spotify.com/v1/me");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);
            /*            Console.WriteLine(response.Content);
            */
            JObject json = JObject.Parse(response.Content);

            var client2 = new RestClient("https://api.spotify.com/v1/me/playlists");
            client2.Timeout = -1;
            var request2 = new RestRequest(Method.GET);
            request2.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response2 = client2.Execute(request2);
            /*            Console.WriteLine(response.Content);
            */
            JObject json2 = JObject.Parse(response2.Content);

            var client3 = new RestClient("https://api.spotify.com/v1/me/following?type=artist");
            client3.Timeout = -1;
            var request3 = new RestRequest(Method.GET);
            request3.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response3 = client3.Execute(request3);
            JObject json3 = JObject.Parse(response3.Content);

            profilePic.ImageUrl = json["images"][0]["url"].ToString();
            usernameText.Text = json["display_name"].ToString();
            followersText.Text = json["followers"]["total"].ToString();
            playlistsText.Text = json2["total"].ToString();
            followingText.Text = json3["artists"]["total"].ToString();


        }
    }
}