
Console.WriteLine("Please enter which option you would like to choose: \n1.Receive Addition tasks\n2. Receive Substraction tasks\n " +
       "3. Receive Multiplication tasks\n4. Receive Division tasks\n 5. Show scores");

Random initNumber = new Random();
int taskNumber = initNumber.Next(1, 100);
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
            additionFunction();

            break;
        case "2":
            substractFunction();

            break;
        case "3":
            multiplicationFunction();

            break;
        case "4":
            divisionFunction();

            break;
        case "5":
            showGames();
            break;
    }
}

void showMenu()
{
    successes = 0;
    Console.WriteLine("Please enter which option you would like to choose: \n1.Receive Addition tasks\n2. Receive Substraction tasks\n " +
        "3. Receive Multiplication tasks\n4. Receive Division tasks\n 5. Show scores\n Type "exit" to leave");
    input = Console.ReadLine();
}
void additionFunction()
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
    showMenu();
}

void multiplicationFunction()
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
    showMenu();
}

void substractFunction()
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
    showMenu();
}

void divisionFunction()
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
    showMenu();
}

void showGames()
{
    for (int i = 0; i < gamesPlayed; i++)
    {
        Console.WriteLine($"Game: {numberofGames[i]}");
        Console.WriteLine($"Score : {numberofSuccesses[i]}");
    }
    showMenu();
}