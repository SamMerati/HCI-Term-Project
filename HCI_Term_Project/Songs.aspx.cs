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
    public partial class About : Page
    {

        private List<Song> songs;

        protected void Page_Load(object sender, EventArgs e)
        {

            var client = new RestClient("https://api.spotify.com/v1/me/tracks?scopes=user-library-read");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);


/*            JObject token = JObject.Parse(retrieveToken());
*/
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);



            JObject json = JObject.Parse(response.Content);



/*            Label1.Text = json["items"].ToString();
*/            int length = Int32.Parse(json["total"].ToString());

            songs = new List<Song>();
            foreach (var item in json["items"])
            {
                Label1.Text = item.ToString();

                /*                songs.Add(new Song("item["name"].ToString()", item["artists"][0]["name"].ToString(), item["added_at"].ToString(), "ASD"));
                */
                songs.Add(new Song("hi", "bye", "no", "yes"));
            
            }



            for (int row = 1; row < length; row++)
            {
                TableRow newRow = new TableRow();
                songsTable.Controls.Add(newRow);
                for (int column = 0; column < 4; column++)
                {
                    TableCell newCell = new TableCell();
                    newCell.Text = "Cell" + column.ToString();
/*                  newCell.Text += "; Column" + column.ToString();
*/                  newRow.Controls.Add(newCell);
                }
            }



        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}