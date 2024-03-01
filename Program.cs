// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Welcome to Kyaria's C# Calculator!");

//Create calcuation 
// how many current kids
Console.WriteLine("How many kids do you currently have?");

string inputCurrentKids = Console.ReadLine();

int currentKids = int.Parse(inputCurrentKids);

// Kids user wants to have

Console.WriteLine("How many more kids do you want to have ?");
string inputFutureKids = Console.ReadLine();

int futureKids = int.Parse(inputFutureKids);

// total number of kids current and future
int totalKids = currentKids + futureKids;
Console.WriteLine($"WoW ! You have {currentKids} and you want {futureKids}, you want a total of {totalKids} kids");

switch(totalKids)
{
    case < 0:
    break;
}