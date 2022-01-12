using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public class PrizeModel
    { 
        /// <summary>
        /// this property will hold the unique indentifier of each prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// this property will hold  place number of person for Prize
        /// </summary>
        public int PlaceNum { get; set; }
        /// <summary>
        /// this property will hold the prize Name
        /// </summary>
        public string PlaceName{ get; set; }
        /// <summary>
        /// this property will hold the prize Amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// this property will hold the the percentage value of 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNum , string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(prizeAmount, out placeNumberValue);
            PlaceNum = placeNumberValue;

            double prizePercentageValue = 0;
            double.TryParse(prizeAmount, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

        }

    }
}
