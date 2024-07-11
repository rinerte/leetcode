// The Tribonacci sequence Tn is defined as follows: 

// T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

// Given n, return the value of Tn.
public int Tribonacci(int n) {
    int[] arr = new int[]{0,0,1};
    for(int i=0;i<n;i++){
        arr[i%3]=arr[0]+arr[1]+arr[2];
    }
    return arr[(n+1)%3];
}