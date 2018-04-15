using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VigenereMAP.Services
{
    public interface ICypher
    {
        String encryptOrDecrypt(String type, String inputValue, String key);
    }
}
