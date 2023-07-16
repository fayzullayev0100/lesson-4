interface ISoccerPlayer : IGoalie
{
    public int minutes{get;set;}
    public int goals{get;set;}
    public int goalsAllowed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public double averageGoalsAllowed()
    {
        throw new NotImplementedException();
    }
}