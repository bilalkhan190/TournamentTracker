using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DB.TextHelper;
namespace TrackerLibrary.DB
{
    public class TextConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModel.csv";
        //wire up the CreatePrize for text File
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //chaining all the extension method that holds by texthelper namespace...
           List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            //Find the max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            //add the record with new id (max id +1)
            prizes.Add(model);
            prizes.SaveToPrizeFile(PrizesFile);
           //COnvert the prizes to list<string>
           //Save the list string to the textFile

            return model;
        }
    }
}
