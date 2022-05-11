namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
         public decimal EntryFee { get; set; }
         public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
         public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
         public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}