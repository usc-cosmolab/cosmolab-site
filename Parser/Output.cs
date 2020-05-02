using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    public class Output
    {

        public double TT, EE, TE;

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
                default:
                    break;
            }
        }
    }
}
