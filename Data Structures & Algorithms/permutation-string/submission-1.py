class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        #edge case
        if len(s1) > len(s2):
            return False

        s1Count = [0] * 26
        s2Count = [0] * 26

        #populate freq arr
        for i in range(len(s1)):
            s1Count[ord(s1[i]) - ord('a')] += 1
            s2Count[ord(s2[i]) - ord('a')] += 1

        #check the first window to confirm if its a match
        if self.match(s1Count,s2Count):
            return True

        for i in range(len(s1) , len(s2)):
            #add the char to right of current window
            s2Count[ord(s2[i]) - ord('a')] += 1
            
            #remove the left the beginning of window char 
            s2Count[ord(s2[i - len(s1)]) - ord('a')] -= 1

            if self.match(s1Count,s2Count): 
                return True
        
        return False



    def match(self, arr1, arr2):
        for i in range(len(arr1)):
            if arr1[i] != arr2[i]:
                return False
        
        return True