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
            Console.WriteLine("\n");
            Console.Write("X's move > ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (pos[choice] != 'X' && pos[choice] != 'O')
            {
                pos[choice] = 'X';
                Board();// calling the board Function
            }
            else
            {
                Console.WriteLine("Illegal move! Try again.");
                Console.WriteLine("\n");

            }

        }
        if (O)
        {
            Console.WriteLine("\n");
            Console.Write("O's move > ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (pos[choice] != 'X' && pos[choice] != 'O')
            {
                pos[choice] = 'O';
                Board();// calling the board Function
            }
            else
            {
                Console.WriteLine("Illegal move! Try again.");

                Console.WriteLine("\n");
            }
        }
    }
    catch
    {
        Console.WriteLine("Illegal move! Try again.");
        Console.ReadLine();
    }
    
    
}

    // Board method which creats board
    void Board()
{
    Console.WriteLine($" {pos[0]} | {pos[1]} | {pos[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {pos[3]} | {pos[4]} | {pos[5]}  ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {pos[6]} | {pos[7]} | {pos[8]}  ");

}
