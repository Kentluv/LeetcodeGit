public class Merge_Solution {
    public int[][] Merge(int[][] intervals) {
        var result = new List<int[]>();
        if(intervals.Length == 0) return result.ToArray();
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        int start = intervals[0][0];
        int end = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] <= end)
            {
                end = Math.Max(end, intervals[i][1]);
            }
            else
            {
                result.Add(new int[]{start, end});
                start = intervals[i][0];
                end = intervals[i][1];
            }
        }
        result.Add([start, end]);
        return result.ToArray();
    }
}