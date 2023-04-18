public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        if(s.Length>t.Length) return false;
        
        //map t
        Dictionary<char,List<int>> tDict = new();
        for(int i=0; i<t.Length;i++){
            if(tDict.TryGetValue(t[i], out var list_indexes)){
                tDict[t[i]].Add(i);
            }else{
                tDict.Add(t[i], new List<int>{ i });
            }
        }
        
        //contains all letters
        for(int j=0; j<s.Length; j++){
            if(!tDict.TryGetValue(s[j], out var list_indexes)){
                return false;
            }
        }
        
        //letters in order
        var lastIndexInT = -1;
        for(int j=0; j<s.Length; j++){
            if(tDict.TryGetValue(s[j], out var list_indexes)){
                //too lazy to do binary search, could since the list is sorted
                bool found_ok_index = false;
                for(int k=0;k<list_indexes.Count; k++){
                    if(list_indexes[k]>lastIndexInT){
                        lastIndexInT= list_indexes[k];
                        found_ok_index=true;
                        break;
                    }
                }
                if(!found_ok_index) return false;
            }
        }
        
        return true; 
    }
}