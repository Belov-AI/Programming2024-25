using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maze
{
    public class Maze
    {
        public Cell[,] Board { get; private set; }

        public int Height => Board.GetLength(0);

        public int Width => Board.GetLength(1);

        const int DEFAULT_SIZE = 25;
        const int MIN_SIZE = 5;
        const int MAX_SIZE = 79;
        const int ATTEMPT_NUMBER = 10;

        static Direction[] direction = new Direction[]
            {
                new Direction(-1, 0),
                new Direction(0, 1),
                new Direction(1, 0),
                new Direction(0, -1),
            };

        public Maze(int width, int height)
        {
            if (width < MIN_SIZE || width > MAX_SIZE)
                width = DEFAULT_SIZE;

            if (width % 2 == 0)
                width++;

            if(height <  MIN_SIZE || height > MAX_SIZE)
                height = DEFAULT_SIZE;

            if(height % 2 == 0)
                height++;

            Board = new Cell[height, width];

            for(var i = 0; i < Height;  i++)
                for(var j = 0; j < Width; j++)
                    Board[i, j] = new Cell { Row = i, Column = j, Wall = true};

            var moves = new Stack<Cell>();
            var rnd = new Random();

            var current = Board[rnd.Next((Height - 1) / 2) * 2 + 1,
                rnd.Next((Width - 1) / 2) * 2 + 1];

            current.Wall = false;

            moves.Push(current);

            while(moves.Count > 0)
            {
                var deadend = true;

                for (var attempt = 0; attempt < ATTEMPT_NUMBER; attempt++)
                {
                    var dir = direction[direction.Length];

                    if(CanMove(current, dir))
                    {
                        for(var i = 0; i<2; i++)
                        {
                            var newRaw = current.Row + dir.RowOffset;
                            var newColumn = current.Column + dir.ColumnOffset;
                            current = Board[newRaw, newColumn];
                            current.Wall = false;
                        }

                        deadend = false;
                        moves.Push(current);
                        break;
                    }

                    if (deadend)
                        current = moves.Pop();
                }
            }
        }

        public bool CanMove(Cell cell, Direction direction)
        {
            int newRow = cell.Row + direction.RowOffset * 2;
            int newColumn = cell.Column + direction.ColumnOffset * 2;

            if(newRow < 0 || newRow >= Height || newColumn < 0 || newColumn >= Width)
                return false;

            return Board[newRow, newColumn].Wall;
        }
    }
}
