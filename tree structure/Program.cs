using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Database Models");
            Console.WriteLine("b. Web Development Frontend Technologies");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
            {
                goto DatabaseModels;
            }
            else if (userChoice == "b")
            {
                goto WebDevelopmentFrontendTechnologies;
            }
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    DatabaseModels:
        Console.WriteLine("Database Models");
        Console.WriteLine("a. Relational");
        Console.WriteLine("b. NonRelational");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto Relational;
        }
        else if (userChoice == "b")
        {
            goto NonRelational;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto DatabaseModels;
        }

    Relational:
        Console.WriteLine("Relational");
        Console.WriteLine("a. SQL");
        Console.WriteLine("b. ACID properties");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("SQL");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("ACID properties");
        }
        else if (userChoice == "c")
        {
            goto DatabaseModels;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Relational;
        }
        Console.WriteLine();
        goto Relational;

    NonRelational:
        Console.WriteLine("NonRelational");
        Console.WriteLine("a. NoSQL");
        Console.WriteLine("b. CAP theorem");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("NoSQL");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("CAP theorem");
        }
        else if (userChoice == "c")
        {
            goto DatabaseModels;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto NonRelational;
        }
        Console.WriteLine();
        goto NonRelational;

    WebDevelopmentFrontendTechnologies:
        Console.WriteLine("Web Development Frontend Technologies");
        Console.WriteLine("a. Markup");
        Console.WriteLine("b. Styling");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto Markup;
        }
        else if (userChoice == "b")
        {
            goto Styling;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto WebDevelopmentFrontendTechnologies;
        }

    Markup:
        Console.WriteLine("Markup");
        Console.WriteLine("a. HTML");
        Console.WriteLine("b. XML");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("HTML");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("XML");
        }
        else if (userChoice == "c")
        {
            goto WebDevelopmentFrontendTechnologies;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Markup;
        }
        Console.WriteLine();
        goto Markup;

    Styling:
        Console.WriteLine("Styling");
        Console.WriteLine("a. CSS");
        Console.WriteLine("b. Sass");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("CSS");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Sass");
        }
        else if (userChoice == "c")
        {
            goto WebDevelopmentFrontendTechnologies;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Styling;
        }
        Console.WriteLine();
        goto Styling;

    End:
        Console.WriteLine("Closing the program...");
    }
}