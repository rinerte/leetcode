// You are given a string s consisting only of uppercase English letters.

// You can apply some operations to this string where, in one operation, you can remove any occurrence of one of the substrings "AB" or "CD" from s.

// Return the minimum possible length of the resulting string that you can obtain.

// Note that the string concatenates after removing the substring and could produce new "AB" or "CD" substrings.
public class Solution {
    public int MinLength(string s) {
       Stack<char> stack = new();
       stack.Push('`');

       int length = s.Length;
       foreach(char c in s){
        char k = stack.Peek();
        
        if(c=='B'&&k=='A' || k=='C' && c=='D'){
            stack.Pop();
            length-=2;
        } else stack.Push(c);
       }
       return length; 
    }
}
// if without length - its slower
// public class Solution {
//     public int MinLength(string s) {
//        Stack<char> stack = new();
//        stack.Push('`');
//        foreach(char c in s){
//         char k = stack.Peek();
//         if(c=='B'&&k=='A' || k=='C' && c=='D'){
//             stack.Pop();
//         } else stack.Push(c);
//        }
//        return stack.Count()-1; 
//     }
// }