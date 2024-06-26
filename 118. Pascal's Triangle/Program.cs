public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                for(int j = 0; j < i+1; j++)
                {
                    if (j == 0 || j == i) row.Add(1);
                    else
                    {
                        row.Add(list.Last()[j - 1] + list.Last()[j]);
                    }
                }
                list.Add(row);
            }
            return list;
}