// You are given a string s and two integers x and y. You can perform two types of operations any number of times.

// Remove substring "ab" and gain x points.
// For example, when removing "ab" from "cabxbae" it becomes "cxbae".
// Remove substring "ba" and gain y points.
// For example, when removing "ba" from "cabxbae" it becomes "cabxe".
// Return the maximum points you can gain after applying the above operations on s.
Console.WriteLine(MaximumGain("aabbabkbbbfvybssbtaobaaaabataaadabbbmakgabbaoapbbbbobaabvqhbbzbbkapabaavbbeghacabamdpaaqbqabbjbababmbakbaabajabasaabbwabrbbaabbafubayaazbbbaababbaaha",1926,4320));

int MaximumGain(string s, int x, int y) {        
    string first, second;
        if(x>y){
            first = "ab";
            second = "ba";
        } else {
            first = "ba";
            second = "ab";
            (x,y)=(y,x);
        }

        int count =0;
        Stack<char> st = new();

        for(int i=0;i<s.Length;i++){
            if(st.Count()>0 && st.Peek().ToString()+s[i].ToString()==first) {
                st.Pop();
                count+=x;
            } else
            st.Push(s[i]);
        }

        Stack<char> st2 = new();

        while(st.Count()>0){
            var ch = st.Pop();
            if(st2.Count()>0 && ch.ToString()+st2.Peek().ToString()==second){
                count+=y;
                st2.Pop();
            } else st2.Push(ch);
        }
        return count;
}