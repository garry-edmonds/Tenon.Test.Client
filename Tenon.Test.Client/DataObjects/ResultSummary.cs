namespace Tenon.Test.Client.DataObjects
{
    public class ResultSummary
    {
        public Density density { get; set; }
        public Issues issues { get; set; }
        public IssuesByLevel issuesByLevel { get; set; }
        public Tests tests { get; set; }
    }
}
