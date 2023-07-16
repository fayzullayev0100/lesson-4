class Player : IBaseballPlayer, ISoccerPlayer
{
    public string sport{get; set;}
    public string team{get; set;}
    public string position{get; set;}
    public string first{get; set;}
    public string last{get; set;}
    public int atBats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int hits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double innings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int earnetRuns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int minutes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int goals { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int goalsAllowed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public double averageGoalsAllowed()
    {
        throw new NotImplementedException();
    }

    public double earnetRunAverage()
    {
        throw new NotImplementedException();
    }
}