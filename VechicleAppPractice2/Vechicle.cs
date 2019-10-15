using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vechicle
    {
        public string vechileName;
        public string regNo;
        public List<double> speed = new List<double>();

       // public Vechicle(string vichcleName,string regNo )
        //{
           // this.vechileName = vichcleName;
           // this.regNo = regNo;
           
       // }
        public string VechileName { set; get; }
        public string RegNo { set; get; }

        public double GetMax()
        {
            double max = speed.Max();
            return max;
        }
        public double GetMin()
        {
            double min = speed.Min();
            return min;
        }
        public double GetAvg()
        {
            double avg = speed.Average();
            return avg;
        }

    }
}
