public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[]nums3= nums1.Concat(nums2).ToArray();
        Array.Sort(nums3);
        if(nums3.Length%2==1)
            return nums3[nums3.Length/2];
        else
        {   
            int index1=nums3.Length/2;
            int index2=index1-1;
            return ((double)(nums3[index1]+nums3[index2]))/2;
        }

        
    }
}