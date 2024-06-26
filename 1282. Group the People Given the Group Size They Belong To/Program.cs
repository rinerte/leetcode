public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        IList<IList<int>> people = new List<IList<int>>();
            Dictionary<int,IList<int>> peopleDictionary = new Dictionary<int,IList<int>>();

            for(int i=0;i<groupSizes.Length; i++)
            {
                if (!peopleDictionary.ContainsKey(groupSizes[i])) peopleDictionary[groupSizes[i]] = new List<int>();
                peopleDictionary[groupSizes[i]].Add(i);
            }
            
            foreach(int i in peopleDictionary.Keys)
            {
                while (peopleDictionary[i].Count > 0) //peopleDictionary[i] - elements of group N
                {
                    var list = new List<int>();
                    for (int j = 0; j < i; j++)
                    {
                        if (peopleDictionary[i].Count() > 0)
                        {
                            list.Add(peopleDictionary[i].Last());
                            peopleDictionary[i].RemoveAt(peopleDictionary[i].Count - 1);
                        }
                        else break;
                    }
                    people.Add(list);
                }
            }

            return people;
}