// See https://aka.ms/new-console-template for more information


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Check Number is Palindrom or not");

Console.WriteLine("Enter number");
int num = int.Parse(Console.ReadLine());

int temp = num;
int finalAns = 0;
while(num!=0){
    int rem = num % 10;
    finalAns = finalAns * 10 + rem;
    num = num / 10;
}
if(temp == finalAns){
    Console.WriteLine("{0} is a Palindrome Number ",temp);
}else{
    Console.WriteLine("{0} is not a Palindrome number ",temp);
}



