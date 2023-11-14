
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

        Action<Dictionary<string, string>, string, string> registerUser = (database, username, licensePlateNumber) =>
        {
            if (database.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {database[username]}");
            }
            else
            {
                database[username] = licensePlateNumber;
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        };

        Action<Dictionary<string, string>, string> unregisterUser = (database, username) =>
        {
            if (database.ContainsKey(username))
            {
                Console.WriteLine($"{username} unregistered successfully");
                database.Remove(username);
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        };

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "register")
            {
                string username = command[1];
                string licensePlateNumber = command[2];

                registerUser(parkingDatabase, username, licensePlateNumber);
            }
            else if (command[0] == "unregister")
            {
                string username = command[1];

                unregisterUser(parkingDatabase, username);
            }
        }

        foreach (var kvp in parkingDatabase)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
