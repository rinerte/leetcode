// At a lemonade stand, each lemonade costs $5. Customers are standing in a queue to buy from you and order one at a time (in the order specified by bills). Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill. You must provide the correct change to each customer so that the net transaction is that the customer pays $5.

// Note that you do not have any change in hand at first.

// Given an integer array bills where bills[i] is the bill the ith customer pays, return true if you can provide every customer with the correct change, or false otherwise.
public bool LemonadeChange(int[] bills) {
    int[] ar = new int[]{0,0};

    foreach(int b in bills){
        if(b==5) ar[0]++;
        if(b==10){
            if(ar[0]>0){
                ar[0]--;
                ar[1]++;
            } else return false;
        }
        if(b==20){
            if(ar[0]>0 && ar[1]>0){
                ar[1]--;
                ar[0]--;
            } else if(ar[0]>2) ar[0]-=3; else return false;
        }
    }
    return true;
}