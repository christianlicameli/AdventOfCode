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
                    currentCalories = currentCalories + long.Parse(line.Trim());
                }
            }

            return maxCalories.ToString();
        }

        private class Elf
        {
            public string name { get; set; }
            public long calories { get; set; }
        }
        public string B()
        {
            string[] lines = System.IO.File.ReadAllLines(@"InputFiles\D01A.txt");

            List<Elf> elfList = new List<Elf>();

            int elfIndex = 0;
            long currentCalories = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line.Trim()))
                {
                    //check numbers and go to next elf
                    elfList.Add(new Elf() { name = $"Elf {++elfIndex}", calories = currentCalories });
                    currentCalories = 0;
                }
                else
                {
                    currentCalories = currentCalories + long.Parse(line.Trim());
                }
            }

            return elfList.OrderByDescending(l => l.calories).Take(3).Sum(e => e.calories).ToString();
        }
    }
}