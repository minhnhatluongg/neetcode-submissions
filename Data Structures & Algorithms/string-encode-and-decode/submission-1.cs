public class Solution {

    public string Encode(IList<string> strs) {
       string result ="" ;
       foreach (string str in strs){
        result += str.Length + "#" + str;
       }
       return result;
    }

    public List<string> Decode(string s) {
        int i = 0; 
        List<string> result = new List<string>();
        while (i < s.Length){
            string number = "";
            while (i < s.Length && char.IsDigit(s[i])){
                number += s[i];
                i++;
            }
            // Nếu gặp phải # thì skip qua # và chuyển string number sang int để biết lấy bao nhiêu số
            i++; //skip nếu gặp
            int length = int.Parse(number); //parse int
            string word = s.Substring(i,length); //cắt from .. to
            result.Add(word);
            i += length;
        }
        return result;
   }
}
