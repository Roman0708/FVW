// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var initialArray = new string [] {"hello","2","world",":-)"};

int length = initialArray.GetLength(0);
//int count = 0;

var resultArray = new string[] {};

for (int count = 0; count < length; count++)
{
    if (initialArray[count].Length <= 3)
    {
        resultArray[resultArray.GetLength(0)] = initialArray[count];
        Array.Resize(ref resultArray, resultArray.Length + 1);
    }
}

