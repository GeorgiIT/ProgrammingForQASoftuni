static int EvenAndOddSubtraction(int[] arr)
{
    int evenSum = 0;
    int oddSum = 0;
    for (int i = 0; i < arr.Length; i++ )
    {
        if (arr[i] % 2 == 0)
        {
            evenSum += arr[i];
        }
        else
        {
            oddSum += arr[i];
        }
    }
    return evenSum - oddSum;
}



string[] strArr = Console.ReadLine().Split(' ').ToArray();
int[] arr  = new int[strArr.Length];
for (int i = 0; i < strArr.Length; i++)
{
    arr[i] = int.Parse(strArr[i]);
}

Console.WriteLine(EvenAndOddSubtraction(arr));



