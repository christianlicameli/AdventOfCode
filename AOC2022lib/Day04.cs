namespace AOC2022lib
{
    public class Day04
    {

        public string A()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D04A.txt");
            long totalScore = 0;

            foreach (string line in lines)
            {
                var pairs = line.Split(',', StringSplitOptions.TrimEntries);
                var c1 = pairs[0].Split('-', StringSplitOptions.TrimEntries);
                var c2 = pairs[1].Split('-', StringSplitOptions.TrimEntries);
                int[] cp1 = new int[] { int.Parse(c1[0]), int.Parse(c1[1]) };
                int[] cp2 = new int[] { int.Parse(c2[0]), int.Parse(c2[1]) };

                if (cp1[0] < cp2[0] && cp1[1] < cp2[0])
                {
                    // first pair is totally below the range of second pair.
                }
                else if (cp2[0] < cp1[0] && cp2[1] < cp1[0])
                {
                    // second pair is totally below the range of first pair.
                }
                else
                {
                    // the two range overlap, let's check if one include the other
                    if (cp1[0] <= cp2[0] && cp1[1] >= cp2[1])
                    {
                        // first pair contains the second pair.
                        totalScore++;
                    }
                    else if (cp2[0] <= cp1[0] && cp2[1] >= cp1[1])
                    {
                        // second pair contains the first pair.
                        totalScore++;
                    }
                    else
                    {
                        // every other case. ininfluent.
                    }

                }
            }


            return totalScore.ToString();
        }



        public string B()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D04A.txt");

            long totalScore = 0;

            foreach (string line in lines)
            {
                var pairs = line.Split(',', StringSplitOptions.TrimEntries);
                var c1 = pairs[0].Split('-', StringSplitOptions.TrimEntries);
                var c2 = pairs[1].Split('-', StringSplitOptions.TrimEntries);
                int[] cp1 = new int[] { int.Parse(c1[0]), int.Parse(c1[1]) };
                int[] cp2 = new int[] { int.Parse(c2[0]), int.Parse(c2[1]) };

                if (cp1[0] < cp2[0] && cp1[1] < cp2[0])
                {
                    // first pair is totally below the range of second pair.
                }
                else if (cp2[0] < cp1[0] && cp2[1] < cp1[0])
                {
                    // second pair is totally below the range of first pair.
                }
                else
                {
                    // the two range overlap, let's check if one include the other
                    if (cp1[0] <= cp2[0] && cp1[1] >= cp2[1])
                    {
                        // first pair contains the second pair.
                        totalScore++;
                    }
                    else if (cp2[0] <= cp1[0] && cp2[1] >= cp1[1])
                    {
                        // second pair contains the first pair.
                        totalScore++;
                    }
                    else
                    {
                        // every other case is overlapping. Good.
                        totalScore++;
                    }

                }
            }
            return totalScore.ToString();
        }
    }
}