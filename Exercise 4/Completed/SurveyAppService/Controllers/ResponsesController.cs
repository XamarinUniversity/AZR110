using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using SurveyAppService.DataObjects;
using SurveyAppService.Models;

namespace SurveyAppService.Controllers
{
    public class ResponsesController : TableController<SurveyResponse>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<SurveyResponse>(context, Request);
        }

        // GET tables/Responses
        public IQueryable<SurveyResponse> GetAllSurveyResponse()
        {
            return Query();
        }

        // GET tables/Responses/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SurveyResponse> GetSurveyResponse(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Responses/48D68C86-6EA6-4C25-AA33-223FC9A27959
        [HttpPatch]
        public Task<SurveyResponse> UpdateSurveyResponse(string id, Delta<SurveyResponse> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Responses
        [HttpPost]
        public async Task<IHttpActionResult> InsertSurveyResponse(SurveyResponse item)
        {
            SurveyResponse current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Responses/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSurveyResponse(string id)
        {
             return DeleteAsync(id);
        }
    }
}
