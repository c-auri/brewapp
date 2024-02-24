using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace api;

public class TeaRepository 
{ 
   private const string teaStorePath = "../../data/teas/";

   internal IEnumerable<Tea> Get()
   {
      return Directory.GetFiles(teaStorePath).Select(Deserialize); 
   }

   private Tea Deserialize(string file)
   {
      return JsonSerializer.Deserialize<Tea>(
            File.ReadAllText(file), 
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
   }
}
