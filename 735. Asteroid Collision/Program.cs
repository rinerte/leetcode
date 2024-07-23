// We are given an array asteroids of integers representing asteroids in a row.

// For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

// Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.
public int[] AsteroidCollision(int[] asteroids) {
    Stack<int> stack = new();
    foreach(int i in asteroids) TryPush(i,stack);
    return stack.Reverse().ToArray();
}

void TryPush(int i, Stack<int> stack){
    if(i>0) stack.Push(i);
    if((!stack.Any() || stack.Peek()<0) && i<0) {
        stack.Push(i);
        return;
    }
    if(stack.Any() && i<0){
        int j = Crash(stack.Pop(),i);
        if(j==0) return;
        if(j>0) stack.Push(j);
        else TryPush(j,stack);
    }
    
}
int Crash(int i, int j){
    if(i==Math.Abs(j)) return 0;
    if(i<Math.Abs(j)) return j; else return i;
}