using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Cell
    {
        public int CellBackground { get; set; }
        public Figure CellFigure { get; set; }
        public int CellFigureColor { get; set; }
        public char CellChar;
        public Cell()
        {
            CellBackground = 1;
            //CellFigure = null;
            CellChar = ' ';
        }
        public void CellColor()
        {
            if (CellBackground == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("   ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("   ");
            }
        }
        public void SetCellFigure()
        {
            if (CellFigure != null)
            {
                CellChar = CellFigure.FigureChar;
            }
            if (CellBackground == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                if (CellFigureColor == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + CellChar + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + CellChar + " ");
                }

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                if (CellFigureColor == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + CellChar + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + CellChar + " ");
                }

            }

        }
        public bool IsCellEmpty(Cell[,]Field, int EnterNewPosX, int EnterNewPosY)
        {
            bool free = false;
            if (Field[EnterNewPosX, EnterNewPosY].CellFigure == null)
            {
                free = true;
            }
 
            return free;
        }
        public void Reset()
        {
            this.CellFigure = null;
        }

    }
}
