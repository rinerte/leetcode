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
    while(i>=0){
        i = s.IndexOf(first);
        count+=x;
        if(i<0) {
            i = s.IndexOf(second);
            count-=x;
            count+=y;
        }
        if(i<0) {
            count-=y;
            break;
        }
        s = s.Remove(i,2);
    }
    return count;
}