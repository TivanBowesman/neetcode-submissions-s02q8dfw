# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def invertTree(self, root: Optional[TreeNode]) -> Optional[TreeNode]:
        #treat each node as its own tree beginning 
        if root is None:
            return
            
        #swap roots
        root.left,root.right = root.right, root.left

        self.invertTree(root.left)
        self.invertTree(root.right)

        return root
