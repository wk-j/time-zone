using System;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers {

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase {

        public ActionResult<Object> Tz() {
            return TimeZoneInfo.Local;
        }
    }
}