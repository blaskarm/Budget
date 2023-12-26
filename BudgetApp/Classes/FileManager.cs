using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace BudgetApp.Classes
{
    public class FileManager
    {
        private readonly string usersFile = Directory.GetCurrentDirectory() + "\\users.json";

        public void CreateNewUser(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(usersFile, json);
        }

        public List<User> ReadUsers(List<User> users)
        {
            if (File.Exists(usersFile))
            {
                string json = File.ReadAllText(usersFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;
        }

        private List<User> ReadUsers()
        {
            List<User> users = new List<User>();

            if (File.Exists(usersFile))
            {
                string json = File.ReadAllText(usersFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }

            return users;
        }

        public void UpdateUser(User user)
        {
            List<User> users = ReadUsers();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == user.Email)
                {
                    users[i] = user;
                    var json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(usersFile, json);
                    break;
                }
            }
        }
    }
}
