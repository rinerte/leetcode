//There are numBottles water bottles that are initially full of water. You can exchange numExchange empty water bottles from the market with one full water bottle.

//The operation of drinking a full water bottle turns it into an empty bottle.

//Given the two integers numBottles and numExchange, return the maximum number of water bottles you can drink.

public int NumWaterBottles(int numBottles, int numExchange)
{
    int sum = 0;
    int tail = 0;

    while ((numBottles + tail) >= numExchange)
    {
        sum += numBottles;
        int tempBottles = numBottles;
        numBottles = (numBottles + tail) / numExchange;
        tail = (tempBottles + tail) % numExchange;
    }
    return sum + numBottles;
}