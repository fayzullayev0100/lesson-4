interface IBaseballPlayer : IPitcher
{
    public int atBats{ get; set; }
    public int hits{ get; set; }
    public double innings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int earnetRuns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public double earnetRunAverage()
    {
        throw new NotImplementedException();
    }
}