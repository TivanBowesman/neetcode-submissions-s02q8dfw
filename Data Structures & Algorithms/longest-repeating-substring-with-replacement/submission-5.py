class Solution:
    def characterReplacement(self, s: str, k: int) -> int:  

        #max - k > 0 its valid for a long string
        charArray = [0] * 26 
        l = 0
        maxLength = 0

        for r,i in enumerate(s):
            charArray[ord(i) - ord('A')] += 1

            window = r - l + 1
            while window - max(charArray)  > k:
                charArray[ord(s[l]) - ord('A')] -= 1
                l += 1
                window = r - l + 1
                
            

            

            maxLength = max(window, maxLength)

        return maxLength

