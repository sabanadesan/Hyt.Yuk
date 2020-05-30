using System;

using Plossum.CommandLine;
using Utility.Cmd.CommandLine;

namespace Hyt.Yuk
{
    class Program
    {
        static int Main(string[] args)
        {
            Options options = new Options();
            CommandLineParser parser = new CommandLineParser(options);
            parser.Parse();
            Console.WriteLine(parser.UsageInfo.GetHeaderAsString(78));

            if (options.Help)
            {
                Console.WriteLine(parser.UsageInfo.GetOptionsAsString(78));
                return 0;
            }
            else if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.GetErrorsAsString(78));
                return -1;
            }
            Console.WriteLine("Hello {0}!", options.Name);
            return 0;
        }
    }
}
