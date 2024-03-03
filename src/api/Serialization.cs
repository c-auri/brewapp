using System.Collections.Generic;
using System.Text.Json;

namespace api;

internal static class Serialization
{
   internal static TEntity Deserialize<TEntity>(string filePath)
   {
       return JsonSerializer.Deserialize<TEntity>(
            File.ReadAllText(filePath),
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;
   }
}
