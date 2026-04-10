# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isBalanced(self, root: Optional[TreeNode]) -> bool:
        #edge case 
        if not root:
            return True
        self.res = True
        self.dfs(root)

        return self.res

    def dfs(self, root):
        if root is None:
            return 0

        left = self.dfs(root.left)
        right = self.dfs(root.right)

        if abs(right - left ) > 1:
            self.res = False



        return 1 + max(left,right)
    

    #check if left and right are within one 
    #abs(left - right) > 1 