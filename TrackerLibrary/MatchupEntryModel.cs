namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// represents 1 team in the matchup
        /// </summary>
        /// <value></value>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        /// <value></value>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that this team came 
        ///from as the winner
        /// </summary>
        /// <value></value>
        public MatchupModel ParentMatching { get; set; }

         
    }
}