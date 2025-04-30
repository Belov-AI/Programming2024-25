using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public struct Direction
    {
        public int ColumnOffset;
        public int RowOffset;

        public Direction(int columnOffset, int rowOffset)
        {
            ColumnOffset = columnOffset;
            RowOffset = rowOffset;
        }
    }
}
