

int[] array1 = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
int[] array2 = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();


int[] commonElements = array1.Intersect(array2).ToArray();

foreach(int element in commonElements)
{
    Console.Write(element + " ");
}    
