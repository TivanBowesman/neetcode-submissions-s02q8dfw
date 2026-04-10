# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        #edge case
        if root is None:
            return []
        

        queue = []
        res = []

        #add first item to queue
        queue.append(root)
        while queue:
            length = len(queue)
            currList = []
            for i in range(length):
                node = queue.pop(0)
                #check if node is not null
                currList.append(node.val)

                #add new item to end of queue
                if node.left != None:
                    queue.append(node.left)
                
                if node.right != None: 
                    queue.append(node.right)

            res.append(currList)
        
        return res
        
    

    #queue for level order
    #FIFO - Pop from front ( Pop(0) )