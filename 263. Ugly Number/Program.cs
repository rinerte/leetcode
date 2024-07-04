// An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

// Given an integer n, return true if n is an ugly number.

public bool IsUgly(int n) {
        int[] prime = new int[]{2,3,5};
        if(n<=0) return false;
        for(int i=0;i<3;i++){
            if(n==1)return true;
            if(n%prime[i]==0){
                n/=prime[i];
                i--;               
            }
        }
        return false;
    }