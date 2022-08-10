// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("=========== BMI Calculator ===========");
Console.WriteLine();

Console.Write("Gender (type m or f):");
string G = Console.ReadLine();

Console.Write("Height in cm: ");
int m;
m = Convert.ToInt32(Console.ReadLine());

Console.Write("Weight in kg: ");
int kg;
kg = Convert.ToInt32(Console.ReadLine());


double BMI = kg / ((m / 100.0) * (m / 100.0));

if (BMI < 19 & G == "f")
{ Console.WriteLine("-> Underweight"); }
if (BMI >= 19 & BMI <= 24 & G == "f")
{ Console.WriteLine("-> Normal"); }
if (BMI > 24 & G == "f")
{ Console.WriteLine("-> Overweight"); }

if (BMI < 20 & G == "m")
{ Console.WriteLine("-> Underweight"); }
if (BMI >= 20 & BMI <= 25 & G == "m")
{ Console.WriteLine("-> Normal"); }
if (BMI > 25 & G == "m")
{ Console.WriteLine("-> Overweight"); }

Console.ReadLine();