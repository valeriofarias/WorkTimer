using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Globalization;

namespace WorkTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingTimePerDay = "";
            string workingDate  = "";
            TimeSpan entryTime  = TimeSpan.FromSeconds(0);
            TimeSpan exitTime   = TimeSpan.FromSeconds(0);
            TimeSpan workedTime = TimeSpan.FromSeconds(0);
            string log = "";

            var arquivo = "";
            var path = Environment.CurrentDirectory;

            if (File.Exists("schedule.txt"))
                arquivo = "schedule.txt";
            else if (File.Exists("calendario.txt"))
                arquivo = "calendario.txt";
            else if (File.Exists("../calendario.txt"))
            {
                arquivo = "../calendario.txt";
                path = "..";
            }
            else
                File.Create("calendario.txt");

            var lines = File.ReadLines(arquivo);

            int counter = 0;

            foreach (var line in lines)
            {
                string[] words = line.Split(',');
                counter = 0;

                entryTime = TimeSpan.FromSeconds(0);
                exitTime = TimeSpan.FromSeconds(0);
                workedTime= TimeSpan.FromSeconds(0);

                foreach (var word in words)
                {
                    if (counter == 0)
                        workingTimePerDay = word.Trim();

                    if (counter == 1)
                        workingDate = word.Trim();

                    if(counter > 1 && counter % 2 == 0)
                    {
                        string s = word.Trim();
                        if(s.Length > 5)
                        {
                            entryTime = DateTime.ParseExact(s, "H:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                        }
                        else
                        {
                            entryTime = DateTime.ParseExact(s, "H:mm", CultureInfo.InvariantCulture).TimeOfDay;
                        }
                        
                    }

                    if (counter > 1 && counter % 2 != 0)
                    {
                        string s = word.Trim();
                        if (s.Length > 5)
                        {
                            exitTime = DateTime.ParseExact(s, "H:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                        }
                        else
                        {
                            exitTime = DateTime.ParseExact(s, "H:mm", CultureInfo.InvariantCulture).TimeOfDay;
                        }

                        workedTime+= exitTime.Subtract(entryTime);
                    }

                    counter++;
                }

                log += "|CH:" + workingTimePerDay + "| Data: " + workingDate + "| Tempo trabalhado:" + workedTime+ "| CH menos Tempo trabalhado:" + workedTime.Subtract(TimeSpan.FromHours(Convert.ToDouble(workingTimePerDay))) + Environment.NewLine;
               
            }

            System.IO.File.WriteAllText(path + "/Relatorio/relatorio" + (DateTime.Now.ToString().Replace("/","-")).Replace(":","_")+".txt", log);

            Console.WriteLine(log);

            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
