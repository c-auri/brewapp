using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace api;

public class UserRepository 
{ 
   private const string userStorePath = "../../data/users/";

   internal IEnumerable<User> GetAll()
   {
      return Directory.GetFiles(userStorePath).Select(Deserialize); 
   }

   internal User GetById(int id)
   {
      return GetAll().Single(user => user.Id == id);
   }

   private User Deserialize(string file)
   {
      return JsonSerializer.Deserialize<User>(
          File.ReadAllText(file), 
          new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
   }
}
