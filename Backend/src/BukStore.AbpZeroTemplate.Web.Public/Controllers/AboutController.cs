using Microsoft.AspNetCore.Mvc;
using BukStore.AbpZeroTemplate.Web.Controllers;

namespace BukStore.AbpZeroTemplate.Web.Public.Controllers
{
    public class AboutController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}