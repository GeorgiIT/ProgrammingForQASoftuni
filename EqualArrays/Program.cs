string[] strArr = Console.ReadLine().Split(' ').ToArray();
string[] strArr2 = Console.ReadLine().Split(' ').ToArray();
int[] arr = new int[strArr.Length];
int[] arr2 = new int[strArr2.Length];

for (int i = 0; i < strArr.Length; i++)
{
    arr[i] = int.Parse(strArr[i]);
}

for (int i = 0; i < strArr2.Length; i++)
{
    arr2[i] = int.Parse(strArr2[i]);
}

bool areEqual = arr.SequenceEqual(arr2);

if (areEqual)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}