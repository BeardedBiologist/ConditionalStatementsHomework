/* BREIF:
 * 
 * Create a Console Application that asks the user for their name. 
 * Welcome me (Josh) as professor or anyone else as student. 
 * Make sure that "JOSH" also gets called professor.
 * 
 * 
 */

Console.WriteLine("Welcome to the Conditional Statement Homework App");
Console.WriteLine();
Console.WriteLine();

Console.Write("What is your FIRST NAME ?: ");
string? firstName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine();

if (firstName.ToLower() == "josh")
{
    Console.WriteLine("Welcome Professor!");
}
else
{
    Console.WriteLine("Welcome Student!");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Press ENTER to Exit");
Console.ReadLine();