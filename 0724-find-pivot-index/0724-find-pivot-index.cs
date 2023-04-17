public class Solution {
    public int PivotIndex(int[] nums) {
        var index = 0;
        int strictlyLeftSum = 0;
        int strictlyRightSum = 0;
        for(int i =0; i<nums.Length; i++){
            if (i<index){
                strictlyLeftSum +=nums[i];
            }
            if (i>index){
                strictlyRightSum +=nums[i];
            }
        }
        
        if(strictlyLeftSum==strictlyRightSum) return index;
        
        var sumDifference=strictlyLeftSum-strictlyRightSum;
        var sumDifferenceByMovingIndexUp=0;
        for (int i=1; i<nums.Length; i++){
            sumDifferenceByMovingIndexUp-=nums[i-1];
            sumDifferenceByMovingIndexUp-=nums[i];
            if(sumDifference==sumDifferenceByMovingIndexUp){
                return i;
            }
        }
        
         return -1;
    }
}