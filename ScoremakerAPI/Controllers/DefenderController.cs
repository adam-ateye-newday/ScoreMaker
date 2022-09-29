using ScoreMaker.Library;
using Microsoft.AspNetCore.Mvc;

namespace ScoremakerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefenderController : ControllerBase
    {
        private readonly ILogger<DefenderController> _logger;

        public DefenderController(ILogger<DefenderController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostDefenderScore")]
        public int PostDefenderScore([FromBody] Defender defender)
        {
            return new ScoremakerDEF().AverageScoreDefender(defender);
        }
    }
}