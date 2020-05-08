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
                //for(double ob = 0.005; ob <= 0.039; ob += 0.004)
                //{
                    for(double ocdm = 0; ocdm <= 1; ocdm += 0.2)
                    {
                        for(double ok = -0.5; ok <= 0.5; ok += 0.2)
                        {
                            string temp = text;
                            FileStream fsn = new FileStream("h" + h.ToString("0.0") + /*"b" + ob.ToString("0.000") +*/ "cdm" + ocdm.ToString("0.0") + "k" + ok.ToString("0.0") + ".ini", FileMode.Create);
                            if (temp.Contains("%p1%"))
                                temp = temp.Replace("%p1%", h.ToString("0.0"));
                            //if (temp.Contains("%p2%"))
                            //    temp = temp.Replace("%p2%", ob.ToString("0.000"));
                            if (temp.Contains("%p3%"))
                                temp = temp.Replace("%p3%", ocdm.ToString("0.0"));
                            if (temp.Contains("%p4%"))
                                temp = temp.Replace("%p4%", ok.ToString("0.0"));

                            using StreamWriter writer = new StreamWriter(fsn);

                            writer.Write(temp);
                            writer.Flush();
                            fsn.Flush();
                            writer.Close();
                            count++;
                        }
                    }
                //}
            }
        }

        static void Main(string[] args)
        {
            ProcessAndGetOutput();
        }
    }
}
