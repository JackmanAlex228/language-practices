using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // public void Save(string filename)
        // {
        //     File.WriteAllText(filename, ToString());
        // }

        // public static Journal Load(string filename)
        // {
        //     ...
        // }

        // public void Load(Uri, uri)
        // {
        //     ...   
        // }

        // PROBLEM: Too many functions for one class
        // SOLUTION: Create a new class for these new (saving, loading, etc.) functions
    }

    // The new class, single (saving, loading) responsibility
    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }


    public class Demo
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            WriteLine(j);

            // using the new class to save content into text file
            var p = new Persistence();
            var filename = @"journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(filename);
        }
    }
}