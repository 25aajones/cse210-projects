using System;
using System.IO;
using System.Text.Json;

namespace FinalProject
{
    public class UserProfile
    {
        public string Username { get; private set; }
        public int DailyGoal { get; set; }
        public int Progress { get; private set; }

        public UserProfile(string username, int dailyGoal)
        {
            Username = username;
            DailyGoal = dailyGoal;
            Progress = 0;
        }

        public void IncrementProgress(int amount)
        {
            Progress += amount;
        }

        public void SaveProfile()
        {
            string fileName = $"user_{Username}.json";
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(fileName, json);
        }

        public static UserProfile LoadProfile(string username)
        {
            string fileName = $"user_{username}.json";
            if (!File.Exists(fileName))
                return null;

            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<UserProfile>(json);
        }
    }
}
