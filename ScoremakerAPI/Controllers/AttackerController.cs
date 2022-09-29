using ScoreMaker.Library;
using Microsoft.AspNetCore.Mvc;

namespace ScoremakerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttackerController : ControllerBase
    {
        private readonly ILogger<AttackerController> _logger;

        public AttackerController(ILogger<AttackerController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostAttackerScore")]
        public int PostAttackerScore([FromBody]Attacker attacker)
        {
            return new ScoremakerATT().AverageScoreAttacker(attacker);
        }
    }
}