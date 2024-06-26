public int Candy(int[] ratings) {
        int count = 1;
            int up = 0, down = 0, peak = 0;

            for (int i = 0; i < ratings.Length - 1; i++)
            {
                if (ratings[i] < ratings[i + 1])
                {
                    up++;
                    down = 0;
                    peak = up;
                    count += 1 + up;
                }
                else if (ratings[i] == ratings[i + 1])
                {
                    up = down = peak = 0;
                    count++;
                }
                else
                {
                    up = 0;
                    down++;
                    count += 1 + down;
                    if (peak >= down)
                    {
                        count--;
                    }
                }
            }
            return count;
}