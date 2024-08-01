// See https://aka.ms/new-console-template for more information

Console.WriteLine("Demo how to take input from user !");

// Take input from user

// First way to take input

Console.WriteLine("Enter first Number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Number you have entered "+firstNum);

// How to check Type of Data .
Console.WriteLine(firstNum.GetType()); 


// Second way to take input
Console.WriteLine("Enter Second Number");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number you have entered "+secondNum);

