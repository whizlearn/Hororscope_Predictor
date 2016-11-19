using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class HoroscopePersistService
    {
        const string ZODIAC_FILE = "zodiac-sign-store.dat";
        const string PREDICTION_FILE = "prediction-store.dat";

        //private int _id; ?
        //private string[ , ] _predictionStore;
        private List<ZodiacSignInfo> _zodiacList;

        public HoroscopePersistService()
        {
            _zodiacList = new List<ZodiacSignInfo>();
        }

        public void LoadHoroscope()
        {
            // load zodiac sign data
            using (StreamReader fileReader = new StreamReader(new FileStream(ZODIAC_FILE, FileMode.Open)))
            {
                string line;
                while((line = fileReader.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    int id = int.Parse(data[0]);
                    string name = data[1];
                    string imagePath = data[2];
                    DateTime startDate = DateTime.Parse(data[3]);
                    DateTime endDate = DateTime.Parse(data[4]);

                    ZodiacSignInfo zsi = new ZodiacSignInfo(id, name, imagePath, startDate, endDate);
                    _zodiacList.Add(zsi);
                }
            }

            // load prediction data
            using (StreamReader fileReader = new StreamReader(new FileStream(PREDICTION_FILE, FileMode.Open)))
            {
                string line;
                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    int zodiacId = int.Parse(data[0]);
                    string prediction = data[1];

                    // find zodiak by id and add prediction to its list
                    ZodiacSignInfo zodiacInfo = GetZodiakByID(zodiacId);
                    zodiacInfo.PredictionList.Add(prediction);
                }
            }
        }

        /// <summary>
        /// Find zodiakInfo by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private ZodiacSignInfo GetZodiakByID(int id) 
        {
            ZodiacSignInfo zodiacInfo = null;
            foreach (ZodiacSignInfo zodiac in _zodiacList) {
                if (zodiac.Id == id) {
                    zodiacInfo = zodiac;
                    break;
                }
            }
            return zodiacInfo;
        }

        /// <summary>
        /// First, convert List<ZodiacSign> to List<ZodiacInfo>
        /// </summary>
        /// <param name="zodiacInfoList"></param>
        public void SaveHoroscope(List<ZodiacSignInfo> zodiacInfoList)
        {
            using (StreamWriter fileWriter = new StreamWriter(new FileStream(PREDICTION_FILE, FileMode.Create)))
            {
                foreach (ZodiacSignInfo zodiac in zodiacInfoList)
                {
                    foreach (string prediction in zodiac.PredictionList)
                    {
                        // 1;prediction 1.1
                        string line = string.Format("{0};{1}", zodiac.Id, prediction);
                        fileWriter.WriteLine(line);
                    }
                }
            }

        }

        public List<ZodiacSignInfo> GetZodiacSignInfo()
        {
            return _zodiacList;
        }
    }
}
