using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class PredictionList : List<string>
    {
        /// <summary>
        /// This method adds prediction to the list
        /// </summary>
        /// <param name="prediction"></param>
        public void AddPrediction(string prediction) 
        {
            base.Add(prediction);
        }

        /// <summary>
        /// This method returns random prediction.
        /// </summary>
        /// <returns></returns>
        public string GetRandomPrediction()
        {
            string result = "";
            if (Count > 0)
            {
                Random r = new Random();
                int idx = r.Next(Count - 1);
                result = base[idx];
            }
            return result;
        }
        
    }
}
