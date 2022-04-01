using _1911065068_VuPhiTruong_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1911065068_VuPhiTruong_BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống")]
        [FutureDate]
        public string Date { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống")]
        [ValidTime]
        public string Time { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống")]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }

} 