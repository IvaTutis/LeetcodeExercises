public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2];

        var dictionary = new Dictionary<int,int>();
        for(var i=0; i<nums.Length; i++){
            try{
            dictionary.Add(nums[i], i);
            }catch{
                //ignore duplicate values
                continue;
            };
        }

        //for 2 half-values, since dictionary works only w unique values 
        try{
            if(dictionary.TryGetValue(target/2, out var value1)){
                var index1 = value1;
                for(var i=0; i<nums.Length; i++){
                    if(nums[i]==target/2 && i!=index1){
                        result[0]=index1;
                        result[1]=i;
                        return result;
                    }
                };
            }
        }catch{}

        //find the two number pair that sums to target, return indices
        foreach(var number1 in dictionary.Keys.ToList()){
            var number2=target-number1;
            if(number2!= number1
                && dictionary.TryGetValue(number1, out var value1)
                && dictionary.TryGetValue(number2, out var value2)
                && number1+number2==target){
                    result[0]=value1;
                    result[1]=value2;
                    return result;
                }
        }

        return result;
    }
}