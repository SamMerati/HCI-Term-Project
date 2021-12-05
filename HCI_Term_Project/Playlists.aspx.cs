using Newtonsoft.Json;
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
        List<string> names = new List<string>();
        List<string> urls = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {

            var client = new RestClient("https://api.spotify.com/v1/me/playlists");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);
            JObject json = JObject.Parse(response.Content);
            for (int i = 0; i < Int32.Parse(json["total"].ToString()); i++)
            {
                urls.Add(json["items"][i]["images"][0]["url"].ToString());
                names.Add(json["items"][i]["name"].ToString());
            }

            for (int i = 0; i < names.Count; i++)
            {
                Image image = new Image
                {
                    ImageUrl = urls[i],
                    Width = 200,
                    Height = 200
                };
                TableRow newRow = new TableRow();
                playlistTable.Controls.Add(newRow);

                TableCell newCell = new TableCell();
                newCell.Controls.Add(image);
                newRow.Controls.Add(newCell);

                newCell = new TableCell();
                newCell.Text = names[i];
                newCell.Font.Size = 16;
                newRow.Controls.Add(newCell);
            }
        }
    }
}