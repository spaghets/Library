using System.Web.Mvc;

namespace Library.Controllers
{
    public class MainController : Controller
    {
        // GET
        public string Test()
        {
            return "It's working";
        }

        public ActionResult Index()
        {
            
        }
    }
    
}