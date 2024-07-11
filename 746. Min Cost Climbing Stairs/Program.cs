﻿// You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

// You can either start from the step with index 0, or the step with index 1.

// Return the minimum cost to reach the top of the floor.
public int MinCostClimbingStairs(int[] cost) {
    for(int i=2;i<cost.Length;i++){
        cost[i]= cost[i]+Math.Min(cost[i-1],cost[i-2]);
    }
    return Math.Min(cost[^1],cost[^2]);
}