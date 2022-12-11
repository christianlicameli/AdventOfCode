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

                return raw - 65 + 27;
            }
            else if (raw > 96)
            {
                // range a-z

                return raw - 97 + 1;
            }

            return 0;
        }

        public string B()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D03A.txt");

            long totalScore = 0;
            string rucksacks1 = string.Empty;
            string rucksacks2 = string.Empty;
            string rucksacks3 = string.Empty;

            for (int l = 0; l < lines.Length; l += 3)
            {
                rucksacks1 = lines[l];
                rucksacks2 = lines[l + 1];
                rucksacks3 = lines[l + 2];

                bool found = false;

                for (int i = 0; i < rucksacks1.Length; i++)
                {
                    for (int j = 0; j < rucksacks2.Length; j++)
                    {
                        for (int k = 0; k < rucksacks3.Length; k++)
                        {
                            char c1 = rucksacks1[i];
                            char c2 = rucksacks2[j];
                            char c3 = rucksacks3[k];
                            if (c1 == c2 && c2 == c3)
                            {
                                totalScore += decodePriority(c1);
                                found = true;
                                break;
                            }
                        }
                        if (found) break;
                    }
                    if (found) break;
                }

            }


            return totalScore.ToString();
        }
    }
}