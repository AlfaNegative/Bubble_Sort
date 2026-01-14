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


int[] numbers = {9,2,5,3,7,4,3,4,5,7};
bool inOrderFlag = false;

while(inOrderFlag == false)
{
    inOrderFlag = true;
    for (int i = 0; i < numbers.Count(); i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            inOrderFlag = false;
            int temp = numbers[i + 1];
            numbers[i+1] = numbers[i];
            numbers[i] = temp;
        }
    }
}

Console.WriteLine($"Your numbers are ordered");
foreach (int eachNum in numbers)
{
    Console.Write($"{eachNum}, ");
}