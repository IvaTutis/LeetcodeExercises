public class Solution {
    public int[] RunningSum(int[] nums) {
        var result = new List<int>();
        var runningSum = 0;
        for(int i=0; i<nums.Length; i++){
            runningSum += nums[i];
            result.Add(runningSum);
        }
        return result.ToArray();
    }
}