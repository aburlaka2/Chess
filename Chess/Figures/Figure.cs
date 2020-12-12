using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Figure
    {
        public int FigureColor;
        public char FigureChar;
        public int posX;
        public int posY;

        public Figure SetToCell(Cell[,] Field, int posX, int posY)
        {
            return Field[posX, posY].CellFigure = this;
        }
        public int SetFigureColor(Cell[,] Field, int posX, int posY)
        {
            return Field[posX, posY].CellFigureColor = FigureColor;
        }
        public abstract void Move(Cell[,] Field, int EnterNewPosX, int EnterNewPosY, int posx, int posy);

    }

}
