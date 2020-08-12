using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1_Diplomado_Web_MVC_USAD.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            // return View();
            return "<html><body>" +"<h1>Universidad Auntonoma de Santo Domingo (UASD)</h1>"
                +"<p>Diplomado de Desarrollo Web C#, MVC</p>"
                +"</body></html>";
        }
        public string DiplomadoWeb()
        {
            return "<html><body>" 
                +"<h1>Estudiante:</h1>"
                +"<p>Raul Santos<br>"
                +"Anthony perez<br>"
                +"Anthony martinez <br>"
                +"Sabiel martinez</p>"
                + "</body></html>";
        }
    }
}