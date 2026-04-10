# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        #edge case
        if not p and not q:
            return True

        if not p or not q:
            return False

        return self.dfs(p, q)
    def dfs(self, p, q):
        #check nodes
        if q is None and p is None:
            return True
        
        #check for one false 
        if not p or not q:
            return False


        #check vals
        if p.val != q.val:
            return False

        return self.dfs(p.left, q.left) and self.dfs(p.right, q.right)
