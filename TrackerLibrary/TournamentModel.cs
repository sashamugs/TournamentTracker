namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string TournamentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
         public decimal EntryFee { get; set; }
         /// <summary>
         /// 
         /// </summary>
         /// <typeparam name="TeamModel"></typeparam>
         /// <returns></returns>
         public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
         /// <summary>
         /// 
         /// </summary>
         /// <typeparam name="PrizeModel"></typeparam>
         /// <returns></returns>
         public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
         /// <summary>
         /// 
         /// </summary>
         /// <returns></returns>
         public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}