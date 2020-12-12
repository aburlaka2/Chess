using System;
using Chess.Figures;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Cell[,] Field = new Cell[8, 8];
            GenerateField(Field);
            StartPlacement(Field);
            RenderField(Field);
            bool mat = false;
            while (!mat)
            {
                bool figure = false;
                int EnterStartPosY = 0;
                int EnterStartPosX = 0;
                while (!figure)
                {
                    Console.WriteLine("Enter figure you want to move position(for example 'a1'");
                    string StartPosition = Console.ReadLine();
                    if (StartPosition.Length == 2)
                    {
                        char vertical = StartPosition[0];
                        char horizontal = StartPosition[1];
                        //Console.Write(horizontal);
                        switch (vertical)
                        {
                            case 'a':
                                EnterStartPosY = 0;
                                figure = true;
                                break;
                            case 'b':
                                EnterStartPosY = 1;
                                figure = true;
                                break;
                            case 'c':
                                EnterStartPosY = 2;
                                figure = true;
                                break;
                            case 'd':
                                EnterStartPosY = 3;
                                figure = true;
                                break;
                            case 'e':
                                EnterStartPosY = 4;
                                figure = true;
                                break;
                            case 'f':
                                EnterStartPosY = 5;
                                figure = true;
                                break;
                            case 'g':
                                EnterStartPosY = 6;
                                figure = true;
                                break;
                            case 'h':
                                EnterStartPosY = 7;
                                figure = true;
                                break;
                            default:
                                Console.WriteLine("Vertical is not valid!");
                                figure = false;
                                break;

                        }

                        switch (horizontal)
                        {
                            case '1':
                                EnterStartPosX = 7;
                                figure = true;
                                continue;
                            case '2':
                                EnterStartPosX = 6;
                                figure = true;
                                continue;
                            case '3':
                                EnterStartPosX = 5;
                                figure = true;
                                continue;
                            case '4':
                                EnterStartPosX = 4;
                                figure = true;
                                continue;
                            case '5':
                                EnterStartPosX = 3;
                                figure = true;
                                continue;
                            case '6':
                                EnterStartPosX = 2;
                                figure = true;
                                continue;
                            case '7':
                                EnterStartPosX = 1;
                                figure = true;
                                continue;
                            case '8':
                                EnterStartPosX = 0;
                                figure = true;
                                continue;
                            default:
                                Console.WriteLine("Horizontal is not valid!");
                                figure = false;
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input is not on field");
                    }
                }

                Console.WriteLine(EnterStartPosX);
                Console.WriteLine(EnterStartPosY);
                if (Field[EnterStartPosX, EnterStartPosY].CellFigure != null)
                {
                    bool newcell = false;
                    int EnterNewPosY = 0;
                    int EnterNewPosX = 0;
                    while (!newcell)
                    {
                        Console.WriteLine("Enter cell you want to move your figure (for example 'a1'");
                        string NewPosition = Console.ReadLine();
                        if (NewPosition.Length == 2)
                        {
                            char vertical = NewPosition[0];
                            switch (vertical)
                            {
                                case 'a':
                                    EnterNewPosY = 0;
                                    newcell = true;
                                    continue;
                                case 'b':
                                    EnterNewPosY = 1;
                                    newcell = true;
                                    continue;
                                case 'c':
                                    EnterNewPosY = 2;
                                    newcell = true;
                                    continue;
                                case 'd':
                                    EnterNewPosY = 3;
                                    newcell = true;
                                    continue;
                                case 'e':
                                    EnterNewPosY = 4;
                                    newcell = true;
                                    continue;
                                case 'f':
                                    EnterNewPosY = 5;
                                    newcell = true;
                                    continue;
                                case 'g':
                                    EnterNewPosY = 6;
                                    newcell = true;
                                    break;
                                case 'h':
                                    EnterNewPosY = 7;
                                    newcell = true;
                                    break;
                                default:
                                    Console.WriteLine("Vertical is not valid!");
                                    newcell = false;
                                    break;

                            }
                            char horizontal = NewPosition[1];
                            switch (horizontal)
                            {
                                case '1':
                                    EnterNewPosX = 7;
                                    newcell = true;
                                    break;
                                case '2':
                                    EnterNewPosX = 6;
                                    newcell = true;
                                    break;
                                case '3':
                                    EnterNewPosX = 5;
                                    newcell = true;
                                    break;
                                case '4':
                                    EnterNewPosX = 4;
                                    figure = true;
                                    break;
                                case '5':
                                    EnterNewPosX = 3;
                                    newcell = true;
                                    break;
                                case '6':
                                    EnterNewPosX = 2;
                                    newcell = true;
                                    break;
                                case '7':
                                    EnterNewPosX = 1;
                                    newcell = true;
                                    break;
                                case '8':
                                    EnterNewPosX = 0;
                                    newcell = true;
                                    break;
                                default:
                                    Console.WriteLine("Horizontal is not valid!");
                                    newcell = false;
                                    return;
                            }
                        }
                       
                    }
                    Field[EnterNewPosX, EnterNewPosY].CellFigure.Move(Field, EnterNewPosX, EnterNewPosY, EnterStartPosX, EnterStartPosY);
                }
                else
                {
                    Console.WriteLine("There are no figure!");
                }
            }
        }
        static void GenerateField(Cell[,]Field)
        {
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(0); j++)
                {
                    Field[i, j] = new Cell();
                    Field[i, j].CellBackground = (i + j) % 2 == 0 ? 1 : 0;
                }
            }
        }
        static void RenderField(Cell[,] Field)
        {
            Console.WriteLine("  A  B  C  D  E  F  G  H ");
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(' ');
                for (int j = 0; j < Field.GetLength(0); j++)
                {
                    Field[i, j].CellColor();
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(' ');
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(8-i);
                for (int j = 0; j < Field.GetLength(0); j++)
                {
                    Field[i, j].SetCellFigure();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(8-i);
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(' ');
                for (int j = 0; j < Field.GetLength(0); j++)
                {
                    Field[i, j].CellColor();
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(' ');
                Console.WriteLine("");
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H ");
        }
        static void StartPlacement(Cell[,] Field)
        {
            King WhiteKing = new King(1,'K', 7, 4 );
            WhiteKing.SetToCell(Field, 7, 4);
            WhiteKing.SetFigureColor(Field, 7, 4);
            King BlackKing = new King(0,'K', 0, 4);
            BlackKing.SetToCell(Field, 0, 4);
            BlackKing.SetFigureColor(Field, 0, 4);
            Quinn WhiteQuinn = new Quinn(1,'Q', 7, 3);
            WhiteQuinn.SetToCell(Field, 7, 3);
            WhiteQuinn.SetFigureColor(Field, 7, 3);
            Quinn BlackQuinn = new Quinn(0,'Q', 0, 3);
            BlackQuinn.SetToCell(Field, 0, 3);
            BlackQuinn.SetFigureColor(Field, 0, 3);
            Bishop WhiteBishop1 = new Bishop(1,'B', 7, 2);
            WhiteBishop1.SetToCell(Field, 7, 2);
            WhiteBishop1.SetFigureColor(Field, 7, 2);
            Bishop WhiteBishop2 = new Bishop(1,'B', 7, 5);
            WhiteBishop2.SetToCell(Field, 7, 5);
            WhiteBishop2.SetFigureColor(Field, 7, 5);
            Bishop BlackBishop1 = new Bishop(0,'B', 0, 2);
            BlackBishop1.SetToCell(Field, 0, 2);
            BlackBishop1.SetFigureColor(Field, 0, 2);
            Bishop BlackBishop2 = new Bishop(0,'B', 0, 5);
            BlackBishop2.SetToCell(Field, 0, 5);
            BlackBishop2.SetFigureColor(Field, 0, 5);
            Knight WhiteKnight1 = new Knight(1,'k', 7, 1);
            WhiteKnight1.SetToCell(Field, 7, 1);
            WhiteKnight1.SetFigureColor(Field, 7, 1);
            Knight WhiteKnight2 = new Knight(1,'k', 7, 6);
            WhiteKnight2.SetToCell(Field, 7, 6);
            WhiteKnight2.SetFigureColor(Field, 7, 6);
            Knight BlackKnight1 = new Knight(0,'k', 0, 1);
            BlackKnight1.SetToCell(Field, 0, 1);
            BlackKnight1.SetFigureColor(Field, 0, 1);
            Knight BlackKnight2 = new Knight(0,'k', 0, 6);
            BlackKnight2.SetToCell(Field, 0, 6);
            BlackKnight2.SetFigureColor(Field, 0, 6);
            Rook WhiteRook1 = new Rook(1,'R', 7, 0);
            WhiteRook1.SetToCell(Field, 7, 0);
            WhiteRook1.SetFigureColor(Field, 7, 0);
            Rook WhiteRook2 = new Rook(1,'R', 7, 7);
            WhiteRook2.SetToCell(Field, 7, 7);
            WhiteRook2.SetFigureColor(Field, 7, 7);
            Rook BlackRook1 = new Rook(0,'R', 0, 0);
            BlackRook1.SetToCell(Field, 0, 0);
            BlackRook1.SetFigureColor(Field, 0, 0);
            Rook BlackRook2 = new Rook(0,'R', 0, 7);
            BlackRook2.SetToCell(Field, 0, 7);
            BlackRook2.SetFigureColor(Field, 0, 7);
            Pawn WhitePawn1 = new Pawn(1,'i', 6, 0);
            WhitePawn1.SetToCell(Field, 6, 0);
            WhitePawn1.SetFigureColor(Field, 6, 0);
            Pawn WhitePawn2 = new Pawn(1,'i', 6, 1);
            WhitePawn2.SetToCell(Field, 6, 1);
            WhitePawn2.SetFigureColor(Field, 6, 1);
            Pawn WhitePawn3 = new Pawn(1,'i', 6, 2);
            WhitePawn3.SetToCell(Field, 6, 2);
            WhitePawn3.SetFigureColor(Field, 6, 2);
            Pawn WhitePawn4 = new Pawn(1,'i', 6, 3);
            WhitePawn4.SetToCell(Field, 6, 3);
            WhitePawn4.SetFigureColor(Field, 6, 3);
            Pawn WhitePawn5 = new Pawn(1,'i', 6, 4);
            WhitePawn5.SetToCell(Field, 6, 4);
            WhitePawn5.SetFigureColor(Field, 6, 4);
            Pawn WhitePawn6 = new Pawn(1,'i', 6, 5);
            WhitePawn6.SetToCell(Field, 6, 5);
            WhitePawn6.SetFigureColor(Field, 6, 5);
            Pawn WhitePawn7 = new Pawn(1,'i', 6, 6);
            WhitePawn7.SetToCell(Field, 6, 6);
            WhitePawn7.SetFigureColor(Field, 6, 6);
            Pawn WhitePawn8 = new Pawn(1,'i', 6, 7);
            WhitePawn8.SetToCell(Field, 6, 7);
            WhitePawn8.SetFigureColor(Field, 6, 7);
            Pawn BlackPawn1 = new Pawn(0,'i', 1, 0);
            BlackPawn1.SetToCell(Field, 1, 0);
            BlackPawn1.SetFigureColor(Field, 1, 0);
            Pawn BlackPawn2 = new Pawn(0,'i', 1, 1);
            BlackPawn2.SetToCell(Field, 1, 1);
            Pawn BlackPawn3 = new Pawn(0,'i', 1, 2);
            BlackPawn3.SetToCell(Field, 1, 2);
            Pawn BlackPawn4 = new Pawn(0,'i', 1, 3);
            BlackPawn4.SetToCell(Field, 1, 3);
            Pawn BlackPawn5 = new Pawn(0,'i', 1, 4);
            BlackPawn5.SetToCell(Field, 1, 4);
            Pawn BlackPawn6 = new Pawn(0,'i', 1, 5);
            BlackPawn6.SetToCell(Field, 1, 5);
            Pawn BlackPawn7 = new Pawn(0,'i', 1, 6);
            BlackPawn7.SetToCell(Field, 1, 6);
            Pawn BlackPawn8 = new Pawn(0,'i', 1, 7);
            BlackPawn8.SetToCell(Field, 1, 7);

        }
    }
}
