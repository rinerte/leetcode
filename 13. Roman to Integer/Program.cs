public int RomanToInt(string s) {
        List<int> numbers = new List<int>();

            while (s != "")
            {
                if (s.Contains("CM"))
                {
                    int index = s.IndexOf("CM");
                    numbers.Add(900);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("CD"))
                {
                    int index = s.IndexOf("CD");
                    numbers.Add(400);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("XC"))
                {
                    int index = s.IndexOf("XC");
                    numbers.Add(90);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("XL"))
                {
                    int index = s.IndexOf("XL");
                    numbers.Add(40);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("IX"))
                {
                    int index = s.IndexOf("IX");
                    numbers.Add(9);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("IV"))
                {
                    int index = s.IndexOf("IV");
                    numbers.Add(4);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("M"))
                {
                    int index = s.IndexOf("M");
                    numbers.Add(1000);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("D"))
                {
                    int index = s.IndexOf("D");
                    numbers.Add(500);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("C"))
                {
                    int index = s.IndexOf("C");
                    numbers.Add(100);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("L"))
                {
                    int index = s.IndexOf("L");
                    numbers.Add(50);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("X"))
                {
                    int index = s.IndexOf("X");
                    numbers.Add(10);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("V"))
                {
                    int index = s.IndexOf("V");
                    numbers.Add(5);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("I"))
                {
                    int index = s.IndexOf("I");
                    numbers.Add(1);
                    s = s.Remove(index, 1);
                    continue;
                }
            }

            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            return sum;
    }