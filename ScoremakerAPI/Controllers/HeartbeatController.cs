using Microsoft.AspNetCore.Mvc;

namespace ScoreMaker.API.Controllers
{
    /// <summary>
    /// Class HeartbeatController.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Route("api/[controller]")]
    public class HeartbeatController : Controller
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>System.String.</returns>
        [HttpGet]
        public string Get() => "OK";
    }
}
