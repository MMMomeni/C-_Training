// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a century: ");
String input = Console.ReadLine();
int century = Int32.Parse(input);
int years = century * 100;
int days = years * 365;
int hours = days * 24;
int minutes = hours * 60;
int seconds = minutes * 60;
int miliseconds = seconds * 1000;
int microseconds = miliseconds * 1000;
int nanoseconds = microseconds * 1000;
Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");



