using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace McrDigital.Bootcamp2.BowlingKata.Tests
{
    public class BowlingTests
    {
        private Bowling _subject;
        private readonly Frame _strike = new Frame(10);
        private readonly Frame _spare = new Frame(4, 6);
        private readonly Frame _zeroPins = new Frame(0, 0);
        private readonly Frame _nineZero = new Frame(9, 0);
        private readonly Frame _onePinEachRoll = new Frame(1, 1);

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
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins
            };

            var result = _subject.Score(rolls);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Pins_knocked_over_without_special_scoring_rules_return_sum_of_pins()
        {
            var rolls = new[]
            {
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll,
                _onePinEachRoll
            };

            var result = _subject.Score(rolls);

            Assert.That(result, Is.EqualTo(20));
        }
        
        [Test]
        public void Rolling_a_spare_adds_next_roll_as_bonus()
        {
            var rolls = new[]
            {
                _spare,
                new Frame(1, 0),
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins
            };

            var result = _subject.Score(rolls);

            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void STRIKE_adds_next_two_rolls_as_bonus()
        {
            var rolls = new[]
            {
                _strike,
                _onePinEachRoll,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins,
                _zeroPins
            };

            var result = _subject.Score(rolls);

            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void So_close_every_time()
        {
            var rolls = new[]
            {
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero,
                _nineZero
            };

            var result = _subject.Score(rolls);

            Assert.That(result, Is.EqualTo(90));

        }

        [Test]
        public void Perfect_game_scores_300_points()
        {
            var bonusStrikeFrame = new Frame(10);
            var rolls = new[]
            {
                _strike,
                _strike,
                _strike,
                _strike,
                _strike,
                _strike,
                _strike,
                _strike,
                _strike,
                _strike,
                bonusStrikeFrame,
                bonusStrikeFrame
            };

            var result = _subject.Score(rolls);

            Assert.That(result, Is.EqualTo(300));
        }
    }
}