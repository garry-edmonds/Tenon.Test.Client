namespace Tenon.Test.Client.DataObjects
{
    public class IssuesByLevel
    {
        public A A { get; set; }
        public AA AA { get; set; }
        public AAA AAA { get; set; }
    }

    public class A : Level { }

    public class AA : Level { }

    public class AAA : Level { }

    public class Level
    {
        public int count { get; set; }
        public double pct { get; set; }
    }
}
