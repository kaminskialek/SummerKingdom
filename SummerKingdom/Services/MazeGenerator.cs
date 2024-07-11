namespace Services
{
    public class MazeGenerator
    {
        public string[][] maze;
        public static Random randomizer = new Random();

        //Constructor adds borders and gaps based on size
        //The dimensions of the maze are a result of the ASCII symbols used.
        public MazeGenerator(int size)
        {
            this.maze = new string[size * 2 + 1][];
            for (int i = 0; i < maze.Length; i++)
            {
                maze[i] = new string[size + 1];
                for (int j = 0; j < size + 1; j++)
                {
                    //draws top and bottom border
                    if (i == 0 || i == maze.Length - 1)
                    {
                        maze[i][j] = "---+";
                        if (j == 0)
                        {
                            maze[i][j] = "   +";
                        }
                    }
                    //adds space for walls
                    else if (j != 0 && j != size)
                    {
                        maze[i][j] = "    ";
                    }
                    //draws left and right border
                    else if (i % 2 == 0)
                    {
                        maze[i][j] = "   +";
                    }
                    else
                    {
                        maze[i][j] = "   |";
                    }
                }
            }

        }

        public void DivideHorizontally(int row, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                maze[row][i] = "---+";
            }
            int gap = randomizer.Next(start, end + 1);
            maze[row][gap] = "   +";

        }

        public void DivideVertically(int column, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    maze[i][column] = "   +";
                }
                else
                {
                    maze[i][column] = "   |";
                }

            }
            int gap = randomizer.Next(start, end + 1);
            if (gap % 2 == 0)
            {
                gap++;
            }
            maze[gap][column] = "    ";
        }


        public void GenerateMaze(int topRow, int bottomRow, int leftColumn, int rightColumn, int direction)
        {
            //Checks if there is enough space to divide (bottom of recursion)
            if (bottomRow - topRow > 0 && rightColumn - leftColumn > 0)
            {
                //Picks a either horizontal (0) or vertical (1) direction based on which side of the rectangle area is longer
                if (bottomRow - topRow > rightColumn - leftColumn)
                {
                    direction = 0;
                }
                if (rightColumn - leftColumn > bottomRow - topRow)
                {
                    direction = 1;
                }

                //Divides horizontally
                if (direction == 0)
                {

                    int row = randomizer.Next(topRow, bottomRow);
                    if (row % 2 != 0)
                    {
                        row = row + 1;
                    }
                    DivideHorizontally(row, leftColumn, rightColumn);
                    GenerateMaze(topRow, row - 1, leftColumn, rightColumn, randomizer.Next(2));
                    GenerateMaze(row + 1, bottomRow, leftColumn, rightColumn, randomizer.Next(2));
                }
                //Divides vertically
                else
                {
                    int column = randomizer.Next(leftColumn, rightColumn);
                    DivideVertically(column, topRow, bottomRow);
                    GenerateMaze(topRow, bottomRow, leftColumn, column, randomizer.Next(2));
                    GenerateMaze(topRow, bottomRow, column + 1, rightColumn, randomizer.Next(2));
                }
            }
            else
            {
                return;
            }

        }
    }
}
