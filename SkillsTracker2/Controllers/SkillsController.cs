using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker2.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = @"<h1>Skills Track </h1>
            <h2>
                <ol>
                    <li>C# </li>
                    <li>JavaScript </li>
                    <li>Python </li>
                </ol>
            </h2>";
            return Content(html, "text/html");
        }


        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = @"<form method='post'>
        <h2>Date:
        <br />
        <input type='date' name='Date'>
        </h2>

        <h2>C#:
        <br />
        <select name = 'C#skills' >
            <option value='learning basics'>Learning Basics</option>
            <option value='making apps'>Making Apps</option>
            <option value='master coder'>Master Coder</option>
        </select>
        </h2>

        <h2>JavaScript:
        <br />
        <select name = 'JavaScriptskills' >
            <option value='learning basics'>Learning Basics</option>
            <option value='making apps'>Making Apps</option>
            <option value='master coder'>Master Coder</option>
        </select>
        <h2>

        <h2>Python:
        <br />
        <select name = 'Pythonskills' >
            <option value='learning basics'>Learning Basics</option>
            <option value='making apps'>Making Apps</option>
            <option value='master coder'>Master Coder</option>
        </select>
        </h2>

           <br />

        <input type='submit' value='Submit'/>

        </form>";

            return Content(html, "text/html");
        }


        /*
        [HttpPost]
        [Route("/skills/form")]
        public IActionResult Skills()
        {
            return Content("<h1>{date}</h1>" +
                 "<ol>" +
                    "<li>C#:{ </li>" +
                    < li > JavaScript </ li >
                    < li > Python </ li >
                </ ol >);
        }
        */
    }
}
