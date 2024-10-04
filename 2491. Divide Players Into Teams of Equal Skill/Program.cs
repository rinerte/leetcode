// You are given a positive integer array skill of even length n where skill[i] denotes the skill of the ith player. Divide the players into n / 2 teams of size 2 such that the total skill of each team is equal.

// The chemistry of a team is equal to the product of the skills of the players on that team.

// Return the sum of the chemistry of all the teams, or return -1 if there is no way to divide the players into teams such that the total skill of each team is equal.
public class Solution {
    public long DividePlayers(int[] skill) {
        Array.Sort(skill);

        int sum = skill[0]+skill[^1];
        long chem =skill[0]*skill[^1];

        for(int i=1;i<skill.Length/2;i++){
            if(skill[i]+skill[^(i+1)]!=sum) return -1;
            chem+=skill[i]*skill[^(i+1)];
        }
        return chem;
    }
}