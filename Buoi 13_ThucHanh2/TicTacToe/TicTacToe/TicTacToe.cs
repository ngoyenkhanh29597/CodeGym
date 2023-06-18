using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
		//Khoi tao
        public TicTacToe(){
            play();
        }
        
        //Luot choi
        public void play() {
            int moveCounter = 0;
            Board gameBoard = new Board();
            
            Player playerX = new Player('X');
            
            Player currentPlayer = playerX;

            Console.WriteLine("0. Player vs Player: ");
            Console.WriteLine("1. Player vs Computer ");
            Console.Write("Game Mode: ");
            int mode = int.Parse(Console.ReadLine());

            if (mode == 0)
            {
                Player playerO = new Player('O');
                bool play = true;
                while (play)
                {
                    gameBoard.printBoard();
                    Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                    try
                    {
                        gameBoard.putMark(currentPlayer, playerX.takeTurn());
                        gameBoard.clearBoard();
                        moveCounter++;

                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                            gameBoard.printBoard();
                            play = false;
                        }
                        else if (checkDraw(moveCounter))
                        {
                            Console.WriteLine("DRAW");
                            gameBoard.printBoard();
                            play = false;
                        }
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            else if (mode == 1)
            {
                Robot playerO = new Robot('O');
                int turnX, turnO;
                bool play = true;
                while (play)
                {
                    gameBoard.printBoard();
                    

                    try
                    {

                        if (currentPlayer == playerX)
                        {
                            Console.WriteLine("Player {0} enter the field in which you want to put the character: ", currentPlayer.getSign());
                            turnX = playerX.takeTurn();
                            gameBoard.putMark(currentPlayer, turnX);
                            playerO.removeCell(turnX);
                        }
                        else 
                        {
                            Console.Write("Player {0} enter the field: ",currentPlayer.getSign());
                            turnO = playerO.takeTurn();
                            gameBoard.putMark(currentPlayer, turnO);
                            playerO.removeCell(turnO);
                            Console.WriteLine(turnO);
                            Thread.Sleep(5000);
                        }

                        gameBoard.clearBoard();
                        moveCounter++;

                        if (currentPlayer.checkWin(gameBoard))
                        {
                            Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                            gameBoard.printBoard();
                            play = false;
                        }
                        else if (checkDraw(moveCounter))
                        {
                            Console.WriteLine("DRAW");
                            gameBoard.printBoard();
                            play = false;
                        }
                        currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                      
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
           
        }
      
        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }

    }

}

