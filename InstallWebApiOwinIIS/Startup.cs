using InstallWebApiOwinIIS.Config;
using Owin;
using System.Web.Http;

namespace InstallWebApiOwinIIS
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);
 
            app.UseWebApi(config);
        }
    }
}