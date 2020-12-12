using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Figures
{
    class Knight:Figure
    {
        public Knight(int figurecolor, char figurechar, int posx, int posy)
        {
            FigureColor = figurecolor;
            FigureChar = figurechar;
            posX = posx;
            posY = posy;
        }
        public override void Move(Cell[,] Field, int EnterNewPosX, int EnterNewPosY, int posx, int posy)
        {
            if (Math.Abs(EnterNewPosX - posx)+Math.Abs(EnterNewPosY - posy)==3|| Math.Abs(EnterNewPosX - posx)!=0|| Math.Abs(EnterNewPosX - posx) != 0)
            {
                if (Field[EnterNewPosX, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY))
                {
                    Field[posX, posY].Reset();
                    this.posX = EnterNewPosX;
                    this.posY = EnterNewPosY;
                    this.SetToCell(Field, posX, posY);
                }
                else
                {
                    Console.WriteLine("Way is not free!");
                }
            }
            else
            {
                Console.WriteLine("King can`t this way");
            }
        }
    }
}
