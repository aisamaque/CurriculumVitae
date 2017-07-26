using AutoMapper;
using CurriculumVitae.Domain.Interfaces.Application;
using CurriculumVitae.WEBApi.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CurriculumVitae.WEBApi.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class ProfileController : ApiController
    {
        private readonly IProfileApplication _profileService;

        public ProfileController(IProfileApplication profileService)
        {
            _profileService = profileService;
        }

        [Route("profiles")]
        public HttpResponseMessage Get()
        {
            return Get(1);
        }

        [Route("profiles/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var ret = _profileService.GetById(id);
                var retView = Mapper.Map<Domain.Models.Profile, ProfileViewModel>(ret);
                return retView != null ? Request.CreateResponse(HttpStatusCode.OK, retView) : Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "");
            }
        }


    }
}
