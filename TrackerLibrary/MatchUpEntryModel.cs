namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {

        /// <summary>
        ///  Represents One Team in a Match Up  
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        ///  Represents Score for this particular Team  
        /// </summary>

        public double Score { get; set; }


        /// <summary>
        ///  Represents Match Up that the team 
        ///  came from  as winner
        /// </summary>

        public MatchupModel ParentMatchup { get; set; }

    }
}
