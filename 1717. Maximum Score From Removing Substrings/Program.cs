// You are given a string s and two integers x and y. You can perform two types of operations any number of times.

// Remove substring "ab" and gain x points.
// For example, when removing "ab" from "cabxbae" it becomes "cxbae".
// Remove substring "ba" and gain y points.
// For example, when removing "ba" from "cabxbae" it becomes "cabxe".
// Return the maximum points you can gain after applying the above operations on s.
public int MaximumGain(string s, int x, int y) {
        
    string first, second;
    if(x>y){
        first = "ab";
        second = "ba";
    } else {
        first = "ba";
        second = "ab";
        int temp = x;
        x=y;
        y= temp;
    }

    int i=1;
    int count =0;
    bool changed = true;
        while(changed){
            StringBuilder sb = new(s);
            changed = false;
            for(int j=1;j<s.Length;j++){
                if(s[j]==first[1] && s[j-1]==first[0]){
                    sb[j]=' ';
                    sb[j-1]=' ';
                    changed = true;
                    count+=x;
                }
            }
            s = sb.ToString().Replace(" ","");
        }
        changed = true;
        while(changed){
            StringBuilder sb = new(s);
            changed = false;
            for(int j=1;j<s.Length;j++){
                if(s[j]==second[1] && s[j-1]==second[0]){
                    sb[j]=' ';
                    sb[j-1]=' ';
                    changed = true;
                    count+=y;
                }
            }
            s = sb.ToString().Replace(" ","");
        }
        return count;
}