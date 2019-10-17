using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLogCodingTest
{
    public class PureRandomMethod : IRandomizationMethod
    {
        public static String _name = "Pure Random";

        //randomizes animals into groups by finding median body weight
        public Animal[] Randomize(String[] groups, Animal[] animals)
        {
            int group1Count = 0;
            int group2Count = 0;

            List<Animal> sortedAnimals = new List<Animal>(sortByWeight(animals));
            List<Animal> groupedAnimals = new List<Animal>();

            for (int x = sortedAnimals.Count - 1; x >= 0; x--)
            {
                int index = findMedian(x);

                if (group1Count <= group2Count)
                {
                    sortedAnimals[index].Group = groups[0];
                    group1Count++;
                }
                else
                {
                    sortedAnimals[index].Group = groups[1];
                    group2Count++;
                }
                groupedAnimals.Add(sortedAnimals[index]);
                sortedAnimals.RemoveAt(index);
            }
            return groupedAnimals.ToArray();
        }

        //sorts animals by body weight ascending order
        private Animal[] sortByWeight(Animal[] animals)
        {
            return animals.OrderBy(a => a.Weight).ToArray();
        }

        //finds median
        private int findMedian(int x)
        {
            return (x / 2);
        }
    }
}
