using System.Collections.Generic;

namespace api;

public class UserRepository 
{ 
   private const string userStorePath = "../../data/users/";

   internal IEnumerable<User> GetAll()
   {
      return Directory.GetFiles(userStorePath).Select(Serialization.Deserialize<User>); 
   }

   internal User? GetById(int id)
   {
      return GetAll().SingleOrDefault(user => user.Id == id); 
   }
}
