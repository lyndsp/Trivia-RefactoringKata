using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace UglyTrivia
{
    [Ignore("Regenerates the golden output")]
    [TestFixture]
    class GoldenMaster
    {
        [Test]
        public void OutputGoldenLog()
        {
            var baseOutputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GoldenOutput-Seed-{0}.txt");

            var seeds = new int[100];
            var actualSeed = 0;

            foreach (var i in seeds)
            {
                actualSeed++;

                using (var output = new StringWriter())
                {
                    Console.SetOut(output);
                    var runner = new GameRunnerGoldMaster();

                    runner.Run(actualSeed);

                    File.WriteAllText(string.Format(baseOutputPath, actualSeed), output.ToString());
                }
            }
        }
    }
}
