from typing import List

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagrams = {}  # plain dict

        for s in strs:
            count = [0] * 26
            for letter in s:
                count[ord(letter) - ord('a')] += 1

            key = tuple(count)  # must be tuple (hashable)
            if key not in anagrams:
                anagrams[key] = []
            anagrams[key].append(s)

        return list(anagrams.values())
