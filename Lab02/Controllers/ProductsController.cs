using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public string Index()
        {
            return "I wasn't given instructions for what the default action should display for THIS controller";
        }

        // GET: Products/Browse
        public string Browse()
        {
            return "Browse displayed";
        }

        // GET: Products/Details/105
        public string Details(int id)
        {
            return "Details displayed for Id=" + id;
        }

        // GET: Products/Location?zip=44124
        // Note: a string parameter will allow a 9 digit zip with a hyphen
        public string Location(string zip)
        {
            return HttpUtility.HtmlEncode("Location displayed for zip=" + zip);
        }
    }
}