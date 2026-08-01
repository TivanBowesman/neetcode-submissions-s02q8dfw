class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        map = {}

        for s in strs:
            sortWord = "".join(sorted(s))
            print(sortWord)
            if sortWord not in map.keys():
                map[sortWord] = [s]
            else:
                map[sortWord].append(s)

        return list(map.values())