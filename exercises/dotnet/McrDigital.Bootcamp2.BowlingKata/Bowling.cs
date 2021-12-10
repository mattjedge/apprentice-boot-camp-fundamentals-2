namespace McrDigital.Bootcamp2.BowlingKata
{
    public class Bowling
    {
        private const int FramesPerGame = 10;
        public int Score(Frame[] frames)
        {
            var total = 0;
            for (var currentFrame = 0; currentFrame <= FramesPerGame - 1; currentFrame++)
            {
                total += frames[currentFrame].Total;

                if (frames[currentFrame].Strike)
                {
                    var nextFrame = frames[currentFrame + 1];
                    
                    total += nextFrame.FirstRoll;
                    total += nextFrame.Strike ? frames[currentFrame + 2].FirstRoll : nextFrame.SecondRoll;
                }

                if (frames[currentFrame].Spare)
                {
                    total += frames[currentFrame + 1].FirstRoll;
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