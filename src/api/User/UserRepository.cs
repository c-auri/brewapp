using System.Collections.Generic;

namespace api;

public class UserRepository 
{ 
   private const string storePath = "../../data/users/";

   internal IEnumerable<User> GetAll()
   {
      return Directory.GetFiles(storePath).Select(Serialization.Deserialize<User>); 
   }

   internal User? GetById(int id)
   {
      return GetAll().SingleOrDefault(user => user.Id == id); 
   }
}
