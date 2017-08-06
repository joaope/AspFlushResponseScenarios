using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AsyncFlush.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Async Flush";
            ViewBag.HeadFlushed = true;

            PartialView("_Head").ExecuteResult(ControllerContext);
            await Task.Factory.FromAsync(Response.BeginFlush, Response.EndFlush, null);

            Thread.Sleep(1000);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}