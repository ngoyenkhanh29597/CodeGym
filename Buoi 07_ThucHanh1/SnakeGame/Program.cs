using static System.Formats.Asn1.AsnWriter;
using System.Runtime.CompilerServices;

namespace SnakeGame;

class SnakeGamePlay
{
    //Parameter
    //Gameplay area initilization
    const int height = 20;
    const int width = 60;

    //Fruit initilization
    public Random randFruit = new Random(); //Initilize a random variable for making food
    int fruitX, fruitY; //Location of fruit on screen

    //Initilize another kind of food
    public Random randFruitVip = new Random(); 
    int fruitVipX, fruitVipY;
    int fruitVipCount;

    int fruitCounter; //Fruit counter to determine the time game speed is increased

    //Keyboard control initilization
    public ConsoleKeyInfo keypress = new ConsoleKeyInfo(); //Initilize Key variable to control input from keyboard

    //Snake initilization
    int headX, headY; //Location of snake's head on screen
    int[] bodyX = new int[100]; //Array contains location of snake's body (x axis)
    int[] bodyY = new int[100]; //Array contains location of snake's body (y axis)
    int nBody; //Total length of snake body (increasing by 1 whenever snake eat a food)

    int score; //Score variable, increasing whenever snake eat a food


    bool gameOver; //Boolean variable to notice that the game is over
    bool reset; //Boolean variable to notice that the game is reset
    bool isprinted; //Booolean variable to update screen (Motion making)

    string dir, pre_dir; //Direction variable of the snakeimestop

    int timestop = 500;


    //First Display
    void firstDisplay()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue; //Set color of game 
        Console.CursorVisible = false; //Turn off blinking cursor
        Console.WriteLine("===SNAKE GAME===");
        Console.WriteLine("Press any key to play");
        Console.WriteLine("Tips: - Press P key to PAUSE game");
        Console.WriteLine("      - Press R key to RESET game");
        Console.WriteLine("      - Press Q key to QUIT game");

        keypress = Console.ReadKey(true);
        if (keypress.Key == ConsoleKey.Q)
            Environment.Exit(0);
    }

    //Starting game by first setup
    void Setup()
    {
        dir = "RIGHT"; pre_dir = "";    //bước đi đầu tiên qua phải 
        score = 0; nBody = 0; fruitCounter = 0;
        gameOver = reset = isprinted = false;
        headX = 20; // must be <width
        headY = 10; // must be <height
        fruitVipCount = 0;
        randomFruit();
        //randomFruitVip();
    }

    //Fruit appears randomly on gameplay area
    void randomFruit()
    {
        fruitX = randFruit.Next(1, width - 1);
        fruitY = randFruit.Next(1, height - 1);
    }

    void randomFruitVip()
    {
  
         fruitVipX = randFruitVip.Next(1, width - 1);
         fruitVipY = randFruitVip.Next(1, height - 1);
    }

    //Update screen
    void Update()
    {
        while (!gameOver)
        {
            KeyboardInput();
            Logic();
            Render();
            if (reset) break;
            //DUng man hinh 1s
            Thread.Sleep(timestop);
        }
        if (gameOver) Lose();
    }

    //Keyboard control
    void KeyboardInput()
    {
        while (Console.KeyAvailable) //if there's a key is pressed on user's keyboard
        {
            //Press a key randomly
            keypress = Console.ReadKey(true);
            //dir -> pre_dir
            pre_dir = dir;  //luu lai huong di truoc do

            if (keypress.Key == ConsoleKey.Q) Environment.Exit(0); //Exit game when Q is pressed 
            if (keypress.Key == ConsoleKey.P) dir = "STOP"; //Stop game when P is pressed
            if (keypress.Key == ConsoleKey.LeftArrow && dir != "RIGHT") dir = "LEFT"; //snake turns left when left arrow is pressed 
            if (keypress.Key == ConsoleKey.RightArrow && dir != "LEFT") dir = "RIGHT"; //Snake turns right when right arrow is pressed 
            if (keypress.Key == ConsoleKey.UpArrow && dir != "DOWN") dir = "UP"; //Snake goes up when up arrow is pressed
            if (keypress.Key == ConsoleKey.DownArrow && dir != "UP") dir = "DOWN"; //Snake goes down when down arrow is pressed
            //The snake is not allowed to go backward on the current direction
        }
    }

    //Main logic of the whole game
    void Logic()
    {
        //The snake is increased by 1 unit whenever it eats a food, the food become new head of the snake, then the whole old body of the snake shifts 1 unit (inserting a new element into the snake's body array at the position [0])
        int preX = bodyX[0], preY = bodyY[0]; //Save the pre-head of the snake (position 0 of the body)
        int tempX, tempY; //Temporary variable to contain each element of snake body
        if (dir != "STOP") //Only do this when the game is still running
        {
            bodyX[0] = headX; bodyY[0] = headY; //New head is added into the body array, become the [0] element of snake's body array

            for (int i = 1; i < nBody; i++)
            {
                tempX = bodyX[i]; tempY = bodyY[i]; //This is swap algorithm, the next elements from the pre-head is contained in the temporary variable
                bodyX[i] = preX; bodyY[i] = preY; //the pre-head now becomes the [1] element of the body, then [1] becomes [2], [2] becomes [3],...
                preX = tempX; preY = tempY; //The previous element is now contained in the temporary element, then the whole process is continued
            }
        }

        switch (dir) //The head is moving based on direction variable
        {
            case "RIGHT": headX++; break;
            case "LEFT": headX--; break;
            case "DOWN": headY++; break;
            case "UP": headY--; break;
            case "STOP":
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Game pause!");
                        Console.WriteLine("- Press P key to PAUSE game");
                        Console.WriteLine("- Press R key to RESET game");
                        Console.WriteLine("- Press Q key to QUIT game");

                        keypress = Console.ReadKey(true);
                        if (keypress.Key == ConsoleKey.Q)
                            Environment.Exit(0);
                        if (keypress.Key == ConsoleKey.R)
                        {
                            reset = true; break; //Reset game
                        }
                        if (keypress.Key == ConsoleKey.P)
                            break;  //Pause game and continue playing current game
                    }
                    dir = pre_dir; break;
                }
            }
        //If snake is crashed the wall (its head, body position == wall position)
        if (headX <= 0 || headX >= width - 1 ||
            headY <= 0 || headY >= height - 1) gameOver = true;
        else gameOver = false;

        //The snake eats a food when its head position is == fruit position
        if (headX == fruitX && headY == fruitY)
        {
            fruitCounter++; //Increased the fruit counter by 1 every time the snake eats
            score += 1; //Score incnreased by 5 whenever Snake eat a food

            fruitVipCount++;

            
            nBody++;   // Its body increased by 1 unit
            randomFruit();            //Creating a new fruit after it finishes the pre-food
            if (fruitCounter > 0 && fruitCounter % 5 == 0 && timestop > 100) //Every 5 times the snake eat foods, the game speed is increased, the max speed is at 100 ms screen stopping
            {
                timestop -= 100;
            }
            if (fruitVipCount > 0 && fruitVipCount % 5 == 0)
            {
                randomFruitVip();
                if (headX == fruitVipX && headY == fruitVipY)
                {
                    fruitCounter++;
                    score += 2; //Increase score by 2 
                    nBody += 2;
                    //randomFruitVip();
                    if (fruitCounter > 0 && fruitCounter % 5 == 0 && timestop > 100)
                    {
                        timestop -= 100;
                    }
                }
            }
        }

        
        
        
        //Checking snake's head and body
        for (int i = 1; i < nBody; i++)
        {
            if (headX == bodyX[i] && headY == bodyY[i])
            {
                //Snake will be died when it eats itself (its head and body are the same position)
                gameOver = true;
            }
            if (fruitX == bodyX[i] && fruitY == bodyY[i] || fruitX == fruitVipX && fruitY == fruitVipY) //Food position must be different from snake's body postion
                randomFruit();
        }
    }

    //Game display on screen
    void Render()
    {
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1)   //Top and bottom edge
                    Console.Write("-");
                else if (j == 0 || j == width - 1) //Left and right edge
                    Console.Write("|");
                else if (j == fruitX && i == fruitY) //Fruit appreance
                    Console.Write("$");
                else if (j == headX && i == headY) //Snake's head appearance
                    Console.Write("0");
                else if (j == fruitVipX && i == fruitVipY)
                    Console.Write("*");
                else
                {
                    isprinted = false;
                    for (int k = 0; k < nBody; k++)
                    {
                        if (bodyX[k] == j && bodyY[k] == i)
                        {
                            Console.Write("o");  //Snake's body appearance
                            isprinted = true;
                        }
                    }
                    if (!isprinted) Console.Write(" "); //The other positions in 
                }
            }
            Console.WriteLine();
        }
        //Display score
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Your score: " + score);
        Console.WriteLine("Game Speed: " + timestop);
    }

    //After losing game
    void Lose()
    {
        Console.WriteLine("YOU DIED");
        Console.WriteLine("      - Press R key to RESET game");
        Console.WriteLine("      - Press Q key to QUIT game");

        while (true)
        {
            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.Q)
                Environment.Exit(0);
            if (keypress.Key == ConsoleKey.R)
                reset = true; break;
        }
    }

    static void Main(string[] args)
    {
        SnakeGamePlay snakegame = new SnakeGamePlay(); 
        snakegame.firstDisplay();
        while (true)
        {
            snakegame.Setup();
            snakegame.Update();
            Console.Clear(); //Clear sceen
        }
    }
}