using Attributes.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Serialization.Models
{
    public class Ork
    {
        [JsonPropertyName("FirstName")]
        public string Name { get; set; }

        [JsonIgnore]
        public int Age { get; set; }
    }
}
