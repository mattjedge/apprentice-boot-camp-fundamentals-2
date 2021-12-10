using NUnit.Framework;

namespace McrDigital.Bootcamp2.BowlingKata.Tests
{
    public class BowlingTests
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

        [Test]
        public void Pins_knocked_over_without_special_scoring_rules_return_sum_of_pins()
        {
            var rolls = new[]
            {
                2, 3,
                2, 3,
                2, 3,
                2, 3,
                2, 3,
                2, 3,
                2, 3,
                2, 3,
                2, 3,
                2, 3
            };

            var bowling = new Bowling();

            Assert.That(bowling.FinalScore(rolls), Is.EqualTo(50));
        }
    }
}