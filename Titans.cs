class Titans
{
    public Titans Next;
    public string name;
    public double CofH;
    public double CofW;

    public Titans(Titans Next, string name, double CofH, double CofW)
    {
        this.Next = Next;
        this.name = name;
        this.CofH = CofH;
        this.CofW = CofW;
    }
}