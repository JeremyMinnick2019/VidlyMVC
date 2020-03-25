using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;

namespace Vidly.Controllers
{
 
    public class MoviesController : Controller
    {
        [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }       
}