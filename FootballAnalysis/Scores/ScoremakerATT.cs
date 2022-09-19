using FootballAnalysis.Players;
using System;
public class ScoremakerATT
{
    public int RateGoals(Attacker attacker)
    {
        var goals = attacker.Goals;
        int score = 0;
        if (goals <= 0)
        {
            score = 0;
        }
        else if (goals <= 10)
        {
            score = 1;
        }
        else if (goals <= 20)
        {
            score = 2;
        }
        else if (goals <= 30)
        {
            score = 3;
        }
        return score;
    }

    public int RateAssists(Attacker attacker)
    {
        var assists = attacker.Assists;
        int score = 0;
        if (assists == 0)
        {
            score = 0;
        }
        else if (assists <= 5)
        {
            score = 1;
        }
        else if (assists <= 10)
        {
            score = 2;
        }
        else if (assists <= 20)
        {
            score = 3;
        } 
        return score;
    }

    public int RateAppearances(Attacker attacker)
    {
        var appearances = attacker.Appearances;
        int score = 0;
        if (appearances <= 0)
        {
            score = 0;
        }
        else if (appearances <= 20)
        {
            score = 4;
        }
        else if (appearances <= 30)
        {
            score = 3;
        }
        else if (appearances <= 38)
        {
            score = 2;
        }
        return score;
    }


    public int AverageScoreAttacker(Attacker attacker)
    {
        int score = RateGoals(attacker) + RateAssists(attacker) + RateAppearances(attacker);
        return score;
    }

}
