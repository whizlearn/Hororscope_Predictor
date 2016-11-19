using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{

    public class ZodiacSignInfo
    {
        private int _id;
        private string _sign;
        private string _imagePath;
        private DateTime _startDate;
        private DateTime _endDate;
        private List<string> _predictionList;

        public int Id { get { return _id; } }
        public string Sign { get { return _sign; } }
        public string ImagePath { get { return _imagePath; } }
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _endDate; } }
        public List<string> PredictionList { get { return _predictionList; } }

        public ZodiacSignInfo(int id, string sign, string imagePath, DateTime startDate, DateTime endDate)
        {
            _predictionList = new List<string>();
            _id = id;
            _sign = sign;
            _imagePath = imagePath;
            _startDate = startDate;
            _endDate = endDate;
        }

    }

    
}
