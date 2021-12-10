using NUnit.Framework;

namespace McrDigital.Bootcamp2.BowlingKata.Tests
{
    public class BowlingTests
    {
        private Bowling _subject;

        [SetUp]
        public void Setup()
        {
            _subject = new Bowling();
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

            var result = _subject.FinalScore(rolls);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Pins_knocked_over_without_special_scoring_rules_return_sum_of_pins()
        {
            var rolls = new[]
            {
                1, 1,
                1, 1,
                1, 1,
                1, 1,
                1, 1,
                1, 1,
                1, 1,
                1, 1,
                1, 1,
                1, 1
            };

            var result = _subject.FinalScore(rolls);

            Assert.That(result, Is.EqualTo(20));
        }
        
        [Test]
        [Ignore("Frame concept must be introduced")]
        public void Rolling_a_spare_adds_next_roll_bonus()
        {
            var rolls = new[]
            {
                5, 5,
                1, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0
            };

            var result = _subject.FinalScore(rolls);

            Assert.That(result, Is.EqualTo(12));
        }
    }
}