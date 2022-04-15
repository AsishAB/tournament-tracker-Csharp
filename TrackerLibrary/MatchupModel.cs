namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchUpEntryModel> Entries = new List<MatchUpEntryModel>();

        public TeamModel Winner { get; set; }

        public int MatchUpRound { get; set; }
    }
}
