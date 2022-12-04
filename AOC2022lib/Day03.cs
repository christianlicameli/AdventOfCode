namespace AOC2022lib
{
    public class Day03
    {

        public string A()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D03A.txt");
            long totalScore = 0;

            foreach (var rucksack in lines)
            {
                string compart1 = rucksack.Substring(0, rucksack.Length / 2);
                string compart2 = rucksack.Substring(rucksack.Length / 2);
                bool found = false;

                for (int i = 0; i < compart1.Length; i++)
                {
                    for (int j = 0; j < compart2.Length; j++)
                    {
                        char c1 = compart1[i];
                        char c2 = compart2[j];
                        if (c1 == c2)
                        {
                            totalScore += decodePriority(c1);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }

            }


            return totalScore.ToString();
        }

        private long decodePriority(char c)
        {
            int raw = (int)c;

            if (raw < 91)
            {
                // range A-Z

                return raw -65 +27;
            }
            else if (raw > 96)
            {
                // range a-z

                return raw -97 + 1;
            }

            return 0;
        }

        public string B()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D03A.txt");

            long totalScore = 0;



            return totalScore.ToString();
        }
    }
}