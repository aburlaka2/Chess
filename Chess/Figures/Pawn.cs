using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Figures
{
    class Pawn:Figure
    {
        public Pawn(int figurecolor, char figurechar, int posx, int posy)
        {
            FigureColor = figurecolor;
            FigureChar = figurechar;
            posX = posx;
            posY = posy;
        }
        public override void Move(Cell[,] Field, int EnterNewPosX, int EnterNewPosY, int posx, int posy)
        {
            if (this.FigureColor == 1)
            {
                if (posY == 6)
                {
                    if (EnterNewPosY == posY - 2 && EnterNewPosX==posX)
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
                    else if (EnterNewPosY == posY - 1 && EnterNewPosX == posX)
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
                    else if (EnterNewPosY == posY - 1&&EnterNewPosX==posX+1|| EnterNewPosY == posY - 1 && EnterNewPosX == posX - 1)
                    {
                        if (!Field[EnterNewPosX, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY)&& Field[EnterNewPosX, EnterNewPosY].CellFigureColor == 0)
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
                        Console.WriteLine("Pawn can`t move this way");
                    }
                }
                else if (EnterNewPosY == posY - 1 && EnterNewPosX == posX)
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
                else if (EnterNewPosY == posY - 1 && EnterNewPosX == posX + 1 || EnterNewPosY == posY - 1 && EnterNewPosX == posX - 1)
                {
                    if (!Field[EnterNewPosX, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY) && Field[EnterNewPosX, EnterNewPosY].CellFigureColor == 0)
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
                    Console.WriteLine("Pawn can`t move this way");
                }

            }
            else
            {
                if (posY == 1)
                {
                    if (EnterNewPosY == posY + 2 && EnterNewPosX == posX)
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
                    else if (EnterNewPosY == posY + 1 && EnterNewPosX == posX)
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
                    else if (EnterNewPosY == posY + 1 && EnterNewPosX == posX + 1 || EnterNewPosY == posY + 1 && EnterNewPosX == posX - 1)
                    {
                        if (!Field[EnterNewPosX, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY) && Field[EnterNewPosX, EnterNewPosY].CellFigureColor == 1)
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
                        Console.WriteLine("Pawn can`t move this way");
                    }
                }
                else if (EnterNewPosY == posY + 1 && EnterNewPosX == posX)
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
                else if (EnterNewPosY == posY + 1 && EnterNewPosX == posX + 1 || EnterNewPosY == posY + 1 && EnterNewPosX == posX - 1)
                {
                    if (!Field[EnterNewPosX, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY) && Field[EnterNewPosX, EnterNewPosY].CellFigureColor == 1)
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
                    Console.WriteLine("Pawn can`t move this way");
                }
            }
        }
    }
}
