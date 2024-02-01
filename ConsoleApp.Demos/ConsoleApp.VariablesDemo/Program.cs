// Different data types

/*
    text        -   str
    integers    -   int
    decimal     -   double, float, decimal
    boolean     -   bool
*/

string firstName = "Benedict";
string lastName = "Castro";

Console.WriteLine($"My name is {firstName} {lastName}.");
Console.WriteLine("I am {0} {1}.", firstName, lastName);

////////////////////////////////////////////////////////////////////////////////////////////

int myAge = 30;

////////////////////////////////////////////////////////////////////////////////////////////

bool isHungry = false;

Console.WriteLine($"I am already {myAge}.");

if (isHungry)
{
    Console.WriteLine("I want to eat.");
}
else
{
    Console.WriteLine("I don't want to eat.");
}