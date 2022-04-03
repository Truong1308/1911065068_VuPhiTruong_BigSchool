using _1911065068_VuPhiTruong_BigSchool.Models;
using System.Collections.Generic;

namespace _1911065068_VuPhiTruong_BigSchool.Controllers
{
    internal class FollowingViewModel
    {
        public List<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}