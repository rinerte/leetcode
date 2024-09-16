// Given a list of 24-hour clock time points in "HH:MM" format, return the minimum minutes difference between any two time-points in the list.
public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        List<int> result = new List<int>();

        for(int i = 0;i < timePoints.Count; i++)
        {
            string[] time = timePoints[i].Split(':');

            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            int totalMinute = hour * 60 + minute;

            result.Add(totalMinute);
        }

        result.Sort();

        int min = int.MaxValue;

        for(int i = 0; i < result.Count-1; i++)
        {
            if (result[i+1] - result[i] < min)
            {
                min = result[i + 1] - result[i];
            }
        }

        int dif = (result[0] + 1440) - result[result.Count-1];

        if(dif < min)
        {
            min = dif;
        }
                
        return min;
    }
}