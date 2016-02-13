using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(ArtistReview.Web.Startup))]

namespace ArtistReview.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
