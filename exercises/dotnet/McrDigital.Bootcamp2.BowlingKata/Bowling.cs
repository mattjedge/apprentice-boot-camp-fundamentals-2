namespace McrDigital.Bootcamp2.BowlingKata
{
    public class Bowling
    {
        public int FinalScore(Frame[] rolls)
        {
            return rolls.Sum(x => x.Total);
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