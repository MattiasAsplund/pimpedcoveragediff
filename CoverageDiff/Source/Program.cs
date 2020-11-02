using CommandLine;
using CommandLine.Text;

namespace CoverageDiff
{
    public static class Program
    {
        /// <summary>
        /// Main method for program
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<DiffCommand>(args)
                .WithParsed<DiffCommand>(o =>
                {
                    var cmd = new DiffCommand();
                    cmd.CoverageFile = o.CoverageFile;
                    cmd.DiffFile = o.DiffFile;
                    cmd.OutputFile = o.OutputFile;
                    cmd.Run();                    
                });
        }
    }
}
