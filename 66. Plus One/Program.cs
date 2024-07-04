// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

// Increment the large integer by one and return the resulting array of digits.

public int[] PlusOne(int[] digits) {
    for(int i=digits.Length-1;i>=0;i--){
        digits[i]++;
        if(digits[i]<10) return digits;
        digits[i]-=10;
    }

    var x = new int[1]{1};
    var r = new int[digits.Length + 1];
    x.CopyTo(r, 0);
    digits.CopyTo(r, 1);
    return r;
}