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

            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);

            JObject json = JObject.Parse(response.Content);

            int length = Int32.Parse(json["total"].ToString());

            songs = new List<Song>();
            foreach (var item in json["items"])
            {
                string timeMs = TimeSpan.FromMilliseconds((double)item["track"]["duration_ms"]).TotalSeconds.ToString();
                songs.Add(new Song(item["track"]["name"].ToString(), item["track"]["artists"][0]["name"].ToString(), item["added_at"].ToString(), timeMs));
            
            }

            int i = 1;

            foreach (Song song in songs)
            {
                TableRow newRow = new TableRow();
                songsTable.Controls.Add(newRow);

                TableCell newCell = new TableCell();
                newCell.Text = i.ToString();
                newRow.Controls.Add(newCell);
                i++;

                newCell = new TableCell();
                newCell.Text = song.Title;
                newRow.Controls.Add(newCell);

                newCell = new TableCell();
                newCell.Text = song.Artist;
                newRow.Controls.Add(newCell);

                newCell = new TableCell();
                newCell.Text = song.DateAdded;
                newRow.Controls.Add(newCell);

                newCell = new TableCell();
                newCell.Text = song.Time;
                newRow.Controls.Add(newCell);

            }


/*
            for (int row = 1; row < length; row++)
            {


                for (int column = 0; column < 4; column++)
                {
                    newCell.Text = "Cell" + column.ToString();
                    newRow.Controls.Add(newCell);
                }
            }*/



        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}