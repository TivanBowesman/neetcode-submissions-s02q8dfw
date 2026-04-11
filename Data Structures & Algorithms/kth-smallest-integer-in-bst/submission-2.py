# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
import heapq

class Solution:
    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        self.heap = []

        self.dfs(root, self.heap)
        for i in range(k - 1):
            heapq.heappop(self.heap)

        return heapq.heappop(self.heap)

    def dfs(self, root, heap):
        if not root:
            return 
        heapq.heappush(self.heap, root.val)
        self.dfs(root.left,heap)
        self.dfs(root.right, heap)
    #use a priority queue
    #pop until k