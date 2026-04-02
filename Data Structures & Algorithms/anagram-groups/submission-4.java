class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        //sort them
        //sorted, string
        //loop through the keyset and add to list with map[key]

        List<List<String>> list = new ArrayList<>();

        Map<String,List<String>> map = new HashMap<>();

        for(String word : strs){
            //sort string
            int[] freq = new int[26];
            for(char c : word.toCharArray() ){
                freq[c-'a']++;
            }

            String sortedWord = Arrays.toString(freq);

            if(!map.containsKey(sortedWord)){
                map.put(sortedWord, new ArrayList<String>());
            }
            map.get(sortedWord).add(word);
            

        }

        for(String key : map.keySet()){
            list.add(map.get(key));
        }

        return list;
    }
}
