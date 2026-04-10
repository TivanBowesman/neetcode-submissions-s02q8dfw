# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        
        return self.dfs(root, -1001, 1001)
    def dfs(self, root, minVal, maxVal):
        if not root:
            return True

        if minVal < root.val < maxVal:
            pass
        else:
            return False
        
        #upadate min and max by the traversal path 

        return self.dfs(root.left, minVal, root.val) and self.dfs(root.right, root.val,maxVal)
    
    #similar to good nodes
    # val should be in min < val < max
    #use AND operator