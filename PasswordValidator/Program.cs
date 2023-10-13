static void ValidPass(string str)
{
    int digitsCount = 0;
    string symbols = " !@#$%^&*()_+=-][{}\';/.,?><|";
    bool symbolsAlert = false;
    string number = "0123456789";
    foreach (char c in str)
    {
        if (symbols.Contains(c))
        {
            symbolsAlert = true;
        }
        if (number.Contains(c))
        {
            digitsCount++;
        }
    }
    if (digitsCount >= 2 && symbolsAlert == false && str.Length >= 6 && str.Length <= 10)
    {
        Console.WriteLine("Password is valid");
    } 
    if (symbolsAlert == true)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    
    if (str.Length < 6 || str.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (digitsCount < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }

}

string pass = Console.ReadLine();
ValidPass(pass);
