// Declare variables

string name = string.Empty;
double yourHeight;

// Prompt the user for input

Console.Write("Please enter your height (m): ");
yourHeight = Convert.ToDouble(Console.ReadLine());


// Process the data

int heightCm = (int)yourHeight * 100;
Console.WriteLine($"Your height is {heightCm} cm.");