# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def goodNodes(self, root: TreeNode) -> int:
        
        return self.dfs(root, -100)
    
    def dfs(self, root, currMax):
        isgood = 0
        if not root:
            return 0
        
        if root.val >= currMax:
            isgood = 1
        
        #update the max
        currMax = max(currMax, root.val)
        
        return isgood + self.dfs(root.left, currMax) + self.dfs(root.right, currMax)
    #pass the new maximum along the tree
