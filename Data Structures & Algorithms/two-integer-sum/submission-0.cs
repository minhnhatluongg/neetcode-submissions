public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //check value by Dictionary
        Dictionary<int,int> map = new Dictionary<int,int>();
        //
        for(int i = 0; i < nums.Length; i++){
            //cal complement
            int complement = target - nums[i];
            if(map.ContainsKey(complement))
                return new int[] {map[complement],i};
            else{
                map.Add(nums[i],i);
            }            
        }
        return new int[0];
    }
}
