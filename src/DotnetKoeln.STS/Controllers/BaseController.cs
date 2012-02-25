using System.Web.Mvc;
using Aperea.ActionFilter;

namespace DotnetKoeln.STS.Controllers
{
    [RequireSsl]
    public class BaseController : Controller
    {
    }
}