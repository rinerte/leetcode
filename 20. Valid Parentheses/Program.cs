public bool IsValid(string s) {
        Dictionary<char, char> type = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}' }
            };
            Dictionary<char, char> typeInverted = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{' }
            };

            Stack<char> opened = new Stack<char>();
            char popped;

            for (int i = 0; i < s.Length; i++)
            {
                if (type.ContainsKey(s[i]))
                {
                    opened.Push(s[i]);
                } else
                {
                    popped = '-';
                    opened.TryPeek(out popped);
                    if (typeInverted.GetValueOrDefault(s[i]) == popped)
                    {              
                        if (!opened.TryPop(out popped)) return false;
                    } else
                    {
                        return false;
                    }
                }
            }

            return !opened.TryPop(out popped);
}