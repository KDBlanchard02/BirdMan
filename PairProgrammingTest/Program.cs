using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string directoryPath = Directory.GetParent(workingDirectory).Parent.FullName;
            var fileReader = new StreamReader($"{directoryPath}/game-sequence.txt");
            var line = fileReader.ReadLine();
            var events = line.Split(',');
            foreach (var ev in events)
            {
                Console.WriteLine(ev);
            }
            Console.ReadKey();

            
    }
    }
}
