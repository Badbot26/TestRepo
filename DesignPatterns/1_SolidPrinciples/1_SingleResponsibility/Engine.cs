using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.SingleResponsibility
{
    public static class Engine
    {
        public static void Run()
        {
            Console.WriteLine("Running the Single Responsibility Principle Engine");

            // code to learning the single-responsibility principle
            var j = new Journal();
            j.AddEntry("I laughed today");
            j.AddEntry("I started learning design patterns today");
            Console.WriteLine(j);

            // persist journal
            var p = new Persistance();
            var filename = @"c:\temp\journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true});
        }

        public class Journal
        {
            private readonly List<string> entries = new List<string>();

            private static int count = 0;

            public int AddEntry(string text)
            {
                entries.Add($"{++count}: {text}");
                return count; // memento pattern
            }

            public void RemoveEntry(int index)
            {
                entries.RemoveAt(index);
            }

            public override string ToString()
            {
                return string.Join(Environment.NewLine, entries);
            }
        }

        public class Persistance
        {
            public void SaveToFile(Journal j, string filename, bool overwrite = false)
            {
                if (overwrite || !File.Exists(filename))
                {
                    File.WriteAllText(filename, j.ToString());
                }
            }
        }
    }
}