class Solution {
    public boolean isPalindrome(String s) {
        //check for letter or digit 
        //char.isLetterOrDigit(c); 
        //isalphanum();

        int l = 0;
        int r = s.length( ) -1;

        while(l < r){
            //check for white space 
            while(l < r && !Character.isLetterOrDigit(s.charAt(l)) ){
                l++;
            }

            while(l < r && !Character.isLetterOrDigit(s.charAt(r))){
                r--;
            }
            if(s.toLowerCase().charAt(l) != s.toLowerCase().charAt(r)) return false;

            l++;
            r--;
        }

        return true;
    }
}
