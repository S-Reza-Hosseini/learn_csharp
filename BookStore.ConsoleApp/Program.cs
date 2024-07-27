// See https://aka.ms/new-console-template for more information


// tamri 1
// function with input and output
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;




static int Sumation2Adad(int num1, int num2)
{
    return num1+num2;
}
// function without input and output
static void printMeaningLessString()
{
    Console.WriteLine("i have realy doesn't have action but i am here !");
}
// function with input and without output
static void FindMax(int []numbers)
{
    int max = 0;
    for(int i = 0; i < numbers.Length; i++){

        max = numbers[0] ;

        if (numbers[i]> max)
            max = numbers[i];
    }

    Console.WriteLine($"max in numbers array is {max} !!!");
}

// function without input and with output
static int GetRandomNumber()
{
    Random random = new Random();

    return random.Next(1, 100);
}







// tamrin 2
// part 1
Console.WriteLine(DescendingReturner(GetNumber("Enter number for returnal Descending :")));

//tamrin 2
// part 2
printTogether("ali", "reza", "mmad" , "hashem");






static string DescendingReturner(int number )
{
    
    if (number == 1)

        return "1";

    return $"{number} , {DescendingReturner(number- 1)}";
}

static int GetNumber(string msg) 
{
    bool canParseNumber = false;
    var number = 0;
    while(!canParseNumber){
    Console.WriteLine(msg);
    canParseNumber = int.TryParse(Console.ReadLine(), out number);
    }

    return number;
}


static void printTogether(params string[] name )
{
    Console.WriteLine($"{string.Join(',' , name)}");
}

