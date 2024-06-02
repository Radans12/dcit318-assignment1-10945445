using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();

        // Parse the user input as a double
        if (double.TryParse(input, out double grade))
        {
            // Validate that the grade is within the correct range
            if (grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade = GetLetterGrade(grade);

                // Display the letter grade
                Console.WriteLine($"Grade: {letterGrade}");
            }
            else
            {
                // Grade is outside the valid range
                Console.WriteLine("The grade must be between 0 and 100.");
            }
        }
        //Fallback action
        else
        {
            Console.WriteLine("Invalid user input. Please enter a numerical grade.");
        }
    }

    static string GetLetterGrade(double grade)
    {
        // Determine the range for the grade
        int gradeRange = (int)grade / 10;

        // switch statement to determine the letter grade
        switch (gradeRange)
        {
            case 10:
            case 9:
                return "A";
            case 8:
                return "B";
            case 7:
                return "C";
            case 6:
                return "D";
            default:
                return "F";
        }
    }
}
