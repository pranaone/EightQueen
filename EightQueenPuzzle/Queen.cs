using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueenPuzzle
{
    public class Queen
    {
        private int row;
        private int column;

        public Queen()
        {
            row = 0;
            column = 0;
        }

        public Queen(byte Row, byte Column)
        {
            row = Row;
            column = Column;
        }

        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }
    }
}
