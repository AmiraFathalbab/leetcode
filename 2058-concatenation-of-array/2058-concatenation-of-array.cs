public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans=new int[2*nums.Length];
        for(int j=0;j<nums.Length+1;j+=nums.Length)
        {
            for(int i=0;i<nums.Length;i++)
            {
                
                ans[i+j]=nums[i];               
                
            }
        }
        return ans;
    }
}