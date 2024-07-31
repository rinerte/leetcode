// You are given an array books where books[i] = [thicknessi, heighti] indicates the thickness and height of the ith book. You are also given an integer shelfWidth.

// We want to place these books in order onto bookcase shelves that have a total width shelfWidth.

// We choose some of the books to place on this shelf such that the sum of their thickness is less than or equal to shelfWidth, then build another level of the shelf of the bookcase so that the total height of the bookcase has increased by the maximum height of the books we just put down. We repeat this process until there are no more books to place.

// Note that at each step of the above process, the order of the books we place is the same order as the given sequence of books.

// For example, if we have an ordered list of 5 books, we might place the first and second book onto the first shelf, the third book on the second shelf, and the fourth and fifth book on the last shelf.
// Return the minimum possible height that the total bookshelf can be after placing shelves in this manner.
public int MinHeightShelves(int[][] books, int shelfWidth) {
    int[] dp = new int[books.Length+1];
    dp[0]=0;
    dp[1] = books[0][1];

    for(int i=2;i<=books.Length;i++){
        int remain = shelfWidth - books[i-1][0];
        int maxH = books[i-1][1];
        dp[i] = books[i-1][1]+dp[i-1];

        int j = i-1;

        while(j>0 && remain - books[j-1][0]>=0){
            maxH = Math.Max(maxH,books[j-1][1]);
            remain-=books[j-1][0];
            dp[i]=Math.Min(dp[i],maxH+dp[j-1]);
            j--;
        }
    }
    return dp[books.Length];
}