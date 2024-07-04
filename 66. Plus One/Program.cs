// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

// Increment the large integer by one and return the resulting array of digits.

public int[] PlusOne(int[] digits) {
    bool tail = false;
    digits[^1]++;
    for(int i=digits.Length-1;i>=0;i--){
        if(tail) digits[i]++;

        if(digits[i]>9){
            tail = true;
            digits[i]-=10;
        } else tail = false;
    }

    if(tail){
        var x = new int[1]{1};
        var r = new int[digits.Length + 1];
        x.CopyTo(r, 0);
        digits.CopyTo(r, 1);
        return r;
    }
    return digits;
}