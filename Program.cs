using System;
using System.IO;
using System.Linq;

namespace Renamer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Not enough arguments.");
                return;
            }

            var size = Int32.Parse(args[args.Length-1]);

            var prefix = string.Join(' ', args.SkipLast(1));

            foreach (string f in Directory.GetFiles("."))
                File.Move(f, RenameFile(f, prefix, size));

        }

        private static string RenameFile(string f, string prefix, int size) => $"{prefix} - {f.Substring(size + 2)}";
    }
}
