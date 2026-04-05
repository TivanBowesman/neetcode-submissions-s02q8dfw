class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        # Remember Mod and divide

        m = len(matrix)
        n = len(matrix[0])

        l = 0
        r = (m * n) - 1
        
        while l <= r:
            mid = l + (r - l ) // 2 
            i = int(mid / n)
            j = int(mid % n)

            if matrix[i][j] == target:
                return True
            elif matrix[i][j] > target:
                r = mid - 1
            else:
                l = mid + 1

        return False