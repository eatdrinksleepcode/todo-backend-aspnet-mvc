using System.Web.Mvc;

namespace TodoBackend
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
