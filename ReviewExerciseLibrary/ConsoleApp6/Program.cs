using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    class Program
    {
        struct Book
        {
            public string author;
            public string title;
            public int shelf;
            public bool checkedout;
        }

        static void Main(string[] args)
        {
            int maxBooks = 50;
            Book[] library = new Book[maxBooks];
            int libraryCount = 0;
            int libraryIdx = 0;

            string cmd = "";
            string lCmd = "";
            Tools tl = new Tools();

            //MAIN LOOP
            tl.MyPrinter("LIBRARY (Ver 0.0.0.0.0.0.1)");
            tl.MyPrinter("Type \"help\" for a list of valid commands.");
            while (cmd.ToLower() != "exit")
            {
                tl.MyPrinter("");
                cmd = tl.Ask("Awaiting input >");
                lCmd = cmd.ToLower();
                if (lCmd == "help")
                {
                    tl.MyPrinter("Command list:\n\tadd: add a new book to the library.\n\tedit: edit specified existing book listing.\n\tremove: get rid of specified book.\n\tlist: list all current books in library.\n\tcheckout: check out specified book.\n\treturn: return specified book.\n\tclear: clears console.");
                }
                if (lCmd == "add")
                {
                    if (libraryCount < maxBooks)
                    {
                        Book tmp;
                        tmp.author = tl.Ask("Please enter Author >");
                        tmp.title = tl.Ask("Please enter Title >");
                        int.TryParse(tl.Ask("Please enter Current Shelf Number >"), out tmp.shelf);
                        tmp.checkedout = false;
                        library[libraryCount] = tmp;
                        libraryCount++;
                    }
                    else
                    {
                        tl.MyPrinter($"No more space for books! The max is {maxBooks}.");
                    }
                }
                if (lCmd == "edit")
                {
                    int.TryParse(tl.Ask("Please enter the index number of the book you wish to edit (check list if unknown) >"), out libraryIdx);
                    if (library[libraryIdx].checkedout == true)
                    {
                        library[libraryIdx].author = tl.Ask("Please enter Author >");
                        library[libraryIdx].title = tl.Ask("Please enter Title >");
                        int.TryParse(tl.Ask("Please enter Current Shelf Number >"), out library[libraryIdx].shelf);
                        tl.MyPrinter($"You fixed the listing for {library[libraryIdx].title}, by {library[libraryIdx].author}");
                    }
                    else
                    {
                        tl.MyPrinter("You can only edit listings currently not checked out!");
                    }
                }
                if (lCmd == "remove")
                {
                    int.TryParse(tl.Ask("Please enter the index number of the book you wish to remove (check list if unknown) >"), out libraryIdx);
                    cmd = tl.Ask($"Do you want to delete {library[libraryIdx].title}, by {library[libraryIdx].author}? Type \"Yes\" to confirm, or \"No\" to go back >");
                    lCmd = cmd.ToLower();
                    if (lCmd == "yes")
                    {
                        library[libraryIdx] = new Book();
                        tl.MyPrinter("Book removed");
                    }
                    else if (lCmd == "no")
                    {
                        tl.MyPrinter("Action cancled");
                    }
                    else
                    {
                        tl.MyPrinter("Command Unrecognized. Cancling...");
                    }
                    //Even setting the values to be "empty" like this lets it appear in the list.
                    //To get rid of it for real, you need to shift the rest of the values down accordingly- effectively "replacing" the deleted one with the one ahead of it.
                    //This will be gone over later.
                }
                if (lCmd == "list")
                {
                    //LtlACY FOR EXAMPLE/REFERENCE PURPOSES ONLY. KEEP COMMENTED UNLESS TESTING.
                    //foreach (Book book in library)
                    //{
                    //    tl.MyPrinter($"{book.author}, {book.title}, {book.shelf}, {book.checkedout}");
                    //}

                    //Difference between the above: this new version allows for easier referencing of specific books. 
                    //It also only shows books created by the user, getting rid of the cluster of unpopulated books.
                    Console.WriteLine($"Library size is currently {maxBooks} books large.");
                    for (libraryIdx = 0; libraryIdx < libraryCount; libraryIdx++)
                    {
                        Book book = library[libraryIdx];
                        tl.MyPrinter($"{libraryIdx}: {book.title}, by {book.author}. Shelf {book.shelf}. Currently checked out: {book.checkedout}");
                    }
                }
                if (lCmd == "checkout")
                {
                    int.TryParse(tl.Ask("Please enter the index number of the book you wish to checkout (check list if unknown) >"), out libraryIdx);
                    tl.MyPrinter($"You checked out {library[libraryIdx].title}, by {library[libraryIdx].author}");
                    library[libraryIdx].checkedout = true;
                }
                if (lCmd == "return")
                {
                    int.TryParse(tl.Ask("Please enter the index number of the book you wish to return (check list if unknown) >"), out libraryIdx);
                    tl.MyPrinter($"You returned {library[libraryIdx].title}, by {library[libraryIdx].author}");
                    library[libraryIdx].checkedout = false;
                }
                if (lCmd == "clear")
                {
                    Console.Clear();
                    tl.MyPrinter("LIBRARY (Ver 0.0.0.0.0.0.1)");
                    tl.MyPrinter("Type \"help\" for a list of valid commands.");
                }
                if (lCmd == "resize") //Super Secret Command
                {                    
                    int.TryParse(tl.Ask("???? >"), out maxBooks);
                    System.Array.Resize(ref library, maxBooks);
                }
            }
            tl.MyPrinter("End of execution");
            Console.ReadKey();
        }
    }
}
