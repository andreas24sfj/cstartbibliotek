




bool runProgram = true;
while (runProgram)
{
    // Les av bruker input
    Console.WriteLine("Do you want to lend or return?");
    string? userInput = Console.ReadLine();

    // Vi må finne ut hva bruker skrev inn
    // For å låne en bok (lend)
    if (userInput == "lend")
    {
        Console.WriteLine("Lending a book");
    }

    // For å levere tilbake en bok (return)
    else if (userInput == "return"){
        Console.WriteLine("Returning a book");
    }

    // For å avslutte (exit)
    else if (userInput == "exit"){
        runProgram = false;
    }
}

