// You start at the cell (rStart, cStart) of an rows x cols grid facing east. The northwest corner is at the first row and column in the grid, and the southeast corner is at the last row and column.

// You will walk in a clockwise spiral shape to visit every position in this grid. Whenever you move outside the grid's boundary, we continue our walk outside the grid (but may return to the grid boundary later.). Eventually, we reach all rows * cols spaces of the grid.

// Return an array of coordinates representing the positions of the grid in the order you visited them.
public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
    List<(int row, int col)> steps = new();
    int direction =0;
    int row =rStart;
    int col = cStart;
    steps.Add((row,col));
    int n = 2;
    int temp =0;
    while(steps.Count()<rows*cols){
        switch(direction%4){
            case 0: 
            temp = col;
            col+=n/2;
            while(temp<col){
                    temp++;
                    if(row>=0 && row<rows && temp>=0 && temp<cols) steps.Add((row,temp));
                }
                break;
            case 1:
            temp = row;
            row+=n/2;
            while(temp<row){
                    temp++;
                    if(temp>=0 && temp<rows && col>=0 && col<cols) steps.Add((temp,col));
                }
                break;
            case 2:
            temp = col; 
            col-=n/2;
            while(temp>col){
                    temp--;
                    if(row>=0 && row<rows && temp>=0 && temp<cols) steps.Add((row,temp));
                }
                break;
            case 3:
            temp = row;
            row-=n/2;
            while(temp>row){
                    temp--;
                    if(temp>=0 && temp<rows && col>=0 && col<cols) steps.Add((temp,col));
                }
                break;
        }
        direction++;
        n++;
    }

    return steps.Select(t => new int[] { t.row, t.col }).ToArray();
}