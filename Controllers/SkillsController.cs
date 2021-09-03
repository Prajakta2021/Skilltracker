using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        // GET: SkillsController
        [HttpGet]
        public ActionResult Index()
        {
            string html = "<h1>" + "Skills tracker" + "<h1>" +
                          "<br>" +"<h2>" + "Coding skills to learn:" + "<h2>" +"<br>" +
                          "<ol>" +
                            "<li> C# </li>" + "<br>" +
                            "<li> JavaScript </li>" + "<br>" +
                           " <li> Python </li>" + "<br>" +
                          "</ol>";

                          return Content(html, "text/html");

         }
        //GET: /skills/form
        [HttpGet]        
        [Route("/skills/form")]
        public ActionResult Form() {

            string html = "<form method='post' action ='/skills/form/skillTracker'>" +

                             "<h1> Date :</h1>" + "<br>" +
                            "<input type = 'date' id = 'date' name = 'date'><br/>" +
                            "<h1> C# :</h1>" + 
                        "<select name = 'cSharp'>" +
                                 "<option value='learning basics'>Learning basics</option >" +
                                 "<option value='making apps'>Making apps</option >" +
                                 "<option value='master coder'>Master coser</option >" +
                        "</select>" + "<br>" +

                        "<h1> JavaScript :</h1>"  +
                        "<select name = 'javascript'>" +
                            "<option value='learning basics'>Learning basics</option >" +
                            "<option value='making apps'>Making apps</option >" +
                            "<option value='master coder'>Master coser</option >" +
                        "</select>" + "<br>" +

                       "<h1> Python :</h1>" + 
                       "<select = name = 'python'>" +
                            "<option value='learning basics'>Learning basics</option >" +
                            "<option value='making apps'>Making apps</option >" +
                            "<option value='master coder'>Master coser</option >" +
                       "</select>" + "<br>" +
                    "<input type='submit' value='Submit'/>" +
                      "</form>";   
     
            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form/skillTracker")]
        public ActionResult SkillTracker(string date, string cSharp, string javaScript, string python)
        {
            string html =
                "<h1>" + date + "</h1>" +
                "<ol>" +
                    "<li> C#: " + cSharp + "</li>" +
                    "<li> JavaScript: " + javaScript + "</li>" +
                    "<li> Python: " + python + "</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

    }
}
