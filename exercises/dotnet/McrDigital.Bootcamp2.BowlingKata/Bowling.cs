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
        public int FirstRoll { get; set; }
        public int SecondRoll { get; set; }
        public int Total => FirstRoll + SecondRoll;
        public bool Spare => Total == 10;

        public Frame(int rollOne, int rollTwo)
        {
            FirstRoll = rollOne;
            SecondRoll = rollTwo;
        }
    }
}