using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class ZodiacSign : IComparable<ZodiacSign>
    {
        private int _id;
        private string _sign;
        private string _imagePath;
        private DateTime _startDate;
        private DateTime _endDate;
        private PredictionList _predictionList;

        public int Id { get { return _id; } }
        public string Sign { get { return _sign; } }
        public string ImagePath { get { return _imagePath; } }
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _endDate; } }
        public PredictionList PredictionList { get { return _predictionList; } }

        public ZodiacSign(int id, string sign, string imagePath, DateTime startDate, DateTime endDate)
        {
            _predictionList = new PredictionList();
            _id = id;
            _sign = sign;
            _imagePath = imagePath;
            _startDate = startDate;
            _endDate = endDate;
        }

        public int CompareTo(ZodiacSign other)
        {
            return string.Compare(this._sign, other._sign);
        }

        public override string ToString()
        {
            return _sign;
        }


    }
}
