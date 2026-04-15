import heapq

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        #use min heap to add to list
        heap = []
        heapq.heapify(heap)

        node = list1
        while node != None:
            heapq.heappush(heap, -node.val)
            node = node.next

        node = list2
        while node != None:
            heapq.heappush(heap, -node.val)
            node = node.next

        prev = None
        while heap:
            resNode = ListNode(-heapq.heappop(heap), prev)

            prev = resNode
        
        return prev
            
