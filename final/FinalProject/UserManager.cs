using System;
using System.IO;
using Newtonsoft.Json;

public class UserManager
{
    private readonly string userDataPath = "data/user.json";

    public UserProfile LoadOrCreateUser()
    {
        if (!File.Exists(userDataPath))
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            var newUser = new UserProfile { Name = name };
            SaveUser(newUser);
            return newUser;
        }

        string json = File.ReadAllText(userDataPath);
        return JsonConvert.DeserializeObject<UserProfile>(json, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });
    }

    public void SaveUser(UserProfile user)
    {
        string json = JsonConvert.SerializeObject(user, Formatting.Indented, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });

        File.WriteAllText(userDataPath, json);
    }

    public UserProfile LoginOrCreateUser()
    {
        Console.Clear();
        Console.Write("Enter your username: ");
        string name = Console.ReadLine();
        string path = $"data/user_{name}.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserProfile>(json,
                new Newtonsoft.Json.JsonSerializerSettings { TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All });
        }
        else
        {
            Console.WriteLine("New user created.");
            return new UserProfile { Name = name };
        }
    }
}
