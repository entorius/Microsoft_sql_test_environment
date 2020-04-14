using Json.Net;
using Microsoft_sql_test_environment.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Microsoft_sql_test_environment
{
    class JsonToObject
    {
        public List<User> JsonToUsersList(string fileName) {
            List<User> users = new List<User>();
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                users = JsonNet.Deserialize<List<User>>(json);
            }
            Console.WriteLine(users[0].FullName + " " + users[0].Country);
            Console.WriteLine("Users Count: " + users.Count);
            return users;
        }
       
    }
}
