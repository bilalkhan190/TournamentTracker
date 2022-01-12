using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// represent one team in matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represet the score of this purticular match team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represent the matchup that this team came up as a winner
        /// </summary>
        public MatchupModel ParentMatchup{ get; set; }
    }
}
