// A robot on an infinite XY-plane starts at point (0, 0) facing north. The robot can receive a sequence of these three possible types of commands:

// -2: Turn left 90 degrees.
// -1: Turn right 90 degrees.
// 1 <= k <= 9: Move forward k units, one unit at a time.
// Some of the grid squares are obstacles. The ith obstacle is at grid point obstacles[i] = (xi, yi). If the robot runs into an obstacle, then it will instead stay in its current location and move on to the next command.

// Return the maximum Euclidean distance that the robot ever gets from the origin squared (i.e. if the distance is 5, return 25).

// Note:

// North means +Y direction.
// East means +X direction.
// South means -Y direction.
// West means -X direction.
// There can be obstacle in [0,0].

public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        
        HashSet<(int x, int y)> hash = new();
        foreach(int[] o in obstacles) hash.Add((o[0],o[1]));

        int dx =0, dy=1;
        int x=0,y=0;
        int maxDistance =0;
        foreach(int c in commands){
            if(c<0) Turn(ref dx, ref dy, c);
            else{
                for(int i=0; i<c; i++){
                    int tx = x+dx, ty = y+dy;
                    if(!hash.Contains((tx,ty))){
                        x= tx; y = ty;
                        int distance = x*x + y*y;
                        if(distance>maxDistance) maxDistance=distance;
                    }
                }
            }
        }
        return maxDistance;
    }
    private void Turn(ref int dx, ref int dy, int d){
        if(d==-2) d = -1; else d =1;
        if(dx==0){
            dx = d *dy;
            dy = 0;
        } else {
            dy = -d * dx;
            dx =0;
        }
    }
}