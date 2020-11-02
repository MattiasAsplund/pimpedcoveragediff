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
            var cmd = new DiffCommand();
            cmd.CoverageFile = "/home/mag/savelend/reloansys.identityservice/tests/Reloansys.Parallelizable.CI/coverage.xml";
            cmd.DiffFile = "/home/mag/savelend/reloansys.identityservice/tests/Reloansys.Parallelizable.CI/git.diff";
            cmd.Run();
        }
    }
}
