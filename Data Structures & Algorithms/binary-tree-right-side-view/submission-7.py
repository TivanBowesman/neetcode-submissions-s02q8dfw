# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        #edge 
        if root is None:
            return []
        
        queue = []
        res = []

        queue.append(root)

        while queue:
            length = len(queue)
            node = None
            for i in range(length):
                node = queue.pop(0)

                if node.left:
                    queue.append(node.left)
                if node.right:
                    queue.append(node.right)

            if node:
                res.append(node.val)

        return res

    # queue - FIFO - POP(0)
    # only add the end of the queue(deals with the excess)