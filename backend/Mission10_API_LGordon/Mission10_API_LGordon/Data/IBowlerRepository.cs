namespace Mission10_API_LGordon.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<BowlerInfo> Bowlers { get; }
        IEnumerable<TeamInfo> Teams { get; }

        IEnumerable<object> GetBowlersWithTeamName();
    }
}