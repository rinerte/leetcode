// Given an array of characters chars, compress it using the following algorithm:

// Begin with an empty string s. For each group of consecutive repeating characters in chars:

// If the group's length is 1, append the character to s.
// Otherwise, append the character followed by the group's length.
// The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

// After you are done modifying the input array, return the new length of the array.

// You must write an algorithm that uses only constant extra space.
public int Compress(char[] chars) {
    int count =1;
    int pointer =0;

    for(int i=1;i<=chars.Length;i++){
        if(i<chars.Length && chars[i]==chars[i-1]) count++ ;else {
            if(count==1){
                chars[pointer++] = chars[i-1];
            } else {
                chars[pointer++] = chars[i-1];
                char[] number = count.ToString().ToCharArray();
                for(int j=0;j<number.Length;j++){
                    chars[pointer++] = number[j];
                }
                count =1;
            }
        }
    }
    return pointer;
}