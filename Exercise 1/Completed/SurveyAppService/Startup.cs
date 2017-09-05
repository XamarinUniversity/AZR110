using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SurveyAppService.Startup))]

namespace SurveyAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}