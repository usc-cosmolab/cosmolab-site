using System;
using System.Collections.Generic;
using System.IO;

namespace Parser
{
    public class Program
    {
        static List<Output> outputValues;

        public static List<Output> ProcessAndGetOutput()
        {
            outputValues = new List<Output>();

            FileStream fs = new FileStream("explanatory00_cl.dat", FileMode.Open);
            using StreamReader reader = new StreamReader(fs);
            while (!reader.EndOfStream)
            {
                Output lineC = new Output();
                string line = reader.ReadLine().Substring(11);
                for (int i = 0; i < 7; i++)
                {
                    if (i != 0)
                        line = line.Substring(25);
                    string another = line.Substring(0, 19);
                    lineC.AddNumber(i, Double.Parse(another, System.Globalization.NumberStyles.Float));
                }
                outputValues.Add(lineC);
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
