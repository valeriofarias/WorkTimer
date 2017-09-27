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
            string language = "";

            var file = "";
            var path = Environment.CurrentDirectory;

            if (File.Exists("schedule.txt"))
                file = "schedule.txt";
            else if (File.Exists("../schedule.txt"))
            {
                file = "../schedule.txt";
                path = "..";
            }
            else if (File.Exists("calendario.txt"))
                file = "calendario.txt";
            else if (File.Exists("../calendario.txt"))
            {
                file = "../calendario.txt";
                path = "..";
            }
            else
                File.Create("calendario.txt");


            if (file == "schedule.txt" || file == "../schedule.txt")
                language = "en";
            else
                language = "pt";


            var lines = File.ReadLines(file);

            int counter = 0;

            foreach (var line in lines)
            {
                string[] words = line.Split(',');
                counter = 0;

                entryTime  = TimeSpan.FromSeconds(0);
                exitTime   = TimeSpan.FromSeconds(0);
                workedTime = TimeSpan.FromSeconds(0);

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

                if (language == "en")
                {
                    log += "|Hours per Day:" + workingTimePerDay + "| Date: " + workingDate + "| Worked Time:" + workedTime + "| Hours per day minus Worked time:" + workedTime.Subtract(TimeSpan.FromHours(Convert.ToDouble(workingTimePerDay))) + Environment.NewLine;
                    System.IO.File.WriteAllText(path + "/Report/report" + (DateTime.Now.ToString().Replace("/", "-")).Replace(":", "_") + ".txt", log);
                }
                else
                {
                    log += "|CH:" + workingTimePerDay + "| Data: " + workingDate + "| Tempo trabalhado:" + workedTime + "| CH menos Tempo trabalhado:" + workedTime.Subtract(TimeSpan.FromHours(Convert.ToDouble(workingTimePerDay))) + Environment.NewLine;
                    System.IO.File.WriteAllText(path + "/Relatorio/relatorio" + (DateTime.Now.ToString().Replace("/", "-")).Replace(":", "_") + ".txt", log);
                }
                    
            }

            Console.WriteLine(log);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
