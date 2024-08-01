// See https://aka.ms/new-console-template for more information
Console.WriteLine("Check Number is Prime or not");

Console.WriteLine("Enter number");
int num = int.Parse(Console.ReadLine());

int i;
for(i = 2;i<num;i++){
    if(num%i==0){
        Console.WriteLine("{0} is Not a Prime number ",num);
        break;
    }
}

if(num == i){
    Console.WriteLine("{0} is a prime number",num);
}
