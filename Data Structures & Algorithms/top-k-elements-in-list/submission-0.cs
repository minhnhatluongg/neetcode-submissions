public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Todo 1: dùng dictionary(hashmap) để đếm frequent của element
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int num in nums){
            if(!map.ContainsKey(num)){
                map.Add(num,1);
            }else{
                map[num]++;
            }
        }
        // map = (1 - 1 // 2 -2 // 3 - 3 -> k = 2)
        //Todo 2: sắp xếp bằng phương pháp Bucket sort (index là frequent)
        List<int>[] bucketS = new List<int>[nums.Length + 1];
        foreach(var item in map){
            int num = item.Key;
            int hz = item.Value;
            if(bucketS[hz] == null){
                bucketS[hz] = new List<int>();
            }
            bucketS[hz].Add(num);
        }
        //Todo 3: Lấy ra k phần tử (duyệt từ cuối mảng)
        List<int> result = new List<int>();
        for (int i = bucketS.Length - 1; i >= 0; i--){
            //1. Nếu bucketS[i] == null thì bỏ qua
            if(bucketS[i] == null){
                continue;
            }
            //2. Nếu có List thì duyệt từng num trong List đó
            foreach(int num in bucketS[i])
            {
            //3. Thêm num vào result
            result.Add(num);
            
            }
            //4. Nếu result.Count == k thì trả về result.ToArray();
            if(result.Count == k)
            {
                return result.ToArray();
            }
        }
            return result.ToArray();
    }
}
