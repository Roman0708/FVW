var initialArray = new string [] {"Russia","Denmark","Kazan","-2"};

var resultArray = new string[] {};

for (int count = 0; count < initialArray.GetLength(0); count++)
{
    if (initialArray[count].Length <= 3)
    {
        Array.Resize(ref resultArray, resultArray.Length + 1);
        resultArray[resultArray.GetLength(0) - 1] = initialArray[count];
    }
}

//if (resultArray.Length == 0) Console.WriteLine("Нечего выводить");
//else for (int a = 0; a < resultArray.GetLength(0); a++) Console.Write($"{resultArray[a]}, ");