public class Solution {
    
    public int LengthOfLongestSubstring(string s) {
     
        if (s=="") return 0; 
        
        var right=0; 
        var left=0;
        var maxLength=0;
        var charset = new HashSet<char>();
        
        while (right<s.Length){
            if(!charset.Contains(s[right])){
                charset.Add(s[right]);
                right++;
                maxLength=Math.Max(maxLength, charset.Count);
            }else{
                charset.Remove(s[left]);
                left++;
            }
        }
        
        return maxLength;
    }
}