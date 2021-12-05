using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HCI_Term_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var loginRequest = new LoginRequest(
              new Uri("https://localhost:44354/Home"),
              "55f51ee8aa504686a72034c437db139d",
              LoginRequest.ResponseType.Code
)
            {
                Scope = new[] { Scopes.PlaylistReadPrivate, Scopes.PlaylistReadCollaborative, Scopes.UserLibraryRead, Scopes.UserFollowRead, Scopes.UserModifyPlaybackState, Scopes.UserReadCurrentlyPlaying, Scopes.UserReadPlaybackState, Scopes.UserReadPrivate}
            };
            var uri = loginRequest.ToUri();
            BrowserUtil.Open(uri);
        }
    }
}