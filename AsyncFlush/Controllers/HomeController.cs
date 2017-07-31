using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AsyncFlush.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Async Flush";
            ViewBag.HeadFlushed = true;

            PartialView("_Head").ExecuteResult(ControllerContext);

            ViewResult bodyResult = null;

            Response.BeginFlush(ar =>
            {
                Response.EndFlush(ar);

                Thread.Sleep(1000);

                // var model = (MyViewModel)ar.AsyncState // get model here from passed state

                bodyResult = View();
            }, 
            null); // you should pass the model here, if there's one already

            return bodyResult;
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