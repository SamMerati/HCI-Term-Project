using Newtonsoft.Json.Linq;
using RestSharp;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


            newCode = HttpContext.Current.Request.Url.PathAndQuery.Replace("/Home?code=", "");
            JObject token = JObject.Parse(retrieveToken());

            //string TOKEN = token["access_token"].ToString();

            string TOKEN = "BQBdL4wdrpCHTGHZFNMZPs-fYcdoJo3ITPvQV3ocNQPZLCkp6YffGGeq_MHIewpyg0PkhtQ1zDFr7Bi9xNuhdzRWo08pLQibG7JmVuwsSIoPn0vxAdQTi6gNqPzn3UKCn7Rqh59FlJPVksImAmfHVM0xedAhH24IuE_YbmEXIY9yy5dxvU-clRzY3KVjlFQ2FqMC-t71lansfDpYN-j4iitcNmFBQ613Fb7h4a01mk5VRqg";

            Session["token"] = "Bearer " + TOKEN;

            var client = new RestClient("https://api.spotify.com/v1/me");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);

            var client2 = new RestClient("https://api.spotify.com/v1/me/playlists");
            client2.Timeout = -1;
            var request2 = new RestRequest(Method.GET);
            request2.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response2 = client2.Execute(request2);
            JObject json2 = JObject.Parse(response2.Content);

            var client3 = new RestClient("https://api.spotify.com/v1/me/following?type=artist");
            client3.Timeout = -1;
            var request3 = new RestRequest(Method.GET);
            request3.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response3 = client3.Execute(request3);
            JObject json3 = JObject.Parse(response3.Content);

            var client4 = new RestClient("https://api.spotify.com/v1/me/player/currently-playing");
            client4.Timeout = -1;
            var request4 = new RestRequest(Method.GET);
            request4.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response4 = client4.Execute(request4);

            //var client5 = new RestClient("https://api.spotify.com/v1/me/player");
            //client5.Timeout = -1;
            //var request5 = new RestRequest(Method.GET);
            //request5.AddHeader("Authorization", Session["token"].ToString());
            //IRestResponse response5 = client5.Execute(request5);
            //JObject json5 = JObject.Parse(response5.Content);
            //string isActive = json5["device"]["is_active"].ToString();

            profilePic.ImageUrl = json["images"][0]["url"].ToString();
            usernameText.Text = json["display_name"].ToString();
            followersText.Text = json["followers"]["total"].ToString();
            playlistsText.Text = json2["total"].ToString();
            followingText.Text = json3["artists"]["total"].ToString();
            try
            {
                JObject json4 = JObject.Parse(response4.Content);
                currentImage.ImageUrl = json4["item"]["album"]["images"][0]["url"].ToString();
                currentSong.Text = json4["item"]["name"].ToString() + " - " + json4["item"]["artists"][0]["name"].ToString();
            }
            catch(Newtonsoft.Json.JsonReaderException)
            {
                currentSong.Text = "No Song is currently playing";

            }
        }

        public async Task GetCallback(string code)
        {
            //var response = await new OAuthClient().RequestToken(
             // new AuthorizationCodeTokenRequest("55f51ee8aa504686a72034c437db139d", "99048e5815a84baa90ec87abd18817bb", code, "http://localhost:44354/Home")
            //);

            //var spotify = new SpotifyClient(response.AccessToken);
            // Also important for later: response.RefreshToken
        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.Text == "▶️")
            {
                Play();
            }
            else if (playButton.Text == "⏸")
            {
                Pause();
            }
        }

        private void Play()
        {
            playButton.Text = "⏸";
            var client = new RestClient("https://api.spotify.com/v1/me/player/play");
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);

            var client4 = new RestClient("https://api.spotify.com/v1/me/player/currently-playing");
            client4.Timeout = -1;
            var request4 = new RestRequest(Method.GET);
            request4.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response4 = client4.Execute(request4);
            JObject json4 = JObject.Parse(response4.Content);
            currentImage.ImageUrl = json4["item"]["album"]["images"][0]["url"].ToString();
            currentSong.Text = json4["item"]["name"].ToString() + " - " + json4["item"]["artists"][0]["name"].ToString();
        }

        private void Pause()
        {
            playButton.Text = "▶️";
            var client = new RestClient("https://api.spotify.com/v1/me/player/pause");
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);
            var client4 = new RestClient("https://api.spotify.com/v1/me/player/currently-playing");
            client4.Timeout = -1;
            var request4 = new RestRequest(Method.GET);
            request4.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response4 = client4.Execute(request4);
            JObject json4 = JObject.Parse(response4.Content);
            currentImage.ImageUrl = json4["item"]["album"]["images"][0]["url"].ToString();
            currentSong.Text = json4["item"]["name"].ToString() + " - " + json4["item"]["artists"][0]["name"].ToString();
        }

        protected void forwardButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.spotify.com/v1/me/player/next");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);
            Play();
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.spotify.com/v1/me/player/previous");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);
            Play();
        }
    }
}