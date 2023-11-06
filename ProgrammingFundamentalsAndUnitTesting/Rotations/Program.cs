int[] arr = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

int rotations = int.Parse(Console.ReadLine());


for (int i = 0; i < rotations; i++)
{
    int lastElement = arr[arr.Length - 1];

    
    for (int j = arr.Length - 1; j > 0; j--)
    {
        arr[j] = arr[j - 1];
    }

    
    arr[0] = lastElement;
}

Console.WriteLine(string.Join(", ", arr));