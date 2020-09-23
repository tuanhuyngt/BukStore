using Microsoft.AspNetCore.Mvc;
using BukStore.AbpZeroTemplate.Web.Controllers;

namespace BukStore.AbpZeroTemplate.Web.Public.Controllers
{
    public class HomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}