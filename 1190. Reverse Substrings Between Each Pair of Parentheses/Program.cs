// You are given a string s that consists of lower case English letters and brackets.

// Reverse the strings in each pair of matching parentheses, starting from the innermost one.

// Your result should not contain any brackets.
using System.Text;

Console.WriteLine(ReverseParentheses("(abcd)"));

static string ReverseParentheses(string s) {
    Stack<int> indexes = new();
    StringBuilder sb = new(s);

    for(int i=0;i<s.Length;i++){
        if(s[i]=='(')
        indexes.Push(i);
        else
        if(s[i]==')'){
            int k = indexes.Pop();
            Console.WriteLine(" K is "+k);
            int delta = 0;
            for(int j=k;j<=k+(i-k)/2;j++){
                var temp = sb[j];
                sb[j]=sb[i-delta];
                sb[i-delta]=temp;
                delta++;
                Console.WriteLine("J ="+j+"; k+(i-k)/2 = "+(k+(i-k)/2));
                Console.WriteLine(sb.ToString() + "       ;");
            }
            
        }
    }
    int clear = 0;
    for(int i =0;i<sb.Length;i++){
        if(sb[i]!=')' && sb[i]!='('){
            sb[clear] = sb[i];
            clear++;
        }
    }
    return sb.ToString().Substring(0,clear);
}