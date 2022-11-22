delegate bool check(int che);
class Computation
{
    public int lower { get; }

    public int upper { get; }

    public Computation(int lower,int upper)
    {
        this.lower = lower;
        this.upper = upper;
    }  

    public int GetSumOf (check chk)
    {
        
    }