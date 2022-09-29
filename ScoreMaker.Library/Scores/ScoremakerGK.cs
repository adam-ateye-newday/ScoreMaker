using ScoreMaker.Library;
using System;

public class ScoremakerGK
{
    public int RateSaves(Goalkeeper goalkeeper)
    {
        var saves = goalkeeper.Saves;
        if (saves <= 150 && saves > 100)
        {
            saves = 2;
        }
        if (saves <= 100 && saves > 50)
        {
            saves = 1;
        }
        return saves;
    }
    public int RateCleansheets(Goalkeeper goalkeeper)
    {
        var cleansheets = goalkeeper.Cleansheets;
        if (cleansheets <= 30 && cleansheets > 15)
        {
            cleansheets = 2;
        }
        if (cleansheets <= 15 && cleansheets > 1)
        {
            cleansheets = 1;
        }
        return cleansheets;
    }
    public int RateConceded(Goalkeeper goalkeeper)
    {
        var conceded = goalkeeper.Conceded;
        if (conceded <= 25 && conceded > 20)
        {
            conceded = 2;
        }
        if (conceded <= 100 && conceded > 20)
        {
            conceded = 1;
        }
        return conceded;
    }
    public int RateSweeps(Goalkeeper goalkeeper)
    {
        var sweeps = goalkeeper.Sweeps;
        if (sweeps <= 30 && sweeps > 10)
        {
            sweeps = 2;
        }
        if (sweeps <= 10 && sweeps > 0)
        {
            sweeps = 1;
        }
        return sweeps;
    }
    public int RateAppearances(Goalkeeper goalkeeper)
    {
        var appearances = goalkeeper.Appearances;
        if (appearances <= 20 && appearances > 0)
        {
            appearances = 1;
        }
        if (appearances <= 40 && appearances > 20)
        {
            appearances = 2;
        }
        return appearances;
    }
    public int AverageScoreGoalkeeper(Goalkeeper goalkeeper)
    {
        int score = RateSaves(goalkeeper) + RateCleansheets(goalkeeper) + RateConceded(goalkeeper) + RateSweeps(goalkeeper) + RateAppearances(goalkeeper);
        return score;
    }

}
