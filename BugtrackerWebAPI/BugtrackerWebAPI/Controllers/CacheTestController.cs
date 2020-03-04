using System;
using Bugtracker.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace BugtrackerWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CacheTestController : ControllerBase
    {
        private IMemoryCache _cache;

        public CacheTestController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpPost]
        public IActionResult Save(User user)
        {
            _cache.Set(user.Id, user, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            User user = null;
            _cache.TryGetValue(id, out user);
            return Ok();
        }
    }
}