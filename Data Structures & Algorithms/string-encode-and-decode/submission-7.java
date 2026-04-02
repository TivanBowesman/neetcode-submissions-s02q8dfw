class Solution {

    public String encode(List<String> strs) {
        StringBuilder encoded = new StringBuilder();
        for (String s : strs) {
            encoded.append(s.length())
                   .append('#')
                   .append(s);
        }
        return encoded.toString();
    }

    public List<String> decode(String str) {
        List<String> res = new ArrayList<>();
        int i = 0;

        while (i < str.length()) {
            // read length
            int j = i;
            while (str.charAt(j) != '#') j++;
            int len = Integer.parseInt(str.substring(i, j));

            // read string of that length
            j++; // move past '#'
            res.add(str.substring(j, j + len));

            i = j + len; // move to next block
        }

        return res;
    }
}

