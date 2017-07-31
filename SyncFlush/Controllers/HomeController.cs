using System.Threading;
using System.Web.Mvc;

namespace SyncFlush.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Sync Flush";
            ViewBag.HeadFlushed = true;

            PartialView("_Head").ExecuteResult(ControllerContext);
            Response.Flush();

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