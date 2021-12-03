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

        private List<Song> songs = new List<Song>();

        protected void Page_Load(object sender, EventArgs e)
        {

            var client = new RestClient("https://api.spotify.com/v1/me/tracks?scopes=user-library-read");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", Session["token"].ToString());
            IRestResponse response = client.Execute(request);



            /*            JObject json = JObject.Parse(response.Content);
            */

            Label1.Text = response.Content.ToString();

            for (int row = 1; row < 4; row++)
            {
                TableRow newRow = new TableRow();
                songsTable.Controls.Add(newRow);
                for (int column = 0; column < 4; column++)
                {
                    TableCell newCell = new TableCell();
                    newCell.Text = "Cell" + row.ToString();
                    newCell.Text += "; Column" + column.ToString();
                    newRow.Controls.Add(newCell);
                }
            }


/*            foreach (Song song in songs)
            {
                TableRow row = new TableRow();

                for (int i = 0; i < 4; ++i)
                {
                    TableCell cell = new TableCell();
                    cell.Text = "asd";
                    row.Cells.Add(cell);
                }
                songsTable.Rows.Add(row);
            }*/

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}