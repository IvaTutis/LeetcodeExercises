public class Solution {
    
    public int LengthOfLongestSubstring(string s) {
     
        if (s=="") return 0; 
        
        var right=0; 
        var left=0;
        var max_length=0;
        var charset = new HashSet<char>();
        
        while (right<s.Length){
            if(!charset.Contains(s[right])){
                charset.Add(s[right]);
                right++;
                max_length=Math.Max(max_length, charset.Count);
            }else{
                charset.Remove(s[left]);
                left++;
            }
        }
        
        return max_length;
    }
}