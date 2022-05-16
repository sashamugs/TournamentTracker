namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="MatchupEntryModel"></typeparam>
        /// <returns></returns>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int MatchupRound { get; set; }
    }
}