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

        private string newCode;


        public string retrieveToken()
        {
            var client2 = new RestClient("https://accounts.spotify.com/api/token");
            client2.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic NTVmNTFlZThhYTUwNDY4NmE3MjAzNGM0MzdkYjEzOWQ6OTkwNDhlNTgxNWE4NGJhYTkwZWM4N2FiZDE4ODE3YmI=");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cookie", "__Host-device_id=AQBzHprmce7vV0zquGWFz8MIG1-4BMJ_ngYsJgtVzaYzvrN3if15VmEGQTb_2BXY7J9cubgr0fJUxvgm28St9Rxk3cYQTDEkzGQ; sp_tr=false");
            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("code", newCode);
            request.AddParameter("redirect_uri", "https://localhost:44354/Home");
            IRestResponse response = client2.Execute(request);
            return response.Content;

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            this.newCode = HttpContext.Current.Request.Url.PathAndQuery.Replace("/Home?code=", "");
            JObject token = JObject.Parse(retrieveToken());

            string TOKEN = token["access_token"].ToString();

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