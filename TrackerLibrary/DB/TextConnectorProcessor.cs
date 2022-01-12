using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DB.TextHelper
{
  public static  class TextConnectorProcessor
    {
        public static string FullFilePath(this string FilePath)
        {
            return $"{ConfigurationManager.AppSettings["FilePath"]}//{FilePath}";
        }

        //Load the text File
        //Convert the textFile into prizeModel
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] col = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(col[0]);
                p.PlaceNum = int.Parse(col[1]);
                p.PlaceName = col[2];
                p.PrizeAmount = decimal.Parse(col[3]);
                p.PrizePercentage = double.Parse(col[4]);

                output.Add(p);
            }
                return output;
            
        }


        public static void SaveToPrizeFile(this List<PrizeModel> model, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in model)
            {
                lines.Add($"{p.Id},{p.PlaceNum},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(FullFilePath(fileName), lines);
        }
    }
}
