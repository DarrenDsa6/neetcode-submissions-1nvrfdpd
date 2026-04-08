public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int len1 = nums1.Length;
        int len2 = nums2.Length;
        int[] merged = new int[len1 + len2];
        int i = 0, j = 0, index = 0;
        while (i < len1 && j < len2) {
            if (nums1[i] < nums2[j]) {
                merged[index++] = nums1[i++];
            } else {
                merged[index++] = nums2[j++];
            }
        }

        while (i < len1) {
            merged[index++] = nums1[i++];
        }
        while (j < len2) {
            merged[index++] = nums2[j++];
        }

        int mergedLen = merged.Length;
        if (mergedLen % 2 == 0) {
            return (merged[mergedLen / 2 - 1] + merged[mergedLen / 2]) / 2.0;
        } else {
            return merged[mergedLen / 2];
        }
    }
}
