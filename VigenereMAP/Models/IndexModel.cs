using System;
using VigenereMAP.Services;

namespace VigenereMAP.Models
{
    public class IndexModel
    {
        public const String ENCRYPT = "1";
        public const String DECRYPT = "2";

        public string inputValue { get; set; }
        public string key { get; set; }
        public string type { get; set; }
        public ICypher cypher { get; set; }
    }
}
