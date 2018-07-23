using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AspNetControllerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // This will provide an empty array in `user` when calling /api/values/implicit?user=a
        [HttpGet("implicit")]
        public ActionResult<IEnumerable<string>> GetImplict([FromQuery] string[] user)
        {
            return user;
        }

        // This will provide the expected values in `user` when calling /api/values/explicit?user=a
        [HttpGet("explicit")]
        public ActionResult<IEnumerable<string>> GetExplicit([FromQuery(Name = "user")] string[] user)
        {
            return user;
        }
    }
}
