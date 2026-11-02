public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        for(int num = 0; num < nums.Length; num ++){
            if(!set.Add(nums[num]))
            return true;
        }
        return false;
    }
}