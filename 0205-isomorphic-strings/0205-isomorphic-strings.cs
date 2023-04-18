public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        if(t.Length!=s.Length)return false;
        
        List<char> sList = new List<char>();
        sList.AddRange(s);
        List<char> tList = new List<char>();
        tList.AddRange(t);
        
        HashSet<char> s_contains = new();
        Dictionary<char, char> t_to_s = new(); 
        Dictionary<char, char> s_to_t = new(); 
        
        for(int i=0;i<s.Length; i++){
            var currentCharInS = sList[i];
            var currentCharInT = tList[i];
             if(s_contains.Contains(currentCharInS)){
                 if(s_to_t.TryGetValue(currentCharInS, out var t_i_expected)
                   && t_i_expected==currentCharInT){
                       continue;
                   }else{
                        return false;
                   }

              }else{

                   if(t_to_s.TryGetValue(currentCharInT, out var s_i_coded)){
                      return false;
                   }else{
                       s_contains.Add(currentCharInS);
                       t_to_s.Add(currentCharInT,currentCharInS);
                       s_to_t.Add(currentCharInS,currentCharInT);
                       
                   }
              }
        }
        
        return true;
        
    }
}