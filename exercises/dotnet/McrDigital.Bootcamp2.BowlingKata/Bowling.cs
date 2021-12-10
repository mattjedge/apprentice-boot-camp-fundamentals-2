namespace McrDigital.Bootcamp2.BowlingKata
{
    public class Bowling
    {
        public int FinalScore(Frame[] rolls)
        {
            var total = 0;
            for (var currentRoll = 0; currentRoll < rolls.Length; currentRoll++)
            {
                total += rolls[currentRoll].Total;

                if (rolls[currentRoll].Strike)
                {
                    total += rolls[currentRoll + 1].Total;
                }

                if (rolls[currentRoll].Spare)
                {
                    total += rolls[currentRoll + 1].FirstRoll;
                }
            }

            return total;
        }
    }

    public class Frame
    {
        public int FirstRoll { get; }
        public int SecondRoll { get; }
        public int Total => FirstRoll + SecondRoll;
        public bool Spare => Total == 10 && SecondRoll != 0;
        public bool Strike { get; }

        public Frame(int rollOne, int rollTwo)
        {
            FirstRoll = rollOne;
            SecondRoll = rollTwo;
        }

        public Frame(int rollOne)
        {
            FirstRoll = rollOne;
            Strike = true;
        }
    }
}