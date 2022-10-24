// opgv 1
void welcome()
{
    Console.WriteLine("Welcome Friends!");
}
void niceday()
{
    Console.WriteLine("Have a nice day!");
}
welcome();
niceday();

//opgv 2

void getName()
{
    Console.WriteLine("Please input a name: ");
    var name = Console.ReadLine();
    Console.WriteLine($"Welcome friend {name}!");
    niceday();
}
/////getName();
//opgv 3
void sumTwo()
{
    Console.WriteLine("Enter a number: ");
    var input = int.TryParse(Console.ReadLine(), out int num1);
    if (!input)
    {
        Console.WriteLine("Not a valid number");
        return;
    }
    Console.WriteLine("Enter another number: ");
    var input2 = int.TryParse(Console.ReadLine(), out int num2);
    if (!input2)
    {
        Console.WriteLine("Not a valid number");
        return;
    }
    Console.WriteLine(num1 + num2);

}
/////sumTwo();
//oppgv 4
void howManySpaces()
{
    Console.WriteLine("Please input a string: ");
    var str = Console.ReadLine();
    var c = str.Count(x => x == ' ');
    Console.WriteLine($"{str} contains {c} spaces.");
}
////howManySpaces();
//oppgv 5
void sumofArray()
{
    Console.WriteLine("Input 5 elements in an array");
    var list = new List<int>();
    for(int i = 1; i<6; i++)
    {
        Console.WriteLine($"Element - {i}: ");
        var inp = int.TryParse(Console.ReadLine(), out int num);
        if(!inp)
        {
            Console.WriteLine("Not a valid number");
            return;
        }
        list.Add(num);
    }
    Console.WriteLine($"The sum of the array is: {list.Sum()}");
}
////sumofArray();
//oppgv 6
void swap()
{
    Console.WriteLine("Enter a number");
    var str = Console.ReadLine();
    Console.WriteLine("Enter another number");
    var str2 = Console.ReadLine();
    Console.WriteLine($"Now the 1st number is {str2}, and the 2nd number is {str}");
}
//swap()
//oppgv 7
void ret()
{
    Console.WriteLine("Not a valid number");
    return;
}
void Pow()
{
    Console.WriteLine("Input base number");
    var p = int.TryParse(Console.ReadLine(),out int bas);
    if (!p)
        ret();
    Console.WriteLine("Input the exponent");
    var p2 = int.TryParse(Console.ReadLine(), out int expo);
    if (!p2)
        ret();
    Console.WriteLine($"So, the number {bas} ^ (to the power) {expo} = {Math.Pow(bas, expo)}");

}
//Pow();
// oppgv 8 
void Fibonacci()
{
    Console.WriteLine("Input number of fibonacci series:");
    var p = int.TryParse(Console.ReadLine(), out int fib);
    if (!p)
        ret();
    var a = 0;
    var b = 1;
    var c = 0;
    for(int i = 2; i<= fib; i++)
    {
        c = a + b;
        Console.WriteLine(c);
        a = b;
        b = c;
    }

}
//Fibonacci();
//oppgv 9
void isprime()
{
    Console.WriteLine("input a number");
    var p = int.TryParse(Console.ReadLine(), out int num);
    if (!p)
        ret();
    if(num == 1)
    {
        Console.WriteLine("Prime");
    }
    else
    {
        var tru = true;
        for(int i = 2; i<num; i++)
        {
            if(num%i==0)
            {
                tru = false;
                break;
            }
        }
        if (tru)
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");
    }
}
//isprime();
//oppgv 10 
void sumNum()
{
    Console.WriteLine("input a number");
    var p = int.TryParse(Console.ReadLine(), out int num);
    if (!p)
        ret();
    var s = 0;
    foreach(char z in num.ToString())
    {
        s += int.Parse(z.ToString());
    }
    Console.WriteLine($"The sum of the digits of the number {num} is: {s}");
}
//oppgave 11
int Factorial(int num)
{
    if(num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}
//oppgv 12
//idk bro