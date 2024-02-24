using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace api;

public class TeaRepository 
{ 
   internal IEnumerable<Tea> Get()
   {
      var result = new List<Tea>();
    
      foreach (var file in Directory.GetFiles("../../data/teas/"))
      {
         result.Add(Deserialize(file));
      }

      return result; 
   }

   private Tea Deserialize(string file)
   {
      var options = new JsonSerializerOptions()
      {
         PropertyNameCaseInsensitive = true,
      };

      var json = File.ReadAllText(file);
      return JsonSerializer.Deserialize<Tea>(json, options);
   }
}
