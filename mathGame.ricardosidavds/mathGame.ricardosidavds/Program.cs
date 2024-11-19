
Console.WriteLine("Please enter which option you would like to choose: \n1.Receive Addition tasks\n2. Receive Substraction tasks\n " +
       "3. Receive Multiplication tasks\n4. Receive Division tasks\n 5. Show scores");

Random initNumber = new Random();
int successes = 0;
string? input = Console.ReadLine();
int gamesPlayed = 0;
int[] numberofGames = new int[50];
int[] numberofSuccesses = new int[50];
while (input.ToLower() != "exit")
{
    switch (input)
    {
        case "1":
            AdditionFunction();

            break;
        case "2":
            SubstractFunction();

            break;
        case "3":
            MultiplicationFunction();

            break;
        case "4":
            DivisionFunction();

            break;
        case "5":
            ShowGames();
            break;
    }
}

void ShowMenu()
{
    successes = 0;
    Console.WriteLine("Please enter which option you would like to choose: \n1.Receive Addition tasks\n2. Receive Substraction tasks\n " +
        "3. Receive Multiplication tasks\n4. Receive Division tasks\n 5. Show scores\n Type exit to leave");
    input = Console.ReadLine();
}
void AdditionFunction()
{
    for (int i = 0; i < 5; i++)
    {
        int taskNumber = initNumber.Next(1, 100);
        int taskNumber2 = initNumber.Next(1, 100);
        int result = taskNumber + taskNumber2;
        Console.WriteLine($"{taskNumber} + {taskNumber2}");
        Console.WriteLine("What does this result in?");
        string? answer = Console.ReadLine();
        while (answer == null)
        {
            Console.WriteLine("What does this result in?");
            answer = Console.ReadLine();
        }
        if (answer == result.ToString())
        {
            Console.WriteLine("That is correct!");
            successes++;
        }
        else
        {
            Console.WriteLine("That is incorrect!");
        }
    }
    numberofGames[gamesPlayed] = gamesPlayed + 1;
    numberofSuccesses[gamesPlayed] = successes;
    gamesPlayed += 1;
    ShowMenu();
}

void MultiplicationFunction()
{
    for (int i = 0; i < 10; i++)
    {
        int taskNumber = initNumber.Next(1, 10);
        int taskNumber2 = initNumber.Next(1, 15);
        int result = taskNumber * taskNumber2;
        Console.WriteLine($"{taskNumber} * {taskNumber2}");
        Console.WriteLine("What does this result in?");
        string? answer = Console.ReadLine();
        while (answer == null)
        {
            Console.WriteLine("What does this result in?");
            answer = Console.ReadLine();
        }
        if (answer == result.ToString())
        {
            Console.WriteLine("That is correct!");
            successes++;
        }
        else
        {
            Console.WriteLine("That is incorrect!");
        }
    }
    numberofGames[gamesPlayed] = gamesPlayed + 1;
    numberofSuccesses[gamesPlayed] = successes;
    gamesPlayed += 1;
    ShowMenu();
}

void SubstractFunction()
{
    for (int i = 0; i < 10; i++)
    {
        int result = 0;
        int taskNumber = initNumber.Next(1, 100);
        int taskNumber2 = initNumber.Next(1, 100);
        if (taskNumber >= taskNumber2)
        {
            result = taskNumber - taskNumber2;
            Console.WriteLine($"{taskNumber} - {taskNumber2}");
        }
        else
        {
            result = taskNumber2 - taskNumber;
            Console.WriteLine($"{taskNumber2} - {taskNumber}");
        }

        Console.WriteLine("What does this result in?");
        string? answer = Console.ReadLine();
        while (answer == null)
        {
            Console.WriteLine("What does this result in?");
            answer = Console.ReadLine();
        }
        if (answer == result.ToString())
        {
            Console.WriteLine("That is correct!");
            successes++;
        }
        else
        {
            Console.WriteLine("That is incorrect!");
        }
    }
    numberofGames[gamesPlayed] = gamesPlayed + 1;
    numberofSuccesses[gamesPlayed] = successes;
    gamesPlayed += 1;
    ShowMenu();
}

void DivisionFunction()
{
    for (int i = 0; i < 10; i++)
    {
        int result = 0;
        int inbetween = initNumber.Next(1, 10);
        int taskNumber2 = initNumber.Next(1, 20);
        int taskNumber = inbetween * taskNumber2;
        if (taskNumber >= taskNumber2)
        {
            result = taskNumber / taskNumber2;
            Console.WriteLine($"{taskNumber} / {taskNumber2}");
        }
        else
        {
            result = taskNumber2 / taskNumber;
            Console.WriteLine($"{taskNumber2} / {taskNumber}");
        }

        Console.WriteLine("What does this result in?");
        string? answer = Console.ReadLine();
        while (answer == null)
        {
            Console.WriteLine("What does this result in?");
            answer = Console.ReadLine();
        }
        if (answer == result.ToString())
        {
            Console.WriteLine("That is correct!");
            successes++;
        }
        else
        {
            Console.WriteLine("That is incorrect!");
        }
    }
    numberofGames[gamesPlayed] = gamesPlayed + 1;
    numberofSuccesses[gamesPlayed] = successes;
    gamesPlayed += 1;
    ShowMenu();
}

void ShowGames()
{
    for (int i = 0; i < gamesPlayed; i++)
    {
        Console.WriteLine($"Game: {numberofGames[i]}");
        Console.WriteLine($"Score : {numberofSuccesses[i]}");
    }
    ShowMenu();
}