namespace McrDigital.Bootcamp2.BowlingKata
{
    public class Bowling
    {
        public int FinalScore(Frame[] rolls)
        {
            var total = 0;
            for (var i = 0; i < rolls.Length; i++)
            {
                total += rolls[i].Total;
                if (rolls[i].Total == 10)
                {
                    total += rolls[i + 1].FirstRoll;
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

        public Frame(int rollOne, int rollTwo)
        {
            FirstRoll = rollOne;
            SecondRoll = rollTwo;
        }
    }
}