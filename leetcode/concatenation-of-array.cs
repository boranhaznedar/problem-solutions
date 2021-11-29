public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int[] twiceNums = new int[2 * nums.Length];
        for (int i = 0; i < nums.Length; i++){
            twiceNums[i] = nums[i];
            twiceNums[i + nums.Length] = nums[i];
        }
        return twiceNums;
        
    }
}