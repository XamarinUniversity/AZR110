using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using Microsoft.Azure.Mobile.Server;
using SurveyAppService.DataObjects;
using SurveyAppService.Models;

namespace SurveyAppService.Controllers
{
    public class QuestionsController : TableController<SurveyQuestion>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<SurveyQuestion>(context, Request);
        }

        // GET tables/Questions
        public IQueryable<SurveyQuestion> GetAllSurveyQuestion()
        {
            return Query();
        }

        // GET tables/Questions/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SurveyQuestion> GetSurveyQuestion(string id)
        {
            return Lookup(id);
        }
    }
}
