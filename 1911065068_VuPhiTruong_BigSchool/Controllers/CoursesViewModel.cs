using _1911065068_VuPhiTruong_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1911065068_VuPhiTruong_BigSchool.Controllers
{
    internal class CoursesViewModel
    {
        public IQueryable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}