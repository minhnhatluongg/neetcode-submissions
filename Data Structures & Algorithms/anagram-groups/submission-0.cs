public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        foreach(string word in strs)
        {
            //Todo 1 : Tạo mảng count gồm 26 phần tử (theo bảng chữ cái alpha)
            int[] count = new int[26];
            //Todo 2 : Duyệt word và đếm kí tự
            // for(int i = 0; i < word.Length; i++) {
            //     char c = word[i];
            //     count[c - 'a']++
            // }
            //Todo 2.x :
            foreach(char c in word){
                count[c - 'a']++;
            }
            //Todo 3: Chuyển word sang kiểu string để so sánh.(string key)
            string key = string.Join(",",count);
            //Todo 4 : Kiểm tra key, nếu tồn tại -> thêm vào List<string>, không thì tạo mới
            if(map.ContainsKey(key)){
                map[key].Add(word);
            }else{
                map[key] = new List<string>{word};
            }
        }
        //Todo 5 in ra danh sách output nhỉ
        return map.Values.ToList();
    }
}
