public class NumMatrix {

    private int[][] prefix;

    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        prefix = new int[rows+1][];

        for(int i =0; i <= rows; i++){
            prefix[i] = new int[cols+1];
        }

        //prefix sum matrix
        for(int i=1; i<=rows; i++){
            for(int j=1; j <= cols; j++){
                prefix[i][j] = matrix[i-1][j-1]
                                + prefix[i-1][j] + prefix[i][j-1] - prefix[i-1][j-1];
            }
        }

    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return prefix[row2+1][col2 + 1] - prefix[row1][col2+1] - prefix[row2+1][col1] + prefix[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */