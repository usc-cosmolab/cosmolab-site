using System;
using System.Collections.Generic;
using System.IO;

namespace Parser
{
    public class Program
    {
        static List<Output> outputValues;
        const double MAGICERRORNUMBER = 69420.00;

        public static List<Output> ProcessAndGetOutput(double h, double ocdm, double ok)
        {
            string suffix = "00_cl.dat";
            string filename = "h" + h.ToString("0.0") + "cdm" + ocdm.ToString("0.0") + "k" + ok.ToString("0.0") + suffix;
            filename = "Vis_files/" + filename;

            outputValues = new List<Output>();

            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                using StreamReader reader = new StreamReader(fs);
                int lines = 0;
                while (!reader.EndOfStream)
                {
                    lines++;
                    Output lineC = new Output();
                    string line = reader.ReadLine();
                    if (line.StartsWith('#'))
                        continue;
                    line = line.Substring(11);
                    for (int i = 0; i < 7; i++)
                    {
                        if (i != 0)
                            line = line.Substring(25);
                        string another = line.Substring(0, 19);
                        lineC.AddNumber(i, Double.Parse(another, System.Globalization.NumberStyles.Float));
                    }
                    outputValues.Add(lineC);
                }
            }
            catch (FileNotFoundException)
            {
                outputValues = new List<Output>();
                Output l = new Output();
                l.AddNumber(0, MAGICERRORNUMBER);
                outputValues.Add(l);
            }

            return outputValues;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            Console.WriteLine(outputValues.ToString());
        }
    }
}
