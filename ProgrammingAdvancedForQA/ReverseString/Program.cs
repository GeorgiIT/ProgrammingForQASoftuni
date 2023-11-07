using System.Text;

StringBuilder sb = new StringBuilder();
while(true)
{
    string command = Console.ReadLine();
    if(command == "end")
    {
        break;
    }
    char[] reversedChar = command.ToCharArray();

    reversedChar.Reverse();
    for(int i = reversedChar.Length - 1; i >= 0; i--)
    {
        sb.Append(reversedChar[i]);
    }

    Console.WriteLine($"{command} = {sb}");
    sb.Clear();
}