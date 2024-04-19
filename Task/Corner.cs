using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Corner
    {
        int gradus;
        int min;
        int sec;

       
        public int Gradus
        {
            get { return gradus; }
            set
            {

                gradus = value > 360 ? value % 360 : value;
            }
        }
        public int Min
        {
            get { return min; }
            set
            {
             
                if (value > 60)
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
                else { min = value; }
            }
        }

        public int Sec
        {
            get { return sec; }
            set
            {
                if (value > 60)
                {
                    Min += value / 60;
                    sec = value % 60;
                }
                else
                {
                    sec = value;
                }
            }
        }

        public double GetRadians()
        {
            return (1 / (Math.PI * 180.0)) * ((double)gradus + min / 60.0 + sec / 3600.0);
        }
    }
}
