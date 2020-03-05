using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class Output
    {

        public double TT, EE, TE, BB, phiphi, TPhi, Ephi;

        public void AddNumber(int index, double value)
        {
            switch (index)
            {
                case 0:
                    TT = value;
                    break;
                case 1:
                    EE = value;
                    break;
                case 2:
                    TE = value;
                    break;
                case 3:
                    BB = value;
                    break;
                case 4:
                    phiphi = value;
                    break;
                case 5:
                    TPhi = value;
                    break;
                case 6:
                    Ephi = value;
                    break;
                default:
                    break;
            }
        }
    }
}
