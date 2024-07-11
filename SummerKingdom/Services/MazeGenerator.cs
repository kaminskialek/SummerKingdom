namespace Services
{
    public class MazeGenerator
    {
        public string[][] Maze;
        public static Random Randomizer = new Random();

        //Constructor adds borders and gaps based on size
        //The dimensions of the maze are a result of the ASCII symbols used.
        public MazeGenerator(int size)
        {
            this.Maze = new string[size * 2 + 1][];
            for (int i = 0; i < Maze.Length; i++)
            {
                Maze[i] = new string[size + 1];
                for (int j = 0; j < size + 1; j++)
                {
                    if (i == 0 || i == Maze.Length - 1)
                    {
                        Maze[i][j] = "---+";
                        if (j == 0)
                        {
                            Maze[i][j] = "   +";
                        }
                    }
                    else if (j != 0 && j != size)
                    {
                        Maze[i][j] = "    ";
                    }
                    else if (i % 2 == 0)
                    {
                        Maze[i][j] = "   +";
                    }
                    else
                    {
                        Maze[i][j] = "   |";
                    }
                }
            }

        }

        public void DivideHorizontally(int row, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Maze[row][i] = "---+";
            }
            int gap = Randomizer.Next(start, end + 1);
            Maze[row][gap] = "   +";

        }

        public void DivideVertically(int column, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Maze[i][column] = "   +";
                }
                else
                {
                    Maze[i][column] = "   |";
                }

            }
            int gap = Randomizer.Next(start, end + 1);
            if (gap % 2 == 0)
            {
                gap++;
            }
            Maze[gap][column] = "    ";
        }


        public void GenerateMaze(int TopRow, int BottomRow, int LeftColumn, int RightColumn, int pickDirection)
        {
            //Checks if there is enough space to divide (bottom of recursion)
            if (BottomRow - TopRow > 0 && RightColumn - LeftColumn > 0)
            {
                //Picks a either horizontal (0) or vertical (1) direction based on which side of the rectangle area is longer
                if (BottomRow - TopRow > RightColumn - LeftColumn)
                {
                    pickDirection = 0;
                }
                if (RightColumn - LeftColumn > BottomRow - TopRow)
                {
                    pickDirection = 1;
                }

                //Divides horizontally
                if (pickDirection == 0)
                {

                    int row = Randomizer.Next(TopRow, BottomRow);
                    if (row % 2 != 0)
                    {
                        row = row + 1;
                    }
                    DivideHorizontally(row, LeftColumn, RightColumn);
                    GenerateMaze(TopRow, row - 1, LeftColumn, RightColumn, Randomizer.Next(2));
                    GenerateMaze(row + 1, BottomRow, LeftColumn, RightColumn, Randomizer.Next(2));
                }
                //Divides vertically
                else
                {
                    int column = Randomizer.Next(LeftColumn, RightColumn);
                    DivideVertically(column, TopRow, BottomRow);
                    GenerateMaze(TopRow, BottomRow, LeftColumn, column, Randomizer.Next(2));
                    GenerateMaze(TopRow, BottomRow, column + 1, RightColumn, Randomizer.Next(2));
                }
            }
            else
            {
                return;
            }

        }
    }
}
