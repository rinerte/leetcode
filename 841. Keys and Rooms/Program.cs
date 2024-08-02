// There are n rooms labeled from 0 to n - 1 and all the rooms are locked except for room 0. Your goal is to visit all the rooms. However, you cannot enter a locked room without having its key.

// When you visit a room, you may find a set of distinct keys in it. Each key has a number on it, denoting which room it unlocks, and you can take all of them with you to unlock the other rooms.

// Given an array rooms where rooms[i] is the set of keys that you can obtain if you visited room i, return true if you can visit all the rooms, or false otherwise.
public bool CanVisitAllRooms(IList<IList<int>> rooms) {
    HashSet<int> hash = new HashSet<int>();
    Stack<int> stack = new Stack<int>();
    int[] visited = new int[rooms.Count];
    stack.Push(0);

    while(stack.Any()){

        int room = stack.Pop();            
        visited[room]= 1;
        hash.Add(room);
        if(hash.Count == rooms.Count) return true;
        
        foreach(int item in rooms[room]){
            if(visited[item]!=1){
                stack.Push(item);
            }                
        }
    }
    return hash.Count == rooms.Count;
}