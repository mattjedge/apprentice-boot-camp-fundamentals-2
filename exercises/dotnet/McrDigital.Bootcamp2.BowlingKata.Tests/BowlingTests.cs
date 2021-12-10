using NUnit.Framework;

namespace McrDigital.Bootcamp2.BowlingKata.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void No_knocked_over_pins_returns_final_score_of_zero()
        {
            var rolls = new[]
            {
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0
            };

            var bowling = new Bowling();

            Assert.That(bowling.FinalScore(rolls), Is.EqualTo(0));
        }
    }
}