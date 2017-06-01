using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace vssummit2017_api_01
{
    public class HomeController : Controller
    {
        [HttpGet("api/")]
        public IActionResult Get()
        {
            var result = new List<Speaker>();
            result.Add(new Speaker { Name = "André Baltieri", Email = "hello@balta.io" });
            return Ok(result);
        }
    }

    public class Speaker
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}