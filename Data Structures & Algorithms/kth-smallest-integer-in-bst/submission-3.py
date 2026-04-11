# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        self.res = []

        self.dfs(root, self.res)
        #1 indexed ( K - 1)
        return self.res[k - 1]

    def dfs(self, root, res):
        if not root:
            return 

        #InOrder = Left - Node - Right
        self.dfs(root.left, self.res)
        self.res.append(root.val)
        self.dfs(root.right,self.res)
        
    
    #perform inOrder traversal