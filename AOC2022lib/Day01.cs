namespace AOC2022lib
{
    public class Day01
    {

        public string A()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D01A.txt");

            long maxCalories = 0;
            long currentCalories = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line.Trim()))
                {
                    //check numbers and go to next elf
                    if (currentCalories > maxCalories) maxCalories = currentCalories;
                    currentCalories = 0;
                }
                else
                {
                    currentCalories += long.Parse(line.Trim());
                }
            }

            return maxCalories.ToString();
        }

        private class Elf
        {
            public long Calories { get; set; }
        }
        public string B()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D01A.txt");

            List<Elf> elfList = new();

            long currentCalories = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line.Trim()))
                {
                    //store calories and go to next elf
                    elfList.Add(new Elf() { Calories = currentCalories });
                    currentCalories = 0;
                }
                else
                {
                    currentCalories += long.Parse(line.Trim());
                }
            }

            return elfList.OrderByDescending(l => l.Calories).Take(3).Sum(e => e.Calories).ToString();
        }
    }
}