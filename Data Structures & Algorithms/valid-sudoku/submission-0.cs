public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //check row by row
        //keep track of the colums

        //validate rows
        for(int i = 0; i < 9; i++){
            var hashset = new HashSet<char>();
            for (int j = 0; j < 9; j++){
                char item = board[i][j];
                //dupe found
                if (hashset.Contains(item)){
                    return false;
                }else if (!item.Equals('.')){
                    hashset.Add(item);
                }
            }
        }
        //validate colums
        for(int i = 0; i < 9; i++){
            var hashset = new HashSet<char>();
            for (int j = 0; j < 9;j++){
                char item = board[j][i];
                //dupe found
                if (hashset.Contains(item)){
                    return false;
                }else if (!item.Equals('.')){
                    hashset.Add(item);
                }
            }
        }

        //validate boxes
        //starting positions of the box
        var starts = new List<(int i, int j)>
        {
            (0, 0),
            (0, 3), (0, 6),
            (3, 0), (3, 3), (3, 6),
            (6, 0), (6, 3), (6, 6)
        };

        foreach( var (i,j) in starts){
            var hashset = new HashSet<char>();
            for(int row = i; row < i + 3; row++){

                for(int col = j; col < j + 3; col++){

                    char item = board[row][col];
                    
                    if(hashset.Contains(item)){
                        return false;
                    }else if(!item.Equals('.')){
                        hashset.Add(item );
                    }
                }
            }
        }

        return true; 
    }
}
