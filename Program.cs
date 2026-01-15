// 9,2,5,3,7,4,3,4,5,7
// takes the first and second if the second is bigger then it moves on
//      if smaller then store it in a int and move the first one to its place
// goes on to the second number and does the same thing
// repeats until it doesnt change a number
//
// Psudeo Code:
//
//  Function Sort(int[])
//      for i in int[]
//          if int[i] > int[i + 1]
//              temp = int[i + 1]
//              int[i+1] = int[i]
//              int[i] = temp


using Stopwatch = System.Diagnostics.Stopwatch;
Stopwatch sw = new Stopwatch();

int[] numbers1 = { 9, 2, 5, 3, 7, 4, 3, 4, 5, 7 };
int[] numbers2 = {5, 40, 17, 13, 12, 9, 2, 36, 19, 34, 31, 45, 14, 32, 28, 23, 43, 48, 39, 41, 47, 46, 37, 1};
int[] numbers3 = {50, 22, 20, 40, 29, 44, 32, 36, 24, 4, 48, 16, 12, 6, 49, 8, 39, 2, 45, 10, 13, 46, 25, 42, 41, 30, 17, 19, 31, 21,};
int[] numbers4 = {46, 18, 9, 23, 28, 34, 25, 50, 14, 37, 43, 47, 36, 20, 12, 33, 24, 1, 4, 38, 15, 41, 27, 30, 17, 3, 29, 8, 5, 45, 40, 19, 10, 13, 44, 35, 7 ,48 ,6 ,42 ,39 ,16 ,2 ,11 ,31 ,49 ,32 ,22 ,21 ,26};

sw = Stopwatch.StartNew();
Sort(numbers1);
sw.Stop();
Console.WriteLine("");
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");

sw = Stopwatch.StartNew();
Sort(numbers2);
sw.Stop();
Console.WriteLine("");
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");

sw = Stopwatch.StartNew();
Sort(numbers3);
sw.Stop();
Console.WriteLine("");
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");

sw = Stopwatch.StartNew();
Sort(numbers4);
sw.Stop();
Console.WriteLine("");
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");

void Sort(int[] numbers)
{

    bool inOrderFlag = false;

    while (inOrderFlag == false)
    {
        inOrderFlag = true;
        for (int i = 0; i < numbers.Count() - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                inOrderFlag = false;
                int temp = numbers[i + 1];
                numbers[i + 1] = numbers[i];
                numbers[i] = temp;
            }
        }
    }

    Console.WriteLine($"Your numbers are ordered");
    foreach (int eachNum in numbers)
    {
        Console.Write($"{eachNum}, ");
        
    }
}