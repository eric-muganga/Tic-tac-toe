/*
 * Modify the tic-tac-toe game from the previous set of exercises. Now, instead of asking the user to 
 * provide the whole state of the game at once, the user should place each symbol one move at a time 
– just like in a normal tic-tac-toe game – X and O in turns. For now, you don’t have to check if 
anyone has won – just write “Game over!” when the board is filled. Just remember to prevent the 
user from making an illegal move! Below is an example game
*/

using System.Numerics;

char[] pos= new char[9];
bool playing = true;
bool X = true;
bool O = true;
int end = 0;
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to the tic-tac-toe!");
Console.WriteLine("");

Console.WriteLine("   |   |   ");
Console.WriteLine("---+---+---");
Console.WriteLine("   |   |   ");
Console.WriteLine("---+---+---");
Console.WriteLine("   |   |   ");

while(playing)
{
    
    try 
    {
        
        if (X)
        {
            Again:
            Console.WriteLine("\n");
            Console.Write("X's move > ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (pos[choice - 1] != 'X' && pos[choice - 1] != 'O')
            {
                pos[choice - 1] = 'X';
                Board();// calling the board Function
                end += 1;
            }
            else
            {
                Console.WriteLine("Illegal move! Try again.");
                Console.WriteLine("\n");
                goto Again;
            }

        }
        if (O)
        {
            Again:
            Console.WriteLine("\n");
            Console.Write("O's move > ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (pos[choice-1] != 'X' && pos[choice-1] != 'O')
            {
                pos[choice - 1] = 'O';
                Board();// calling the board Function
                end += 1;
            }
            else
            {
                Console.WriteLine("Illegal move! Try again.");

                Console.WriteLine("\n");
                goto Again;
            }
        }
    }
    catch
    {
        Console.WriteLine("Illegal move! Try again.");
        
    }
    if(end == 9)
    {
        Console.WriteLine("\n");
        Console.WriteLine("Game Over");
        break;
    }
    
}


    // Board function which creats board
    void Board()
{
    Console.WriteLine($" {pos[0]} | {pos[1]} | {pos[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {pos[3]} | {pos[4]} | {pos[5]}  ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {pos[6]} | {pos[7]} | {pos[8]}  ");

}
