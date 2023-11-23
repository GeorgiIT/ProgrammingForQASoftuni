namespace Articles
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] command = Console.ReadLine().Split(",");
            string title = command[0].Trim();
            string content = command[1].Trim();
            string author = command[2].Trim();
            Article article = new Article(title, content, author);
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(":");
                string actualCommand = input[0].Trim();
                string textToBeChanged = input[1].Trim();

                switch (actualCommand)
                {
                    case "Edit":
                        article.EditContent(textToBeChanged);
                      
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(textToBeChanged);
                        break;
                    case "Rename":
                        article.ChangeTitle(textToBeChanged);
                        break;
                }
            }
            Console.WriteLine(article);

        }
    }
}
