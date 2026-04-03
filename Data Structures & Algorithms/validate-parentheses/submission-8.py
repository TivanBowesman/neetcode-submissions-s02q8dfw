class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        map = {')': '(',
                ']': '[',
                '}': '{'
            }

        for char in s:
            if char in map.keys():
                # It's a closing bracket
                #[-1] is peek
                if len(stack) == 0 or stack[-1] != map[char]:
                    return False
                stack.pop()
            else:
                # It's an opening bracket
                stack.append(char)

        return len(stack) == 0

            

            
                


#Stacks are LIFO
