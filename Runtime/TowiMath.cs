namespace PixframeStudios.TowiPlugin
{
    public static class TowiMath
    {
        /// <summary>
        /// This function is used to get the result of the game with the following grades
        /// Failed: not pass or under 8 out of 10 points
        /// Pass: just enough to pass 8 out of 10 points
        /// Good: 9 out fo 10 points
        /// Excellent: 10 out of 10 points
        /// </summary>
        /// <param name="rounds"></param>
        /// <param name="calificationPerRound"></param>
        /// <param name="calification"></param>
        /// <param name="passScore"></param>
        /// <param name="goodScore"></param>
        /// <param name="excellentScore"></param>
        /// <returns></returns>
        public static GameResult GetResult(int rounds, int calificationPerRound, float calification, float passScore = 0.8f, float goodScore = 0.9f, float excellentScore = 1f)
        {
            float totalPossibleCalifiacation = rounds * calificationPerRound;
            float finalScore = calification / totalPossibleCalifiacation;
            if (finalScore < passScore)
            {
                return GameResult.Failed;
            }
            else if (finalScore >= passScore && finalScore < goodScore)
            {
                return GameResult.Pass;
            }
            else if (finalScore >= goodScore && finalScore < excellentScore)
            {
                return GameResult.Good;
            }
            else
            {
                return GameResult.Excellent;
            }
        }
    }
}