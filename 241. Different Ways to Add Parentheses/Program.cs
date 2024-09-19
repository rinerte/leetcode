// Given a string expression of numbers and operators, return all possible results from computing all the different possible ways to group numbers and operators. You may return the answer in any order.

// The test cases are generated such that the output values fit in a 32-bit integer and the number of different results does not exceed 104.public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        return F(expression.AsSpan());
        static List<int> F(ReadOnlySpan<char> expression) {
            List<int> results = new();
            for (int i = 0;;) {
                int j = expression[i..].IndexOfAny('+', '-', '*');
                if (j < 0) break;
                j += i;
                i = j + 1;
                var l = F(expression[..j]);
                var r = F(expression[i..]);
                switch (expression[j]) {
                    case '+':
                        foreach (var a in l)
                            foreach (var b in r)
                                results.Add(a + b);
                        break;
                    case '-':
                        foreach (var a in l)
                            foreach (var b in r)
                                results.Add(a - b);
                        break;
                    default:
                        foreach (var a in l)
                            foreach (var b in r)
                                results.Add(a * b);
                        break;
                }
            }
            if (results.Count == 0)
                results.Add(int.Parse(expression));
            return results;
        }
    }
}