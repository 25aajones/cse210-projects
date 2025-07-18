using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace FinalProject
{
    public class UserManager
    {
        private List<UserProfile> users = new List<UserProfile>();
        private const string UserDataFile = "users.json";

        public bool Register(string username, int dailyGoal)
        {
            if (users.Any(u => u.Username == username))
                return false;

            var newUser = new UserProfile(username, dailyGoal);
            users.Add(newUser);
            SaveAllUsers();
            return true;
        }

        public UserProfile Login(string username)
        {
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                user = UserProfile.LoadProfile(username);
                if (user != null)
                {
                    users.Add(user);
                    SaveAllUsers();
                }
            }
            return user;
        }

        public void SaveAllUsers()
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(UserDataFile, json);
        }

        public void LoadAllUsers()
        {
            if (!File.Exists(UserDataFile))
                return;

            string json = File.ReadAllText(UserDataFile);
            users = JsonSerializer.Deserialize<List<UserProfile>>(json) ?? new List<UserProfile>();
        }
    }
}
