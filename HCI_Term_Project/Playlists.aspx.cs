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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var client = new RestClient("https://api.spotify.com/v1/me/playlists?limit=20&offset=5");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);

            JObject json = JObject.Parse(response.Content);

            playlistsItems.Text = json["href"].ToString();



        }
    }
}