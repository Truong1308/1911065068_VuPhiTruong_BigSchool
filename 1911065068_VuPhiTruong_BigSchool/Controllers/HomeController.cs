using _1911065068_VuPhiTruong_BigSchool.Models;
using _1911065068_VuPhiTruong_BigSchool.ViewModels;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _1911065068_VuPhiTruong_BigSchool.Controllers
{
    public class HomeController : Controller
    {
            private ApplicationDbContext _dbContext;


            public HomeController()
            {
                _dbContext = new ApplicationDbContext();
            }


            public ActionResult Index()
            {
                var upcommingCourses = _dbContext.Course
                   .Include(c => c.Lecturer)
                   .Include(c => c.Category)
                   .Where(c => c.DateTime > DateTime.Now);

                var viewModel = new CourseViewModel
                {
                    UpcomingCourse = upcommingCourses,
                    ShowAction = User.Identity.IsAuthenticated
                };
                return View(viewModel);
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