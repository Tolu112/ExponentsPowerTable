Console.WriteLine("Welcome!");
//Loop Program
bool runProgram = true;
while (runProgram)
{
    int value = 0;
    //Loop to get int
    while (true)
    {
        Console.Write("\n" + "Enter a number greater than 0: ");
        value = int.Parse(Console.ReadLine());
        if (value > 0)
        {
            //if condition is not met, this breaks out of infinite loop
            break;
        }
    }
    // Display header
    var header = String.Format("\n" + "{0,10}{1,15}{2,17}", "Number", "Squared", "Cubed");
    Console.WriteLine(header);
    for (int i = 1; i <= value; i++)
    {
        Console.WriteLine(String.Format("{0,10}{1,15}{2,17}", i, CalculateSquare(i), CalculateCube(i)));

    }

    //Calculations
    //Square the integer; Use method

    static int CalculateSquare(int value)
    {
      double CalculateSquare = Math.Pow(value, 2.00);
      return (int)CalculateSquare;
    }

    //Cube the integer; Use method double numSquared = Math.Pow(num, 2.00);
    static int CalculateCube(int value)
    {
      double CalculateCube = Math.Pow(value, 3.00);
      return (int)CalculateCube;
    }

    //get out of loop
    Console.Write("\n" + "Would you like to continue? y/n ");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "y") { runProgram = true; }
    else if (loopChoice.ToLower().Trim() == "n") runProgram = false; Console.WriteLine("\n" + "Goodbye!"); 
}



/*EXPONENTS / Powers Table
Objectives: User input, calculations

NOTE: Points will still be awarded for items that are written correctly but don’t actually work due to other things being broken. There are a total of 10 points available for this lab.

Task: Display a table of powers. Ask the user if they would like to go again, and if so loop back to the beginning.

What will the application do?
•	1 Point: The application prompts the user to enter an integer.
•	3 Point: The application displays a table of squares and cubes from 1 to the value entered.
•	1 Point: The application prompts the user to continue.

Build Specifications:
•	1 Point: Assume that the user will enter valid data.
•	1 Point: The application should continue only if the user agrees to.

Additional Requirements:
•	1 Point: For answering the Lab Summary when submitting to the LMS
•	-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method). 

Hints:
•	Don’t mess up the difference between squares and cubes! 
•	Use \t to tab to line up columns properly
•	Your instructor will provide you with sample loops during class regarding how to ask the user if they would like to go again.

Extra Challenges:
•	1 Point: Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
•	1 Point: Research formatted strings and right-align the numbers in columns instead of left-aligning them
•	1 Point: Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less */
