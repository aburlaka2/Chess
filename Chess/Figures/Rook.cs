using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Figures
{
    class Rook:Figure
    {
        public Rook(int figurecolor, char figurechar, int posx, int posy)
        {
            FigureColor = figurecolor;
            FigureChar = figurechar;
            posX = posx;
            posY = posy;
        }
        public override void Move(Cell[,] Field, int EnterNewPosX, int EnterNewPosY, int posx, int posy)
        {
            if (Math.Abs(EnterNewPosX - posx) == 0 || Math.Abs(EnterNewPosY - posy) == 0)
            {
                bool wayfree = false;
                if (EnterNewPosX - posx == 0 && EnterNewPosY - posy < 0)
                {
                    for (int i = 0; i <= EnterNewPosY - posy; i++)
                    {
                        if (Field[EnterNewPosX, EnterNewPosY - i].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY))
                        {
                            wayfree = true;
                            continue;
                        }
                        else
                        {
                            wayfree = false;
                            Console.WriteLine("The way is not clear");
                            break;
                        }
                    }
                }
                if (EnterNewPosX - posx == 0 && EnterNewPosY - posy > 0)
                {
                    for (int i = 0; i <= EnterNewPosY - posy; i++)
                    {
                        if (Field[EnterNewPosX, EnterNewPosY + i].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY))
                        {
                            wayfree = true;
                            continue;
                        }
                        else
                        {
                            wayfree = false;
                            Console.WriteLine("The way is not clear");
                            break;
                        }
                    }
                }
                if (EnterNewPosX - posx < 0 && EnterNewPosY - posy == 0)
                {
                    for (int i = 0; i <= EnterNewPosX - posx; i++)
                    {
                        if (Field[EnterNewPosX - i, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY))
                        {
                            wayfree = true;
                            continue;
                        }
                        else
                        {
                            wayfree = false;
                            Console.WriteLine("The way is not clear");
                            break;
                        }
                    }
                }
                if (EnterNewPosX - posx > 0 && EnterNewPosY - posy == 0)
                {
                    for (int i = 0; i <= EnterNewPosX - posx; i++)
                    {
                        if (Field[EnterNewPosX + i, EnterNewPosY].IsCellEmpty(Field, EnterNewPosX, EnterNewPosY))
                        {
                            wayfree = true;
                            continue;
                        }
                        else
                        {
                            wayfree = false;
                            Console.WriteLine("The way is not clear");
                            break;
                        }
                    }
                }
                if (wayfree)
                {
                    Field[posX, posY].Reset();
                    this.posX = EnterNewPosX;
                    this.posY = EnterNewPosY;
                    this.SetToCell(Field, posX, posY);
                }
            }
            else
            {
                Console.WriteLine("Rook can`t move this way");
            }
        }

    }
}
