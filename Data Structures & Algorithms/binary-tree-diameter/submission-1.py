# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:
        #edge case 
        if not root:
            return 0
        #get the max depth from both sides

        #make global to class
        self.deepest = 0 

        self.dfs(root)
        return self.deepest
    
    def dfs(self,root):
        if root is None:
            return 0
        
        #get values
        left = self.dfs(root.left)
        right = self.dfs(root.right)

        self.deepest = max(self.deepest, left + right)

        return 1 + max(left,right)