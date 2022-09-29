using ScoreMaker.Library;

namespace ScoreMaker.Test
{
    public class ScoremakerTests
    {
        [Fact]
        public void ScoremakerAttackerTestSalah()
        {
            var attacker = new Attacker(23,13,35);
            var score = new ScoremakerATT();
            var actualScore = score.AverageScoreAttacker(attacker);
            actualScore.Should().Be(8);
        }

        [Fact]
        public void ScoremakerAttackerTestDeBruyne()
        {
            var attacker = new Attacker(15, 8, 30);
            var score = new ScoremakerATT();
            var actualScore = score.AverageScoreAttacker(attacker);
            actualScore.Should().Be(7);
        }

        [Fact]
        public void ScoremakerAttackerTestSon()
        {
            var attacker = new Attacker(23, 7, 35);
            var score = new ScoremakerATT();
            var actualScore = score.AverageScoreAttacker(attacker);
            actualScore.Should().Be(7);
        }
        [Fact]
        public void ScoremakerDefenderTestVanDijk()
        {
            var defender = new Defender(107, 31, 34);
            var score = new ScoremakerDEF();
            var actualScore = score.AverageScoreDefender(defender);
            actualScore.Should().Be(7);
        }

        [Fact]
        public void ScoremakerDefenderTestThiagoSilva()
        {
            var defender = new Defender(95, 44, 32);
            var score = new ScoremakerDEF();
            var actualScore = score.AverageScoreDefender(defender);
            actualScore.Should().Be(7);
        }

        [Fact]
        public void ScoremakerDefenderTestRudiger()
        {
            var defender = new Defender(87, 28, 34);
            var score = new ScoremakerDEF();
            var actualScore = score.AverageScoreDefender(defender);
            actualScore.Should().Be(6);
        }
        [Fact]
        public void ScoremakerGoalkeeperTestEderson()
        {
            var goalkeeper = new Goalkeeper(60, 20, 26, 19, 37);
            var score = new ScoremakerGK();
            var actualScore = score.AverageScoreGoalkeeper(goalkeeper);
            actualScore.Should().Be(6);
        }
        [Fact]
        public void ScoremakerGoalkeeperTestAlisson()
        {
            var goalkeeper = new Goalkeeper(76, 20, 24, 30, 36);
            var score = new ScoremakerGK();
            var actualScore = score.AverageScoreGoalkeeper(goalkeeper);
            actualScore.Should().Be(7);
        }
        [Fact]
        public void ScoremakerGoalkeeperTestMendy()
        {
            var goalkeeper = new Goalkeeper(73, 14, 31, 19, 34);
            var score = new ScoremakerGK();
            var actualScore = score.AverageScoreGoalkeeper(goalkeeper);
            actualScore.Should().Be(6);
        }
    }
}