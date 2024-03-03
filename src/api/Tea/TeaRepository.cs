using System.Collections.Generic;

namespace api;

public class TeaRepository 
{ 
   private const string teaStorePath = "../../data/teas/";

   internal IEnumerable<Tea> GetAll()
   {
      return Directory.GetFiles(teaStorePath).Select(Serialization.Deserialize<Tea>); 
   }

   internal Tea? GetById(int id)
   {
      return GetAll().SingleOrDefault(tea => tea.Id == id);
   }
}
