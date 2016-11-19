using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;

namespace BusinessLogicTier
{
    public class Horoscope
    {
        private static Horoscope s_theInstance;
        private List<ZodiacSign> _zodiacSignList;
        private HoroscopePersistService _hpService;

        //public List<ZodiacSign> ZodiacSign { get { return _zodiacSignList; } }

        private Horoscope()
        {
            _zodiacSignList = new List<ZodiacSign>();
            _hpService = new HoroscopePersistService();
            // load data from files
            LoadData();
        }

        /// <summary>
        /// This static method ensures that only one instance of the horoscope class can be created.
        /// </summary>
        /// <returns></returns>
        public static Horoscope GetInstance()
        {
            if (s_theInstance == null)
            {
                s_theInstance = new Horoscope();
            }
            return s_theInstance;
        }

        /// <summary>
        /// This method returns zodiac sign depending on user's birthday
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public ZodiacSign GetZodiacSign(User user)
        {
            ZodiacSign result = _zodiacSignList[11]; // last one - Capricorn, so foreach can work correctly

            foreach (ZodiacSign zodiac in _zodiacSignList)
            {
                if (user.Birthday.DayOfYear >= zodiac.StartDate.DayOfYear 
                    &&
                    user.Birthday.DayOfYear < zodiac.EndDate.DayOfYear)
                {
                    result = zodiac;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// load predictions using HoroscopePersistService. This can throw IO exception
        /// </summary>
        /// <returns></returns>
        public List<ZodiacSign> LoadData()
        {
            // load data from files only if it is not in the list
            if (_zodiacSignList.Count == 0)
            {
                _hpService.LoadHoroscope();

                foreach (ZodiacSignInfo item in _hpService.GetZodiacSignInfo())
                {
                    ZodiacSign zodiac = new ZodiacSign(item.Id, item.Sign, item.ImagePath, item.StartDate, item.EndDate);
                    // copy prediction from ZodiacInfo.PredictionList to ZodiacSign.PredictionList
                    foreach (string prediction in item.PredictionList)
                    {
                        zodiac.PredictionList.AddPrediction(prediction);
                    }
                    _zodiacSignList.Add(zodiac);
                }
            }
            return _zodiacSignList;
        }

        public void SetZodiacList(List<ZodiacSign> zodiacSignList)
        {
            _zodiacSignList = zodiacSignList;
        }

        /// <summary>
        /// This method saves data to the files using HoroscopePersistService
        /// </summary>
        public void SaveData() 
        {
            // convert List<ZodiacSign> into List<ZodiacSignInfo>
            List<ZodiacSignInfo> zodiacSignInfoList = new List<ZodiacSignInfo>();
            foreach (ZodiacSign zodiac in _zodiacSignList) 
            {
                ZodiacSignInfo zodiacInfo = 
                    new ZodiacSignInfo(zodiac.Id, zodiac.Sign, zodiac.ImagePath, zodiac.StartDate, zodiac.EndDate);
                // this job should be done by PredictionList class but no time...
                foreach (string prediction in zodiac.PredictionList)
                {
                    zodiacInfo.PredictionList.Add(prediction);
                }
                // add ZodiacInfo to the list so it can be saved!
                zodiacSignInfoList.Add(zodiacInfo);
            }

            if (zodiacSignInfoList.Count == 0) {
                throw new Exception("No data in ZodiacSignInfoList!");
            }

            // save converted list
            _hpService.SaveHoroscope(zodiacSignInfoList);
        }
  
    }
}
