public class Solution {
    
    public int LengthOfLongestSubstring(string s) {
        
        var right=0; 
        var left=0;
        var maxLength=0;
        var charSet = new HashSet<char>();
        
        while (right<s.Length){
            if(!charSet.Contains(s[right])){
                charSet.Add(s[right]);
                right++;
                maxLength=Math.Max(maxLength, charSet.Count);
            }else{
                charSet.Remove(s[left]);
                left++;
            }
        }
        
        return maxLength;
    }
}