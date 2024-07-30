// You are given a string s consisting only of characters 'a' and 'b'​​​​.

// You can delete any number of characters in s to make s balanced. s is balanced if there is no pair of indices (i,j) such that i < j and s[i] = 'b' and s[j]= 'a'.

// Return the minimum number of deletions needed to make s balanced.
public int MinimumDeletions(string s) {
    int count =0;
    Stack<char> stack = new();

    for(int i=0;i<s.Length;i++){
        if(s[i]=='a' && stack.Any()){
            count++;
            stack.Pop();
        } else
        if(s[i]=='b') stack.Push('b');
    }
    return count;
}