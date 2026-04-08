from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        ans = {}
        for i, num in enumerate(nums):
            # If current number is a key in ans, we found the pair
            if num in ans:
                return [ans[num], i]
            # Otherwise, store the complement as key
            ans[target - num] = i
