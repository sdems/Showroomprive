using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private CourseDao _courseDao;

        public CourseDao CourseDao
        {
            get
            {
                if (_courseDao == null)
                {
                    _courseDao = new CourseDao();
                }
                return _courseDao; 
            }
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            IList<Course> raceList = CourseDao.getAllRace();

            ViewData["AllRaces"] = raceList;

            return View();
        }

        [HttpGet]
        public JsonResult GetDetails(int raceId)
        {
            Course course = new Course(raceId);

            return Json(CourseDao.getRunners(course), JsonRequestBehavior.AllowGet);   
        }
    }
}
