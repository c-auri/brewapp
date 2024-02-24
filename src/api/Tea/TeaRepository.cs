using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace api;

public class TeaRepository 
{ 
   private const string teaStorePath = "../../data/teas/";

   internal IEnumerable<Tea> GetAll()
   {
      return Directory.GetFiles(teaStorePath).Select(Deserialize); 
   }

   internal Tea GetById(int id)
   {
      return GetAll().Single(tea => tea.Id == id);
   }

   private Tea Deserialize(string file)
   {
      return JsonSerializer.Deserialize<Tea>(
            File.ReadAllText(file), 
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
   }
}
