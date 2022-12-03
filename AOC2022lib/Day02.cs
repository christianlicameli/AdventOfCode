namespace AOC2022lib
{
    public class Day02
    {

        public string A()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D02A.txt");

            long totalScore = 0;

            foreach (var line in lines)
            {
                int roundScore = 0;
                var round = line.Trim().Split(' ', StringSplitOptions.TrimEntries);
                string opponent = round[0];
                string myself = round[1];
                if (myself.Equals("X")) roundScore += 1; //ROCK
                if (myself.Equals("Y")) roundScore += 2; //PAPER
                if (myself.Equals("Z")) roundScore += 3; //SCISSORS

                if ((opponent == "A" && myself == "X")
                   || (opponent == "B" && myself == "Y")
                   || (opponent == "C" && myself == "Z")
                    )
                {
                    //it's a draw 
                    roundScore += 3;
                }
                else if (opponent == "A") //ROCK
                {
                    //opponent rock
                    if (myself.Equals("Y")) { roundScore += 6; /*me paper, win*/ }
                }
                else if (opponent == "B") //PAPER
                {
                    //opponent paper
                    if (myself.Equals("Z")) { roundScore += 6; /*me scissors, win*/ }
                }
                else if (opponent == "C") //SCISSORS
                {
                    //opponent scissors
                    if (myself.Equals("X")) { roundScore += 6; /*me rock, win*/ }
                }

                totalScore += roundScore;
            }


            return totalScore.ToString();
        }


        public string B()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D02A.txt");

            long totalScore = 0;

            foreach (var line in lines)
            {
                int roundScore = 0;
                var round = line.Trim().Split(' ', StringSplitOptions.TrimEntries);
                string opponent = round[0];
                string prevision = round[1];

                string myself = string.Empty;

                //find the correct "myself" according to strategy
                if (opponent == "A") //ROCK
                {
                    //opponent rock
                    if (prevision.Equals("X")) { myself = "C"; } // to lose
                    if (prevision.Equals("Y")) { myself = opponent; } // to draw
                    if (prevision.Equals("Z")) { myself = "B"; } // to win

                }
                else if (opponent == "B") //PAPER
                {
                    //opponent paper
                    if (prevision.Equals("X")) { myself = "A"; } // to lose
                    if (prevision.Equals("Y")) { myself = opponent; } // to draw
                    if (prevision.Equals("Z")) { myself = "C"; } // to win
                }
                else if (opponent == "C") //SCISSORS
                {
                    //opponent scissors
                    if (prevision.Equals("X")) { myself = "B"; } // to lose
                    if (prevision.Equals("Y")) { myself = opponent; } // to draw
                    if (prevision.Equals("Z")) { myself = "A"; } // to win
                }



                //repeat calculation as in part A

                if (myself.Equals("A")) roundScore += 1; //ROCK
                if (myself.Equals("B")) roundScore += 2; //PAPER
                if (myself.Equals("C")) roundScore += 3; //SCISSORS

                if ((opponent == myself)
                    )
                {
                    //it's a draw 
                    roundScore += 3;
                }
                else if (opponent == "A") //ROCK
                {
                    //opponent rock
                    if (myself.Equals("B")) { roundScore += 6; /*me paper, win*/ }
                }
                else if (opponent == "B") //PAPER
                {
                    //opponent paper
                    if (myself.Equals("C")) { roundScore += 6; /*me scissors, win*/ }
                }
                else if (opponent == "C") //SCISSORS
                {
                    //opponent scissors
                    if (myself.Equals("A")) { roundScore += 6; /*me rock, win*/ }
                }

                totalScore += roundScore;
            }


            return totalScore.ToString();
        }
    }
}