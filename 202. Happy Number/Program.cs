public bool IsHappy(int n) {
        HashSet<int> sums = new HashSet<int>();

            while (n!=1)
            {
                char[] chars = n.ToString().ToCharArray();
                int sum = 0;
                foreach(char c in chars)
                {
                    sum += (int)Math.Pow(Convert.ToInt32(c-48), 2);
                }
                n = sum;
                if (sums.Contains(n)) return false;
                sums.Add(n);
            }
            return true;
}