public class Solution {
    public bool IsAnagram(string s, string t) {
        //check string s = string t
        if(s.Length != t.Length)
            return false;
        
        Dictionary<char,int> charCount = new Dictionary<char,int>();
        //count string s
        foreach(char c in s){
            if(charCount.ContainsKey(c)){
                charCount[c]++;
            }else
            {
                charCount.Add(c,1);
            }
        }
        //count string t
        foreach(char c in t){
            if(!charCount.ContainsKey(c))
                return false;
            charCount[c]--;
        }
        foreach (var k in charCount)
            if(k.Value != 0)
                return false;
        return true;
            }
}
