using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// represent the name of the tournment
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// the entry fee for the tournament
        /// </summary>
        public decimal  EntryFee { get; set; }
        /// <summary>
        /// holds and represents the number of team belongs to the  perticular 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
