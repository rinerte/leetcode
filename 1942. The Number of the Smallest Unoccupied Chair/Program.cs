// There is a party where n friends numbered from 0 to n - 1 are attending. There is an infinite number of chairs in this party that are numbered from 0 to infinity. When a friend arrives at the party, they sit on the unoccupied chair with the smallest number.

// For example, if chairs 0, 1, and 5 are occupied when a friend comes, they will sit on chair number 2.
// When a friend leaves the party, their chair becomes unoccupied at the moment they leave. If another friend arrives at that same moment, they can sit in that chair.

// You are given a 0-indexed 2D integer array times where times[i] = [arrivali, leavingi], indicating the arrival and leaving times of the ith friend respectively, and an integer targetFriend. All arrival times are distinct.

// Return the chair number that the friend numbered targetFriend will sit on.
public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        PriorityQueue<(int time, int chair), int> departure = new();
        PriorityQueue<int,int> freeChairs = new();
        foreach(var t in times.Select(
            (t,i)=>(arrive:t[0],depart:t[1],index:i)
        ).OrderBy(e=>e.arrive)){
            while(departure.Count>0 && departure.Peek().time<=t.arrive){
                int c = departure.Dequeue().chair;
                freeChairs.Enqueue(c,c);
            }
            int chair = freeChairs.Count>0 ? freeChairs.Dequeue() : departure.Count;
            if(t.index==targetFriend) return chair;
            departure.Enqueue((t.depart,chair), t.depart);
        }
        return 0;
    }
}