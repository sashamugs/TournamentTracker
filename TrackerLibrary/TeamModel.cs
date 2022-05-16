namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="PersonModel"></typeparam>
        /// <returns></returns>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string TeamName { get; set; }
    }
}