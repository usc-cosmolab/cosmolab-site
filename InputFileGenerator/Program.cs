using System;
using System.Collections.Generic;
using System.IO;

namespace InputFileGenerator
{
    class Program
    {
        public static void ProcessAndGetOutput()
        {

            FileStream fs = new FileStream("a1.ini", FileMode.Open);
            using StreamReader reader = new StreamReader(fs);
            string text = reader.ReadToEnd();
            int count = 0;
            for(double h = 0.3; h <= 1.5; h += 0.2)
            {
                for(double ob = 0.005; ob <= 0.039; ob += 0.004)
                {
                    string temp = text;
                    FileStream fsn = new FileStream("h" + h.ToString("0.0") + "ob" + ob.ToString("0.000") + ".ini", FileMode.Create);
                    if (temp.Contains("%p1%"))
                        temp = temp.Replace("%p1%", h.ToString("0.0"));
                    if (temp.Contains("%p2%"))
                        temp = temp.Replace("%p2%", ob.ToString("0.000"));

                    using StreamWriter writer = new StreamWriter(fsn);

                    writer.Write(temp);
                    writer.Flush();
                    fsn.Flush();
                    writer.Close();
                    count++;
                }
            }
        }

        static void Main(string[] args)
        {
            ProcessAndGetOutput();
            Console.WriteLine("Hello World!");
        }
    }
}
