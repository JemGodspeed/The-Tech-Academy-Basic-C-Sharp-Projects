using System;

class DailyReport
{
    static void Main()
    {
        // Print the title
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine();

        // Declare variables for the user input
        string name;
        string course;
        int pageNumber;
        bool needsHelp;
        string positiveExperiences;
        string feedback;
        int studyHours;

        // Ask for user input and save data to variables
        Console.Write("What is your name? ");
        name = Console.ReadLine();

        Console.Write("What course are you on? ");
        course = Console.ReadLine();

        Console.Write("What page number? ");
        pageNumber = Convert.ToInt32(Console.ReadLine());

        // Input validation for needsHelp
        Console.Write("Do you need help with anything? Please answer “true” or “false”: ");
        string helpInput = Console.ReadLine();
        while (helpInput.ToLower() != "true" && helpInput.ToLower() != "false")
        {
            Console.Write("Invalid input. Please answer “true” or “false”: ");
            helpInput = Console.ReadLine();
        }
        needsHelp = Convert.ToBoolean(helpInput);

        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        positiveExperiences = Console.ReadLine();

        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        feedback = Console.ReadLine();

        Console.Write("How many hours did you study today? ");
        studyHours = Convert.ToInt32(Console.ReadLine());

        // Print the daily report
        Console.WriteLine();
        Console.WriteLine("Student Daily Report Summary:");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Page Number: {pageNumber}");
        Console.WriteLine($"Needs Help: {needsHelp}");
        Console.WriteLine($"Positive Experiences: {positiveExperiences}");
        Console.WriteLine($"Other Feedback: {feedback}");
        Console.WriteLine($"Study Hours: {studyHours}");

        // Print the thank you message
        Console.WriteLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}
