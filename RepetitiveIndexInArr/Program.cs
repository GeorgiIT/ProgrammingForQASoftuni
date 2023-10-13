using System.Reflection.Metadata.Ecma335;

static void RepetitiveIndex(int[] index, int num)
{
    int count = 0;
    foreach(int a in index)
    {
        if(a == num) count++;
    }
    Console.WriteLine(count);   
}



Console.WriteLine("How long to be the array?");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    arr[i] = number;
}

Console.WriteLine("Check a number how many times is in the array");
int num = int.Parse(Console.ReadLine());
RepetitiveIndex(arr, num);