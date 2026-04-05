class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        
        hashset = set()
        #set up window
        l = 0 

        longest = 0

        for r in range(len(s)):
            char = s[r]
            #add to set
            if char in hashset:
                while char in hashset:
                    hashset.remove(s[l])
                    l += 1

            hashset.add(char)

            window = r - l + 1
            longest = max(longest, window)
        
        return longest