// You start at the cell (rStart, cStart) of an rows x cols grid facing east. The northwest corner is at the first row and column in the grid, and the southeast corner is at the last row and column.

// You will walk in a clockwise spiral shape to visit every position in this grid. Whenever you move outside the grid's boundary, we continue our walk outside the grid (but may return to the grid boundary later.). Eventually, we reach all rows * cols spaces of the grid.

// Return an array of coordinates representing the positions of the grid in the order you visited them.
public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
        List<(int row, int col)> steps = new();
        int leftBorder = cStart;
        int rightBorder = cStart;
        int topBorder = rStart;
        int bottomBorder = rStart;
        (int row, int col) current = new(rStart,cStart);
        steps.Add(current);

        while(steps.Count()<rows*cols){
            Right();
                if(Check()) break;
            Down();
                if(Check()) break;
            Left();
                if(Check()) break;
            Up();
        }
        bool Check()=>steps.Count()>=rows*cols;
        void Right(){
            if(current.col < cols-1 && current.row>=0){
                current.col = rightBorder++;
                steps.Add(current);
            } else current.col = ++rightBorder;
            if(rightBorder>=cols) rightBorder=cols-1;
        }
        void Down(){
            if(current.row < rows-1 && current.col<cols-1){
                current.row = bottomBorder++;
                steps.Add(current);
            } else current.row = ++bottomBorder;
            if(bottomBorder>=rows) bottomBorder=rows-1;
        }
        void Left(){
            if(current.col>0 && current.row<rows-1){
                current.col = leftBorder--;
                steps.Add(current);
            }else current.col = --leftBorder;
            if(leftBorder<0) leftBorder=0;
        }
        void Up(){
            if(current.row>0 && current.col>=0){
                current.row = topBorder--;
                steps.Add(current);
            }else current.row = --topBorder;
            if(topBorder<0) topBorder=0;
        }
        return steps.Select(t => new int[] { t.row, t.col }).ToArray();
}