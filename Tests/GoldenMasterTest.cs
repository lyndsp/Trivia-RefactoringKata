using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace UglyTrivia
{
    [TestFixture]
    class GoldenMasterTest
    {
        static string baseOutputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReferenceOutput", "GoldenOutput-Seed-{0}.txt");

        [Test]
        public void ExpectedOutputMatchesMaster([Range(1,5)] int seed)
        {
            var referenceOutput = File.ReadAllText(string.Format(baseOutputPath, seed));

            using (var output = new StringWriter())
            {
                Console.SetOut(output);
                var runner = new GameRunnerGoldMaster();

                runner.Run(seed);

                var actualOutput = output.ToString();

                Assert.That(actualOutput, Is.EqualTo(referenceOutput));
            }
        }
    }
}
