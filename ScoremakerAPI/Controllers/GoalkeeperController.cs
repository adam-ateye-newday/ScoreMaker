using ScoreMaker.Library;
using Microsoft.AspNetCore.Mvc;

namespace ScoremakerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoalkeeperController : ControllerBase
    {
        private readonly ILogger<GoalkeeperController> _logger;

        public GoalkeeperController(ILogger<GoalkeeperController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostGoalkeeperScore")]
        public int PostGoalkeeperScore([FromBody] Goalkeeper goalkeeper)
        {
            return new ScoremakerGK().AverageScoreGoalkeeper(goalkeeper);
        }
    }
}