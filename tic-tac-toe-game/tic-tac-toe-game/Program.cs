using tic_tac_toe_game;

Functions fnc = new Functions();

bool cont = true;
do
{
    Console.WriteLine("1. New game");
    Console.WriteLine("2. About the author");
    Console.WriteLine("3. Exit");
    Console.Write("> ");
    string selection = Console.ReadLine();
    Console.WriteLine();

    switch (selection)
    {
        case "1":

            int action = 0;
            char[] list = new char[9];
            fnc.drawTable(list);

            do
            {
                if (action != 9)
                {
                    char player = (action % 2 == 0) ? 'X' : 'O';
                    Console.Write($"{player}'s move > ");
                    string tempMove = Console.ReadLine();
                    int move = int.Parse(string.IsNullOrEmpty(tempMove) ? "10" : tempMove) - 1;
                    Console.WriteLine();
                    if (move < 0 || list.Length <= move || list[move] == 'X' || list[move] == 'O')
                    {
                        Console.WriteLine("Illegal move! Try again.\n");
                        continue;
                    }
                    list[move] = player;
                    action++;
                    fnc.drawTable(list);

                    if (fnc.checkWinner(list, 'X') || fnc.checkWinner(list, 'O'))
                    {
                        Console.WriteLine(fnc.checkWinner(list, 'X') ? "X won!" : "O won!");
                        Console.Write("[Press Enter to return to main menu...]");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Game over!");
                    Console.Write("[Press Enter to return to main menu...]");
                    Console.ReadLine();
                    Console.WriteLine();
                    break;
                }
            } while (action < 10);

            break;
        case "2":
            Console.WriteLine("This application was made by Enes Alkus");
            Console.Write("[Press Enter to return to main menu...]");
            Console.ReadLine();
            Console.WriteLine();
            break;
        case "3":

            Console.WriteLine("Are you sure you want to quit? [y/n]");
            Console.Write("> ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y") cont = false;
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("");
            break;
    }


} while (cont);
