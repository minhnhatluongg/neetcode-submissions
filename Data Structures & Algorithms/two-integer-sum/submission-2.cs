public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //check value by Dictionary
        Dictionary<int,int> map = new Dictionary<int,int>(nums.Length);
        //
        for(int i = 0; i < nums.Length; i++){
            //cal complement
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int index)) {
                return new int[] { index, i };
            }
            // Dùng indexer thay vì .Add() để không bị lỗi nếu mảng có 2 số giống nhau
            map[nums[i]] = i;         
        }
        return Array.Empty<int>();
    }
}
