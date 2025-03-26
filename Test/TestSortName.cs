namespace Test
{
    public class TestSortName
    {
        [Fact]
        public void TestArraySort()
        {
            string[] array = { "Janet Parsons", 
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter"
            };
            string[] sortedArray = { "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };

            NameSorter.NameSorter.SortNames(array);
            bool result = array.SequenceEqual(sortedArray);
            Assert.True(result);
        }

        [Fact]
        public void TestLongArraySort()
        {
            string[] array = new string[1000];
            for (int i = 0; i < array.Length; i++)
            {
                string idx = i.ToString().PadLeft(3, '0');

                if (i % 100 < 80)
                    array[i] = $"Firstname{idx} zLastname{idx}";
                else if (i % 100 < 90)
                    array[i] = $"Firstname{idx} Second{idx} zLastname{idx}";
                else
                    array[i] = $"Firstname{idx} Second{idx} Thrid{idx} zLastname{idx}";
            }

            string[] copiedArray = array.ToArray();
            Random rand = new Random();
            //unsort array
            for (int i = 0; i < copiedArray.Length; i++)
            {
                int j = rand.Next(i, copiedArray.Length);
                string temp = copiedArray[i];
                copiedArray[i] = copiedArray[j];
                copiedArray[j] = temp;
            }
            NameSorter.NameSorter.SortNames(copiedArray);
            bool result = array.SequenceEqual(copiedArray);
            Assert.True(result);
        }
    }
}