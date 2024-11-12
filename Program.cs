// Sett opp biblioteket
Library library = new Library();

// Lag bøkene
Book martian = new Book("Martian", "Jane Doe", new DateTime(2004, 3, 25));
Book cookWithGandalf = new Book("You Shall Not Fast: A Cookbook", "Gandalf the Grey", new DateTime(3019, 3, 25));
Book catGuide = new Book("How to Knock Over Everything", "Whiskers the Cat", new DateTime(2023, 1, 1));
Book elfPsychology = new Book("Am I Overthinking This?", "An Elf on the Shelf", new DateTime(2020, 12, 1));
Book programmerLife = new Book("Infinite Loops and Caffeine", "Anonymous Programmer", new DateTime(2024, 5, 7));
Book gymRegret = new Book("Never Leg Day", "Skip Legman", new DateTime(2022, 4, 12));
Book procrastinator = new Book("I'll Finish This Book Tomorrow", "Pro Crastinator", new DateTime(2025, 6, 30));
Book catSecrets = new Book("The Art of the Perfect Nap", "Garfield", new DateTime(1978, 6, 19));
Book sarcasmGuide = new Book("Oh, Really?", "Dr. Sarcasm", new DateTime(2018, 9, 15));
Book alienMemoirs = new Book("Earthlings: A Field Guide", "Zorg of Planet X", new DateTime(2050, 11, 11));
Book timeTravel = new Book("Oops, Wrong Century", "Time Traveler X", new DateTime(1805, 3, 14));

// Legg til bøker i biblioteket
library.AddNewBook(martian);
library.AddNewBook(cookWithGandalf);
library.AddNewBook(catGuide);
library.AddNewBook(elfPsychology);
library.AddNewBook(programmerLife);
library.AddNewBook(gymRegret);
library.AddNewBook(procrastinator);
library.AddNewBook(catSecrets);
library.AddNewBook(sarcasmGuide);
library.AddNewBook(alienMemoirs);
library.AddNewBook(timeTravel);


// Håndter bruker input
bool runProgram = true;
while (runProgram)
{
  // les av bruker input
  Console.WriteLine("Do you want to lend, return or list available books?");
  string? userInput = Console.ReadLine();

  // Vi må finne hva bruker skrev inn

  // List ut tilgjengelige bøker
  if (userInput == "list")
  {
    Console.WriteLine("Here are available books:");
    List<Book> availableBooks = library.ListAvailableBooks();

    foreach (var book in availableBooks)
    {
      Console.WriteLine(book.Title);
    }
  }
  // For å låne en bok (lend)
  else if (userInput == "lend")
  {
    Console.WriteLine("What is the title of the book?");
    string? wantedBookTitle = Console.ReadLine();

    if (wantedBookTitle == null)
    {
      continue; // Start hoved løkken på nytt
    }

    Book? book = library.LendBook(wantedBookTitle);

    // Det kan hende biblioteket ikke hadde boken vår
    if (book == null)
    {
      Console.WriteLine("No book with title found: " + wantedBookTitle);
    }
    else
    {
      Console.WriteLine("Lending book: " + book.Title);
      library.RemoveBook(book);
    }
  }
  // For å lever tilbake en bok (return)
  else if (userInput == "return")
  {
    Console.WriteLine("What is the title for the book you want to return?");


  }
  // For å avslutte (exit)
  else if (userInput == "exit")
  {
    runProgram = false;
  }
}