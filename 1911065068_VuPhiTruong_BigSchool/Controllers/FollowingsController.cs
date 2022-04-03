using _1911065068_VuPhiTruong_BigSchool.DTOs;
using _1911065068_VuPhiTruong_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911065068_VuPhiTruong_BigSchool.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _DbContext;
        public FollowingsController()
        {
            _DbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_DbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following Already Axists !");


            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };

            _DbContext.Followings.Add(folowing);
            _DbContext.SaveChanges();
            return Ok();
        }
    }
}
