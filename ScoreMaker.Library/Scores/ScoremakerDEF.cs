using ScoreMaker.Library;
using System;

public class ScoremakerDEF
{
    public int RateClearances(Defender defender)
    {
        var clearances = defender.Clearances;
        int score = 0;
        if (clearances <= 0)
        {
            score = 0;
        }
        else if (clearances <= 80)
        {
            score = 1;
        }
        else if (clearances <= 100)
        {
            score = 2;
        }
        else if (clearances <= 120)
        {
            score = 3;
        }
        return score;
    }

    public int RateInterceptions(Defender defender)
    {
        var interceptions = defender.Interceptions;
        int score = 0;
        if (interceptions <= 0)
        {
            score = 0;
        }
        else if (interceptions <= 20)
        {
            score = 1;
        }
        else if (interceptions <= 40)
        {
            score = 2;
        }
        else if (interceptions <= 60)
        {
            score = 3;
        }
        return score;
    }

    public int RateAppearances(Defender defender)
    {
        var appearances = defender.Appearances;
        int score = 0;
        if (appearances <= 0)
        {
            score = 0;
        }
        else if (appearances <= 15)
        {
            score = 4;
        }
        else if (appearances <= 30)
        {
            score = 3;
        }
        else if (appearances <= 45)
        {
            score = 2;
        }
        return score;
    }

    public int AverageScoreDefender(Defender defender)
    {
        int score = RateClearances(defender) + RateInterceptions(defender) + RateAppearances(defender);
        return score;
    }
}